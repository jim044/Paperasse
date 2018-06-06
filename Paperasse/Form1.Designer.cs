namespace Paperasse
{
    partial class Form1
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
            this.buttonParcourir.Location = new System.Drawing.Point(26, 56);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(220, 23);
            this.buttonParcourir.TabIndex = 0;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // textBoxTextATrouve
            // 
            this.textBoxTextATrouve.Location = new System.Drawing.Point(26, 12);
            this.textBoxTextATrouve.Name = "textBoxTextATrouve";
            this.textBoxTextATrouve.Size = new System.Drawing.Size(220, 20);
            this.textBoxTextATrouve.TabIndex = 1;
            // 
            // labelTextTrouve
            // 
            this.labelTextTrouve.AutoSize = true;
            this.labelTextTrouve.Location = new System.Drawing.Point(104, 165);
            this.labelTextTrouve.Name = "labelTextTrouve";
            this.labelTextTrouve.Size = new System.Drawing.Size(60, 13);
            this.labelTextTrouve.TabIndex = 2;
            this.labelTextTrouve.Text = "Non trouvé";
            // 
            // progressBarSearchOCR
            // 
            this.progressBarSearchOCR.Location = new System.Drawing.Point(282, 12);
            this.progressBarSearchOCR.Name = "progressBarSearchOCR";
            this.progressBarSearchOCR.Size = new System.Drawing.Size(100, 23);
            this.progressBarSearchOCR.TabIndex = 3;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(80, 122);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(114, 23);
            this.buttonRechercher.TabIndex = 4;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // labelCheminFichier
            // 
            this.labelCheminFichier.AutoSize = true;
            this.labelCheminFichier.Location = new System.Drawing.Point(23, 82);
            this.labelCheminFichier.Name = "labelCheminFichier";
            this.labelCheminFichier.Size = new System.Drawing.Size(0, 13);
            this.labelCheminFichier.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 572);
            this.Controls.Add(this.labelCheminFichier);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.progressBarSearchOCR);
            this.Controls.Add(this.labelTextTrouve);
            this.Controls.Add(this.textBoxTextATrouve);
            this.Controls.Add(this.buttonParcourir);
            this.Name = "Form1";
            this.Text = "Form1";
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

