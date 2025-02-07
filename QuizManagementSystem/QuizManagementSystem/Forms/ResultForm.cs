using MaterialSkin.Controls;
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
    public partial class ResultForm : MaterialForm
    {
        private List<ResultDto> _results;

        public ResultForm(List<ResultDto> results)
        {
            InitializeComponent();
            _results = results;
            LoadResults();
        }
        private void LoadResults()
        {
            dataGridView1.DataSource = _results;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
