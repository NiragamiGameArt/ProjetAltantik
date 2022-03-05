namespace ProjetAltantik
{
    partial class frmAjouterLiaison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(66, 16);
            this.lblNomSecteur.TabIndex = 0;
            this.lblNomSecteur.Text = "Secteurs :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(182, 31);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(60, 16);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = " Départ : ";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(430, 173);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(69, 16);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distance : ";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(430, 31);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(59, 16);
            this.lblArrivee.TabIndex = 3;
            this.lblArrivee.Text = "Arrivée : ";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(519, 170);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(121, 22);
            this.tbxDistance.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(519, 217);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(519, 28);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(121, 24);
            this.cmbArrivee.TabIndex = 6;
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(253, 28);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 24);
            this.cmbDepart.TabIndex = 7;
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.ItemHeight = 16;
            this.lbxSecteurs.Location = new System.Drawing.Point(15, 28);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 212);
            this.lbxSecteurs.TabIndex = 8;
            // 
            // frmAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 275);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblNomSecteur);
            this.Name = "frmAjouterLiaison";
            this.Text = "Ajouter une liaison";
            this.Load += new System.EventHandler(this.frmAjouterLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomSecteur;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbArrivee;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ListBox lbxSecteurs;
    }
}