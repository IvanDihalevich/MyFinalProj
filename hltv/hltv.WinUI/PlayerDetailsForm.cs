using hltv.Core.context;
using hltv.Core.entities;
using hltv.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hltv.WinUI
{
    public partial class PlayerDetailsForm : Form
    {
        private readonly PlayerRepository _playerRepository;
        private readonly RoundStatisticsRepository _roundStatisticsRepository;
        private readonly StatisticsRepository _statisticsRepository;
        private readonly TeamRepository _teamRepository;

        private Player _selectedPlayer;

        public PlayerDetailsForm(Player selectedPlayer)
        {

            var ctx = new hltvContext();
            _playerRepository = new PlayerRepository(ctx);
            _roundStatisticsRepository = new RoundStatisticsRepository(ctx);
            _statisticsRepository = new StatisticsRepository(ctx);
            _teamRepository = new TeamRepository(ctx);

            InitializeComponent();
            _selectedPlayer = selectedPlayer;

            labelPlayerName.Text = _selectedPlayer.Nick;

            linkLabelStats.LinkClicked += LinkLabelStats_LinkClicked;

            ShowPlayerStatistics();
            SetupDataGridViewEditing();


        }

        private void LinkLabelStats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = _selectedPlayer.StatsLink,
                UseShellExecute = true
            });


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            //PlayersForm playersForm = new PlayersForm();

            //playersForm.Show();

            this.Close();
        }

        private void ShowPlayerStatistics()
        {

            if (_selectedPlayer != null)
            {

                var playerStatistics = _statisticsRepository.GetPlayerStatistics(_selectedPlayer.PlayerId);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StatisticsId", typeof(int));
                dataTable.Columns.Add("KdDifference", typeof(double));
                dataTable.Columns.Add("KdRatio", typeof(double));
                dataTable.Columns.Add("Rating", typeof(double));
                dataTable.Columns.Add("TotalKills", typeof(int));
                dataTable.Columns.Add("HeadshotPercentage", typeof(double));
                dataTable.Columns.Add("TotalDeaths", typeof(int));


                foreach (var stat in playerStatistics)
                {
                    dataTable.Rows.Add(stat.StatisticsId, stat.KdDifference, stat.KdRatio, stat.Rating, stat.TotalKills, stat.HeadshotPercentage, stat.TotalDeaths);
                }

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetupDataGridViewEditing()
        {

            dataGridView1.ReadOnly = false;

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];


            int statisticsId = Convert.ToInt32(row.Cells["StatisticsId"].Value);
            double kdDifference = Convert.ToDouble(row.Cells["KdDifference"].Value);
            double kdRatio = Convert.ToDouble(row.Cells["KdRatio"].Value);
            double rating = Convert.ToDouble(row.Cells["Rating"].Value);
            int totalKills = Convert.ToInt32(row.Cells["TotalKills"].Value);
            double headshotPercentage = Convert.ToDouble(row.Cells["HeadshotPercentage"].Value);
            int totalDeaths = Convert.ToInt32(row.Cells["TotalDeaths"].Value);


            var updatedStatistics = new Statistics
            {
                StatisticsId = statisticsId,
                KdDifference = kdDifference,
                KdRatio = kdRatio,
                Rating = rating,
                TotalKills = totalKills,
                HeadshotPercentage = headshotPercentage,
                TotalDeaths = totalDeaths
            };

            _statisticsRepository.Update(statisticsId, updatedStatistics);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChangesToDatabase();
        }

        private void SaveChangesToDatabase()
        {

            DataTable dataTable = (DataTable)dataGridView1.DataSource;


            foreach (DataRow row in dataTable.Rows)
            {
                int statisticsId = Convert.ToInt32(row["StatisticsId"]);
                double kdDifference = Convert.ToDouble(row["KdDifference"]);
                double kdRatio = Convert.ToDouble(row["KdRatio"]);
                double rating = Convert.ToDouble(row["Rating"]);
                int totalKills = Convert.ToInt32(row["TotalKills"]);
                double headshotPercentage = Convert.ToDouble(row["HeadshotPercentage"]);
                int totalDeaths = Convert.ToInt32(row["TotalDeaths"]);

                var updatedStatistics = new Statistics
                {
                    StatisticsId = statisticsId,
                    KdDifference = kdDifference,
                    KdRatio = kdRatio,
                    Rating = rating,
                    TotalKills = totalKills,
                    HeadshotPercentage = headshotPercentage,
                    TotalDeaths = totalDeaths
                };

                _statisticsRepository.Update(statisticsId, updatedStatistics);
            }

            MessageBox.Show("Зміни збережено в базі даних.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

