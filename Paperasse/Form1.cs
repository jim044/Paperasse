using IronOcr;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paperasse
{
    public partial class Paperasse : Form
    {
        private OpenFileDialog openFile = new OpenFileDialog();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string sslmode;

        public Paperasse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=paperasseData;");
            conn.Open();

            string query = "SELECT * FROM fournisseur";
            MySqlCommand cmd = new MySqlCommand(query, connection);


            //server = "localhost";
            //database = "paperasse";
            //uid = "root";
            //password = "";
            //sslmode = "none";
            //string connectionString;
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            //database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SSLMODE="+ sslmode +";";

            //connection = new MySqlConnection(connectionString);
            //connection.Open();

            //string query = "SELECT * FROM fournisseur";

            //MySqlCommand cmd = new MySqlCommand(query, connection);
            ////Create a data reader and Execute the command
            //MySqlDataReader dataReader = cmd.ExecuteReader();

            //while (dataReader.Read())
            //{
            //     string first = dataReader["nom"].ToString();
            //}
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            labelTextTrouve.Text = "Non trouvé";
            progressBarSearchOCR.Maximum = 0;
            progressBarSearchOCR.Minimum = 0;
            progressBarSearchOCR.Step = 1;

            openFile.DefaultExt = "png";
            openFile.Filter = "PNG|*.png|JPG|*.jpg";
            openFile.ShowDialog();

            if (openFile.FileNames.Length > 0)
            {
                labelCheminFichier.Text = openFile.FileName;
            }
        }

        private void trouverLeText(string fileName)
        {
            var Ocr = new AdvancedOcr()
            {
                CleanBackgroundNoise = true,
                EnhanceContrast = true,
                EnhanceResolution = true,
                Language = IronOcr.Languages.French.OcrLanguagePack,
                Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
                ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                DetectWhiteTextOnDarkBackgrounds = true,
                InputImageType = AdvancedOcr.InputTypes.AutoDetect,
                RotateAndStraighten = true,
                ReadBarCodes = true,
                ColorDepth = 4
            };


            //var Path = Application.ExecutablePath;
            //Path = Directory.GetParent(Path).ToString();
            //var lePath = Directory.GetParent(Path).ToString();
            //var testImage = fileName;

            var Results = Ocr.Read(fileName);

            var Barcodes = Results.Barcodes.Select(b => b.Value);
            var nbWord = 0;

           

            foreach (var a in Results.Pages[0].Words)
            {
                nbWord += 1;
            }

            progressBarSearchOCR.Maximum = nbWord;
            progressBarSearchOCR.Minimum = 0;
            progressBarSearchOCR.Step = 1;


            foreach (var page in Results.Pages)
            {
                int page_number = page.PageNumber;
                String page_text = page.Text;
                int page_wordcount = page.WordCount;

                System.Drawing.Image page_image = page.Image;

                int page_width_px = page.Width;
                int page_height_px = page.Height;

                foreach (var paragraph in page.Paragraphs)
                {

                    foreach (var line in paragraph.Lines)
                    {

                        foreach (var word in line.Words)
                        {
                            progressBarSearchOCR.PerformStep();
                            String word_text = word.Text;
                            if (word_text == textBoxTextATrouve.Text)
                            {
                                Console.WriteLine(word_text);
                                labelTextTrouve.Text = "Trouvé";  
                            }
                        }
                    }
                }
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (openFile.FileNames.Length > 0)
            {
                trouverLeText(openFile.FileName);
            }
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
