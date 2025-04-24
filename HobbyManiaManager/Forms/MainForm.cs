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
        private readonly MoviesRepository _moviesRepository;
        private readonly CustomersRepository _customersRepository;

        public MainForm()
        {
            InitializeComponent();
            _moviesRepository = MoviesRepository.Instance;
            _customersRepository = CustomersRepository.Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;

            LoadMovies();
            CreateRandomCustomers();
            BuildTabs();

            labelMoviesCounter.Text = $"{_moviesRepository.Count} movies loaded.";
        }

        private void BuildTabs()
        {
            tabControlMain.Font = new Font("Segoe UI", 16, FontStyle.Regular);

            var catalog = new CatalogForm();
            ConfigureForm(catalog);
            tabPageCatalog.Controls.Add(catalog);
            catalog.Show();

            var customers = new ListCustomersForm();
            ConfigureForm(customers);
            tabPageCustomers.Controls.Add(customers);
        }

        private void ConfigureForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScaleMode = AutoScaleMode.None;
            form.Visible = true;
            form.Font = Font;
            form.Location = new Point(0, 0);
        }

        private void LoadMovies()
        {
            try
            {
                string filePath = "Resources/tmdb_top_movies_small.json";
                string json = File.ReadAllText(filePath);
                var movies = JsonConvert.DeserializeObject<List<Movie>>(json);
                if (movies != null)
                {
                    _moviesRepository.AddAll(movies);
                }
                else
                {
                    MessageBox.Show("No movies data found or the file is corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateRandomCustomers()
        {
            var generator = new RandomCustomerGenerator();
            for (int i = 0; i < 100; i++) {
                generator.Generate();
                var c = new Customer(Customer.NextCustomerId, generator.AvatarUrl, generator.FullName, generator.Email, generator.PhoneNumber, generator.RegistrationDate);
                _customersRepository.Add(c);
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm();
            catalogForm.ShowDialog();
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            var createCustomer = new EditCustomerForm(this);
            createCustomer.ShowDialog();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            var c = _customersRepository.GetById(1);
            var form = new EditCustomerForm(this, c);
            form.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}