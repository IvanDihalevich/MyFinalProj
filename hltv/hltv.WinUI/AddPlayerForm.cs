using hltv.Core.context;
using hltv.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hltv.Core.entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;


namespace hltv.WinUI
{
    public partial class AddPlayerForm : Form
    {
        private readonly PlayerRepository _playerRepository;
        private readonly RoundStatisticsRepository _roundStatisticsRepository;
        private readonly StatisticsRepository _statisticsRepository;
        private readonly TeamRepository _teamRepository;
        private readonly CountryRepository _countryRepository;

        public AddPlayerForm()
        {
            InitializeComponent();

            var ctx = new hltvContext();
            _playerRepository = new PlayerRepository(ctx);
            _roundStatisticsRepository = new RoundStatisticsRepository(ctx);
            _statisticsRepository = new StatisticsRepository(ctx);
            _teamRepository = new TeamRepository(ctx);
            _countryRepository = new CountryRepository(ctx);

            cmbCountry.DisplayMember = "CountryName"; 
            cmbCountry.ValueMember = "CountryId"; 
            cmbCountry.DataSource = _countryRepository.GetAll().ToList();


            cmbTeam.DisplayMember = "TeamName"; 
            cmbTeam.ValueMember = "TeamId"; 
            cmbTeam.DataSource = _teamRepository.GetAll().ToList();

            cmbRoundStatistics.DisplayMember = "RoundStatisticsId";
            cmbRoundStatistics.ValueMember = "RoundStatisticsId";
            cmbRoundStatistics.DataSource = _roundStatisticsRepository.GetAll().ToList();

            cmbStatistics.DisplayMember = "StatisticsId";
            cmbStatistics.ValueMember = "StatisticsId";
            cmbStatistics.DataSource = _statisticsRepository.GetAll().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string nick = txtNick.Text;

            int countryId;
            if (cmbCountry.SelectedValue != null && int.TryParse(cmbCountry.SelectedValue.ToString(), out countryId))
            {
                string statsLink = txtStatsLink.Text;

                int teamId;
                if (cmbTeam.SelectedValue != null && int.TryParse(cmbTeam.SelectedValue.ToString(), out teamId))
                {
                    int roundStatisticsId;
                    if (cmbRoundStatistics.SelectedValue != null && int.TryParse(cmbRoundStatistics.SelectedValue.ToString(), out roundStatisticsId))
                    {
                        int statisticsId;
                        if (cmbStatistics.SelectedValue != null && int.TryParse(cmbStatistics.SelectedValue.ToString(), out statisticsId))
                        {
                            Player newPlayer = new Player
                            {
                                Nick = nick,
                                CountryId = countryId,
                                StatsLink = statsLink,
                                TeamId = teamId,
                                RoundStatisticsId = roundStatisticsId,
                                StatisticsId = statisticsId
                            };

                            _playerRepository.Add(newPlayer);
                            _playerRepository.Save();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please select statistics.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select round statistics.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
