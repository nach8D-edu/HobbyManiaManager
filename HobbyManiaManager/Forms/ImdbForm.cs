using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyManiaManager.Forms
{
    public partial class ImdbForm : Form
    {
        public ImdbForm(string imdbUrl, string movieTitle)
        {
            InitializeComponent();
            this.Text = $"IMDb: {movieTitle}";
            LoadImdbPage(imdbUrl);
        }

        private void LoadImdbPage(string imdbUrl)
        {


            webView21.CoreWebView2InitializationCompleted += (s, e) =>
            {
                if (webView21.CoreWebView2 != null)
                {
                    webView21.CoreWebView2.Navigate(imdbUrl);
                }
            };

            
            webView21.EnsureCoreWebView2Async();
        }
    }
}
