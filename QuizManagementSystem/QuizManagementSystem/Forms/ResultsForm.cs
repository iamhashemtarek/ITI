﻿using MaterialSkin.Controls;
using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Forms
{
    public partial class ResultsForm : MaterialForm
    {
        private List<ResultDto> _results;

        public ResultsForm(List<ResultDto> results)
        {
            InitializeComponent();
            GlobalStyle.Apply(this);

            _results = results;
            LoadResults();
        }

        private void LoadResults()
        {
            dataGridView1.DataSource = _results;
        }
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
