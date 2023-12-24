using hltv.Core.context;
using hltv.Core.entities;
using hltv.Repositories;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace hltv.WinUI
{
    public partial class TeamStatsForm : Form
    {
        private readonly TeamRepository _teamRepository;
        private readonly CountryRepository _countryRepository;
        private List<Team> _teams;
        public TeamStatsForm()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository(new hltvContext());
            _countryRepository = new CountryRepository(new hltvContext());

            PopulateComboBoxWithCountries();
            PopulateListBoxWithTeams();

            buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
        }



        private void PopulateComboBoxWithCountries()
        {
            var countries = _countryRepository.GetAll();
            var uniqueCountries = countries.DistinctBy(c => c.Name).ToList();
            comboBoxCountries.DisplayMember = "Name";
            comboBoxCountries.DataSource = uniqueCountries;
        }
        private void PopulateListBoxWithTeams()
        {
            var teams = _teamRepository.GetAll();

            listBoxTeam.Items.Clear();

            foreach (var team in teams)
            {
                listBoxTeam.Items.Add(team);
            }
        }

        private void PopulateListBoxWithTeams(List<Team> teamsToShow)
        {
            listBoxTeam.Items.Clear();

            foreach (var team in teamsToShow)
            {
                listBoxTeam.Items.Add(team);
            }

            if (listBoxTeam.Items.Count > 0)
            {
                listBoxTeam.SelectedIndex = 0;
            }
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedItem is Team selectedTeam)
            {
                Console.WriteLine($"Обрана команда: {selectedTeam.TeamName}");
                ShowPlayersInMessageBox(selectedTeam);
            }
        }

        private void ShowPlayersInMessageBox(Team selectedTeam)
        {
            var players = _teamRepository.GetPlayersForTeam(selectedTeam.TeamId);
            var playersInfo = new StringBuilder();
            foreach (var player in players)
            {
                playersInfo.AppendLine(player.ToString());
            }

            MessageBox.Show(playersInfo.ToString(), "Гравці команди", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountries.SelectedItem is Country selectedCountry)
            {

                var teamsInCountry = _teamRepository
                    .GetAll()
                    .Where(team => team.Players.Any(player => player.CountryId == selectedCountry.CountryId))
                    .ToList();


                PopulateListBoxWithTeams(teamsInCountry);
            }

        }




        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();

            HltvForm hltvForm = new HltvForm();
            hltvForm.Show();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (comboBoxCountries.SelectedItem is Country selectedCountry)
            {
                listBoxTeam.SelectedIndexChanged -= listBoxTeam_SelectedIndexChanged;

                var teamsInCountry = _teamRepository
                    .GetAll()
                    .AsQueryable()
                    .Include(t => t.Players)
                    .Where(team => team.Players != null && team.Players.Any(player => player.CountryId == selectedCountry.CountryId))
                    .ToList();

                PopulateListBoxWithTeams(teamsInCountry);

                listBoxTeam.SelectedIndexChanged += listBoxTeam_SelectedIndexChanged;
            }
        }

        private void buttonShowAllTeams_Click(object sender, EventArgs e)
        {
            var allTeams = _teamRepository.GetAll().ToList();
            PopulateListBoxWithTeams(allTeams);
        }
    }
}
