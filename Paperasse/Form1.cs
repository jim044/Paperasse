using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paperasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            var testImage = @"C:\Users\jvillossel\Downloads\factureImage.png";

            var Results = Ocr.Read(testImage);

            var Barcodes = Results.Barcodes.Select(b => b.Value);

            foreach (var page in Results.Pages)
            {
                // page object
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
                            String word_text = word.Text;
                            //Console.WriteLine(word_text);
                            if (word_text == "SMEG" || word_text == "Fideli")
                            {
                                Console.WriteLine(word_text);
                            }

                            //foreach (var character in word.Characters)
                            //{
                            //    // pages -> paragraphs -> lines -> words -> characters
                            //    int character_number = character.CharacterNumber;
                            //    String character_text = character.Text;
                            //    System.Drawing.Image character_image = character.Image;
                            //    int character_x_location = character.X;
                            //    int character_y_location = character.Y;
                            //    int character_width = character.Width;
                            //    int character_height = character.Height;
                            //    double character_ocr_accuracy = character.Confidence;
                            //}
                        }
                    }
                }
            }



            //var OcrBis = new AdvancedOcr()
            //{
            //    CleanBackgroundNoise = false,
            //    ColorDepth = 4,
            //    ColorSpace = AdvancedOcr.OcrColorSpace.Color,
            //    EnhanceContrast = false,
            //    DetectWhiteTextOnDarkBackgrounds = false,
            //    RotateAndStraighten = false,
            //    Language = IronOcr.Languages.French.OcrLanguagePack,
            //    EnhanceResolution = false,
            //    InputImageType = AdvancedOcr.InputTypes.Document,
            //    ReadBarCodes = true,
            //    Strategy = AdvancedOcr.OcrStrategy.Fast
            //};

            //var ResultsBis = OcrBis.ReadPdf(@"C:\Users\jvillossel\Downloads\Old\2018-03-ALLIANCE-JVIL Facture Kode4You F18030002.pdf");
            //var Pages = ResultsBis.Pages;
            //var BarcodesBis = ResultsBis.Barcodes;
            //var FullPdfText = ResultsBis.Text;
            //Console.WriteLine(FullPdfText);
        }
    }
}
