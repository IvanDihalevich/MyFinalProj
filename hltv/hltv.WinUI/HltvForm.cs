using Dapper;
using hltv.Core.context;
using hltv.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace hltv.WinUI
{


    public partial class HltvForm : Form
    {
        private readonly DatabaseHelper databaseHelper;

        private readonly PlayerRepository _playerRepository;
        private readonly RoundStatisticsRepository _roundStatisticsRepository;
        private readonly StatisticsRepository _statisticsRepository;
        private readonly TeamRepository _teamRepository;
        private readonly CountryRepository _countryRepository;

        private ImageList imageList;
        public HltvForm()
        {
            InitializeComponent();

            var ctx = new hltvContext();
            _playerRepository = new PlayerRepository(ctx);
            _roundStatisticsRepository = new RoundStatisticsRepository(ctx);
            _statisticsRepository = new StatisticsRepository(ctx);
            _teamRepository = new TeamRepository(ctx);
            _countryRepository = new CountryRepository(ctx);

            imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            listView1.LargeImageList = imageList;
            listView1.Font = new Font("Arial", 18);


            string connectionString = "Server=DESKTOP-9KSTUSR\\SQLEXPRESS;Database=NewsDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseHelper = new DatabaseHelper(connectionString);

            LoadDataFromDatabase();
        }



        private void LoadDataFromDatabase()
        {
            using (var connection = new SqlConnection(databaseHelper.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT Description, ImagePath FROM News";

                var data = connection.Query(sql);

                foreach (var item in data)
                {
                    string description = item.Description;
                    string imagePath = item.ImagePath;

                    imageList.Images.Add(description, Image.FromFile(imagePath));

                    ListViewItem listViewItem = new ListViewItem(description);
                    listViewItem.ImageKey = description;
                    listView1.Items.Add(listViewItem);
                }
            }
        }



        private void pictureBoxPlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayersForm newForm = new PlayersForm();


            newForm.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }

            Application.Exit();
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }

            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Виберіть зображення";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string description = Microsoft.VisualBasic.Interaction.InputBox("Введіть опис для зображення:", "Опис зображення", "");

                imageList.Images.Add(description, Image.FromFile(imagePath));

                ListViewItem item = new ListViewItem(description);
                item.ImageKey = description;
                listView1.Items.Add(item);


                databaseHelper.InsertData(description, imagePath);

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedDescription = listView1.SelectedItems[0].Text;


                listView1.SelectedItems[0].Remove();


                databaseHelper.DeleteData(selectedDescription);
            }
        }

        private void pictureBoxTeam_Click(object sender, EventArgs e)
        {
            TeamStatsForm teamStatsForm = new TeamStatsForm();
            this.Close();

            teamStatsForm.Show();
        }



    }
}
