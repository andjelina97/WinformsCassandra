
namespace UserApp
{
    partial class UserSearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDogadjajiKorisnika = new System.Windows.Forms.RadioButton();
            this.rbtInteresovanjePredmeta = new System.Windows.Forms.RadioButton();
            this.rbtKorisniciPredmet = new System.Windows.Forms.RadioButton();
            this.rbtInteresovanjeKorisnika = new System.Windows.Forms.RadioButton();
            this.tbxParametarPretrage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtDogadjajiKorisnika);
            this.panel1.Controls.Add(this.rbtInteresovanjePredmeta);
            this.panel1.Controls.Add(this.rbtKorisniciPredmet);
            this.panel1.Controls.Add(this.rbtInteresovanjeKorisnika);
            this.panel1.Location = new System.Drawing.Point(29, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 269);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(290, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Searching word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(307, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "type(username)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(306, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "type(subject name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(307, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "type(subject name)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(307, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "type(username)";
            // 
            // rbtDogadjajiKorisnika
            // 
            this.rbtDogadjajiKorisnika.AutoSize = true;
            this.rbtDogadjajiKorisnika.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDogadjajiKorisnika.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtDogadjajiKorisnika.Location = new System.Drawing.Point(18, 201);
            this.rbtDogadjajiKorisnika.Name = "rbtDogadjajiKorisnika";
            this.rbtDogadjajiKorisnika.Size = new System.Drawing.Size(134, 23);
            this.rbtDogadjajiKorisnika.TabIndex = 3;
            this.rbtDogadjajiKorisnika.TabStop = true;
            this.rbtDogadjajiKorisnika.Text = "Events of user";
            this.rbtDogadjajiKorisnika.UseVisualStyleBackColor = true;
            // 
            // rbtInteresovanjePredmeta
            // 
            this.rbtInteresovanjePredmeta.AutoSize = true;
            this.rbtInteresovanjePredmeta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInteresovanjePredmeta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtInteresovanjePredmeta.Location = new System.Drawing.Point(17, 146);
            this.rbtInteresovanjePredmeta.Name = "rbtInteresovanjePredmeta";
            this.rbtInteresovanjePredmeta.Size = new System.Drawing.Size(159, 23);
            this.rbtInteresovanjePredmeta.TabIndex = 2;
            this.rbtInteresovanjePredmeta.TabStop = true;
            this.rbtInteresovanjePredmeta.Text = "Interest of subject";
            this.rbtInteresovanjePredmeta.UseVisualStyleBackColor = true;
            // 
            // rbtKorisniciPredmet
            // 
            this.rbtKorisniciPredmet.AutoSize = true;
            this.rbtKorisniciPredmet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtKorisniciPredmet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtKorisniciPredmet.Location = new System.Drawing.Point(17, 97);
            this.rbtKorisniciPredmet.Name = "rbtKorisniciPredmet";
            this.rbtKorisniciPredmet.Size = new System.Drawing.Size(279, 23);
            this.rbtKorisniciPredmet.TabIndex = 1;
            this.rbtKorisniciPredmet.TabStop = true;
            this.rbtKorisniciPredmet.Text = "Users who searched same subject";
            this.rbtKorisniciPredmet.UseVisualStyleBackColor = true;
            // 
            // rbtInteresovanjeKorisnika
            // 
            this.rbtInteresovanjeKorisnika.AutoSize = true;
            this.rbtInteresovanjeKorisnika.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInteresovanjeKorisnika.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtInteresovanjeKorisnika.Location = new System.Drawing.Point(18, 48);
            this.rbtInteresovanjeKorisnika.Name = "rbtInteresovanjeKorisnika";
            this.rbtInteresovanjeKorisnika.Size = new System.Drawing.Size(148, 23);
            this.rbtInteresovanjeKorisnika.TabIndex = 0;
            this.rbtInteresovanjeKorisnika.TabStop = true;
            this.rbtInteresovanjeKorisnika.Text = "Interests of user";
            this.rbtInteresovanjeKorisnika.UseVisualStyleBackColor = true;
            // 
            // tbxParametarPretrage
            // 
            this.tbxParametarPretrage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxParametarPretrage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxParametarPretrage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParametarPretrage.Location = new System.Drawing.Point(29, 392);
            this.tbxParametarPretrage.Name = "tbxParametarPretrage";
            this.tbxParametarPretrage.Size = new System.Drawing.Size(204, 18);
            this.tbxParametarPretrage.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(25, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Searching options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(25, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "enter your searching word:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(29, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 1);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(29, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // dgvSearch
            // 
            this.dgvSearch.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(556, 36);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(846, 470);
            this.dgvSearch.TabIndex = 6;
            // 
            // UserSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1433, 551);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxParametarPretrage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSearchForm";
            this.Text = "UserSearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDogadjajiKorisnika;
        private System.Windows.Forms.RadioButton rbtInteresovanjePredmeta;
        private System.Windows.Forms.RadioButton rbtKorisniciPredmet;
        private System.Windows.Forms.RadioButton rbtInteresovanjeKorisnika;
        private System.Windows.Forms.TextBox tbxParametarPretrage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSearch;
    }
}