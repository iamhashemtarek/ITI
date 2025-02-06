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
    public partial class ResultsForm : Form
    {
        private List<Result> _results;

        public ResultsForm(List<Result> results)
        {
            InitializeComponent();
            _results = results;
            LoadResults();
        }

        private void LoadResults()
        {
            dgvResults.DataSource = _results.Select(r => new
            {
                QuizTitle = r.Quiz.Title,
                StudentName = r.Student?.Username, 
                r.Score
            }).ToList();
        }
        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
