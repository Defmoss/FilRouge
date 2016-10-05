namespace WindowsFormsApplication1
{
    partial class Interface_recherche_clients
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
            this.prenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.date_naiss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.code_postal = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.refClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(112, 80);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(145, 20);
            this.prenom.TabIndex = 47;
            this.prenom.UseWaitCursor = true;
            this.prenom.TextChanged += new System.EventHandler(this.prenom_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "RECHERCHE CLIENTS";
            this.label9.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(475, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(112, 345);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(145, 20);
            this.mail.TabIndex = 42;
            this.mail.UseWaitCursor = true;
            this.mail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "mail_client";
            this.label8.UseWaitCursor = true;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "adress_client";
            this.label6.UseWaitCursor = true;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(112, 223);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(145, 20);
            this.adress.TabIndex = 39;
            this.adress.UseWaitCursor = true;
            // 
            // date_naiss
            // 
            this.date_naiss.Location = new System.Drawing.Point(112, 169);
            this.date_naiss.Multiline = true;
            this.date_naiss.Name = "date_naiss";
            this.date_naiss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.date_naiss.Size = new System.Drawing.Size(145, 27);
            this.date_naiss.TabIndex = 38;
            this.date_naiss.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "date_naiss_client";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "prenom_client";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "nom_client";
            this.label3.UseWaitCursor = true;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(112, 38);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(145, 20);
            this.nom.TabIndex = 34;
            this.nom.UseWaitCursor = true;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // code_postal
            // 
            this.code_postal.Location = new System.Drawing.Point(112, 263);
            this.code_postal.Name = "code_postal";
            this.code_postal.Size = new System.Drawing.Size(145, 20);
            this.code_postal.TabIndex = 51;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(112, 306);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(145, 20);
            this.telephone.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "code_postal_client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "telephone_client";
            // 
            // sexe
            // 
            this.sexe.Location = new System.Drawing.Point(112, 121);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(145, 20);
            this.sexe.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "sexe_client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "non valide";
            this.label1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "ref_client";
            this.label11.UseWaitCursor = true;
            // 
            // refClient
            // 
            this.refClient.Location = new System.Drawing.Point(112, 383);
            this.refClient.Name = "refClient";
            this.refClient.Size = new System.Drawing.Size(145, 20);
            this.refClient.TabIndex = 58;
            this.refClient.UseWaitCursor = true;
            // 
            // Interface_recherche_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.code_postal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.date_naiss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom);
            this.Name = "Interface_recherche_clients";
            this.Text = "interface_recherche_clients";
            this.Load += new System.EventHandler(this.interface_recherche_clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox date_naiss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox code_postal;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sexe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox refClient;
    }
}