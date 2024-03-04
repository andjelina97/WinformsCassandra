
namespace TestApp
{
    partial class WineShopForm
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
            this.Wines = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt5 = new System.Windows.Forms.RadioButton();
            this.rbt4 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.btnRate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wines
            // 
            this.Wines.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Wines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Wines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wines.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Wines.FormattingEnabled = true;
            this.Wines.ItemHeight = 23;
            this.Wines.Location = new System.Drawing.Point(27, 22);
            this.Wines.Name = "Wines";
            this.Wines.Size = new System.Drawing.Size(375, 552);
            this.Wines.TabIndex = 0;
            this.Wines.SelectedIndexChanged += new System.EventHandler(this.Wines_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbt5);
            this.groupBox1.Controls.Add(this.rbt4);
            this.groupBox1.Controls.Add(this.rbt3);
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Controls.Add(this.btnRate);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(438, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rate";
            // 
            // rbt5
            // 
            this.rbt5.AutoSize = true;
            this.rbt5.Location = new System.Drawing.Point(215, 55);
            this.rbt5.Name = "rbt5";
            this.rbt5.Size = new System.Drawing.Size(42, 26);
            this.rbt5.TabIndex = 5;
            this.rbt5.TabStop = true;
            this.rbt5.Text = "5";
            this.rbt5.UseVisualStyleBackColor = true;
            // 
            // rbt4
            // 
            this.rbt4.AutoSize = true;
            this.rbt4.Location = new System.Drawing.Point(167, 55);
            this.rbt4.Name = "rbt4";
            this.rbt4.Size = new System.Drawing.Size(42, 26);
            this.rbt4.TabIndex = 4;
            this.rbt4.TabStop = true;
            this.rbt4.Text = "4";
            this.rbt4.UseVisualStyleBackColor = true;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Location = new System.Drawing.Point(116, 55);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(42, 26);
            this.rbt3.TabIndex = 3;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "3";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(68, 55);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(42, 26);
            this.rbt2.TabIndex = 2;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "2";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(20, 55);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(42, 26);
            this.rbt1.TabIndex = 1;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "1";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(209)))), ((int)(((byte)(193)))));
            this.btnRate.FlatAppearance.BorderSize = 0;
            this.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRate.Location = new System.Drawing.Point(18, 120);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(157, 41);
            this.btnRate.TabIndex = 0;
            this.btnRate.Text = "SAVE";
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            this.btnRate.MouseEnter += new System.EventHandler(this.btnRate_MouseEnter);
            this.btnRate.MouseLeave += new System.EventHandler(this.btnRate_MouseLeave);
            this.btnRate.MouseHover += new System.EventHandler(this.btnRate_MouseHover_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.tbxComment);
            this.groupBox2.Controls.Add(this.btnComment);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(438, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comment";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(18, 27);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(326, 98);
            this.tbxComment.TabIndex = 1;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(209)))), ((int)(((byte)(193)))));
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnComment.Location = new System.Drawing.Point(18, 144);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(157, 41);
            this.btnComment.TabIndex = 0;
            this.btnComment.Text = "SAVE";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            this.btnComment.MouseEnter += new System.EventHandler(this.btnComment_MouseEnter);
            this.btnComment.MouseLeave += new System.EventHandler(this.btnComment_MouseLeave);
            this.btnComment.MouseHover += new System.EventHandler(this.btnComment_MouseHover_1);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(209)))), ((int)(((byte)(193)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetails.Location = new System.Drawing.Point(440, 469);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(207, 40);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "MORE DETAILS";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            this.btnDetails.MouseEnter += new System.EventHandler(this.btnDetails_MouseEnter);
            this.btnDetails.MouseLeave += new System.EventHandler(this.btnDetails_MouseLeave);
            this.btnDetails.MouseHover += new System.EventHandler(this.btnDetails_MouseHover_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(209)))), ((int)(((byte)(193)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrder.Location = new System.Drawing.Point(440, 534);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(207, 40);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseEnter += new System.EventHandler(this.btnOrder_MouseEnter);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseHover += new System.EventHandler(this.btnOrder_MouseHover_1);
            // 
            // WineShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Wines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WineShopForm";
            this.Text = "WineShopForm";
         
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Wines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt5;
        private System.Windows.Forms.RadioButton rbt4;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnOrder;
    }
}