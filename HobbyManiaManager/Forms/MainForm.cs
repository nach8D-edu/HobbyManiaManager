using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using HobbyManiaManager.Models;
using HobbyManiaManager.Forms;
using System.Drawing;
using HobbyManiaManager.Utils;

namespace HobbyManiaManager
{
    public partial class MainForm : Form
    {
        private readonly MoviesRepository moviesRepository;
        private readonly CustomersRepository customersRepository;

        public MainForm()
        {
            InitializeComponent();
            moviesRepository = MoviesRepository.Instance;
            customersRepository = CustomersRepository.Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;

            LoadMovies();
            CreateRandomCustomers();
            BuildTabs();

            labelMoviesCounter.Text = $"{moviesRepository.Count} movies loaded.";
        }

        private void BuildTabs()
        {
            this.tabControlMain.Font = new Font("Segoe UI", 16, FontStyle.Regular);

            var catalog = new CatalogForm();
            ConfigureForm(catalog);
            this.tabPageCatalog.Controls.Add(catalog);
            catalog.Show();

            var customers = new CustomersListForm();
            ConfigureForm(customers);
            this.tabPageCustomers.Controls.Add(customers);
        }

        private void ConfigureForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScaleMode = AutoScaleMode.None;
            form.Visible = true;
            form.Font = this.Font;
            form.Location = new Point(0, 0);
        }

        private void LoadMovies()
        {
            string filePath = "Resources/tmdb_top_movies_small.json";
            string json = File.ReadAllText(filePath);
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            moviesRepository.AddAll(movies);
        }

        private void CreateRandomCustomers()
        {
            var generator = new RandomCustomerGenerator();
            for (int i = 0; i < 100; i++) {
                generator.Generate();
                var c = new Customer(Customer.NextCustomerId, generator.AvatarUrl, generator.FullName, generator.Email, generator.PhoneNumber, generator.RegistrationDate);
                customersRepository.Add(c);
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm();
            catalogForm.ShowDialog();
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            var createCustomer = new CustomerEditForm(this);
            createCustomer.ShowDialog();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            var c = customersRepository.GetById(1);
            var form = new CustomerEditForm(this, c);
            form.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}