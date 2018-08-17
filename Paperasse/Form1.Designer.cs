namespace Paperasse
{
    partial class Paperasse
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.textBoxTextATrouve = new System.Windows.Forms.TextBox();
            this.labelTextTrouve = new System.Windows.Forms.Label();
            this.progressBarSearchOCR = new System.Windows.Forms.ProgressBar();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.labelCheminFichier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Location = new System.Drawing.Point(537, 507);
            this.buttonParcourir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(293, 28);
            this.buttonParcourir.TabIndex = 0;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // textBoxTextATrouve
            // 
            this.textBoxTextATrouve.Location = new System.Drawing.Point(537, 453);
            this.textBoxTextATrouve.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTextATrouve.Name = "textBoxTextATrouve";
            this.textBoxTextATrouve.Size = new System.Drawing.Size(292, 22);
            this.textBoxTextATrouve.TabIndex = 1;
            // 
            // labelTextTrouve
            // 
            this.labelTextTrouve.AutoSize = true;
            this.labelTextTrouve.Location = new System.Drawing.Point(641, 641);
            this.labelTextTrouve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextTrouve.Name = "labelTextTrouve";
            this.labelTextTrouve.Size = new System.Drawing.Size(78, 17);
            this.labelTextTrouve.TabIndex = 2;
            this.labelTextTrouve.Text = "Non trouvé";
            // 
            // progressBarSearchOCR
            // 
            this.progressBarSearchOCR.Location = new System.Drawing.Point(878, 453);
            this.progressBarSearchOCR.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarSearchOCR.Name = "progressBarSearchOCR";
            this.progressBarSearchOCR.Size = new System.Drawing.Size(133, 28);
            this.progressBarSearchOCR.TabIndex = 3;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(609, 588);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(152, 28);
            this.buttonRechercher.TabIndex = 4;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // labelCheminFichier
            // 
            this.labelCheminFichier.AutoSize = true;
            this.labelCheminFichier.Location = new System.Drawing.Point(31, 101);
            this.labelCheminFichier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheminFichier.Name = "labelCheminFichier";
            this.labelCheminFichier.Size = new System.Drawing.Size(0, 17);
            this.labelCheminFichier.TabIndex = 5;
            // 
            // Paperasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 704);
            this.Controls.Add(this.labelCheminFichier);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.progressBarSearchOCR);
            this.Controls.Add(this.labelTextTrouve);
            this.Controls.Add(this.textBoxTextATrouve);
            this.Controls.Add(this.buttonParcourir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Paperasse";
            this.Text = "Paperasse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.TextBox textBoxTextATrouve;
        private System.Windows.Forms.Label labelTextTrouve;
        private System.Windows.Forms.ProgressBar progressBarSearchOCR;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Label labelCheminFichier;
    }
}

