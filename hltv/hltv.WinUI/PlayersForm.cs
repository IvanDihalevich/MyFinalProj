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
using System.Diagnostics;
using hltv.Core.entities;

namespace hltv.WinUI
{
    public partial class PlayersForm : Form
    {

        private readonly PlayerRepository _playerRepository;
        private readonly RoundStatisticsRepository _roundStatisticsRepository;
        private readonly StatisticsRepository _statisticsRepository;
        private readonly TeamRepository _teamRepository;
        public PlayersForm()
        {
            InitializeComponent();

            var ctx = new hltvContext();
            _playerRepository = new PlayerRepository(ctx);
            _roundStatisticsRepository = new RoundStatisticsRepository(ctx);
            _statisticsRepository = new StatisticsRepository(ctx);
            _teamRepository = new TeamRepository(ctx);

            UpdateListBoxData();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show();

        }


        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();

            HltvForm hltvForm = new HltvForm();
            hltvForm.Show();
        }

        private void listBoxPlayer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxPlayer.SelectedItem != null)
            {

                Player selectedPlayer = (Player)listBoxPlayer.SelectedItem;

                PlayerDetailsForm playerDetailsForm = new PlayerDetailsForm(selectedPlayer);
                playerDetailsForm.Show();
                //this.Close();
            }
        }

        private void PlayersForm_Load_1(object sender, EventArgs e)
        {
            listBoxPlayer.Items.Clear();
            listBoxPlayer.Items.AddRange(_playerRepository.GetAll().ToArray());
        }

        private void UpdateListBoxData()
        {

            listBoxPlayer.Items.Clear();
            listBoxPlayer.Items.AddRange(_playerRepository.GetAll().ToArray());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateListBoxData();
        }
    }
}
