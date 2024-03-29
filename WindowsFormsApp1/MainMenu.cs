﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            addQuoteForm.Show();
        }

        private void searchQuote_Click(object sender, EventArgs e)
        {
            var searchQuoteForm = new SearchQuote();
            searchQuoteForm.Show();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            var viewQuoteForm = new ViewQuote();
            viewQuoteForm.Show();
        }
    }
}
