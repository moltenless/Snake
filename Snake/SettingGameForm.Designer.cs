namespace Snake
{
    partial class SettingGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingGameForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdLowSpeed = new System.Windows.Forms.RadioButton();
            this.rdMediumSpeed = new System.Windows.Forms.RadioButton();
            this.rdFastSpeed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2d = new System.Windows.Forms.Label();
            this.rdModern = new System.Windows.Forms.RadioButton();
            this.rdClassic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(-48, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(448, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Играть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdLowSpeed
            // 
            this.rdLowSpeed.AutoSize = true;
            this.rdLowSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdLowSpeed.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rdLowSpeed.Location = new System.Drawing.Point(51, 35);
            this.rdLowSpeed.Name = "rdLowSpeed";
            this.rdLowSpeed.Size = new System.Drawing.Size(70, 20);
            this.rdLowSpeed.TabIndex = 2;
            this.rdLowSpeed.Text = "Малая";
            this.rdLowSpeed.UseVisualStyleBackColor = true;
            // 
            // rdMediumSpeed
            // 
            this.rdMediumSpeed.AutoSize = true;
            this.rdMediumSpeed.Checked = true;
            this.rdMediumSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdMediumSpeed.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rdMediumSpeed.Location = new System.Drawing.Point(51, 58);
            this.rdMediumSpeed.Name = "rdMediumSpeed";
            this.rdMediumSpeed.Size = new System.Drawing.Size(83, 20);
            this.rdMediumSpeed.TabIndex = 3;
            this.rdMediumSpeed.TabStop = true;
            this.rdMediumSpeed.Text = "Средняя";
            this.rdMediumSpeed.UseVisualStyleBackColor = true;
            // 
            // rdFastSpeed
            // 
            this.rdFastSpeed.AutoSize = true;
            this.rdFastSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdFastSpeed.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rdFastSpeed.Location = new System.Drawing.Point(51, 81);
            this.rdFastSpeed.Name = "rdFastSpeed";
            this.rdFastSpeed.Size = new System.Drawing.Size(84, 20);
            this.rdFastSpeed.TabIndex = 4;
            this.rdFastSpeed.Text = "Высокая";
            this.rdFastSpeed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Скорость:";
            // 
            // label2d
            // 
            this.label2d.AutoSize = true;
            this.label2d.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2d.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2d.Location = new System.Drawing.Point(20, 13);
            this.label2d.Name = "label2d";
            this.label2d.Size = new System.Drawing.Size(83, 23);
            this.label2d.TabIndex = 9;
            this.label2d.Text = "Режим:";
            // 
            // rdModern
            // 
            this.rdModern.AutoSize = true;
            this.rdModern.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdModern.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rdModern.Location = new System.Drawing.Point(51, 62);
            this.rdModern.Name = "rdModern";
            this.rdModern.Size = new System.Drawing.Size(118, 20);
            this.rdModern.TabIndex = 7;
            this.rdModern.Text = "Современный";
            this.rdModern.UseVisualStyleBackColor = true;
            // 
            // rdClassic
            // 
            this.rdClassic.AutoSize = true;
            this.rdClassic.Checked = true;
            this.rdClassic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdClassic.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rdClassic.Location = new System.Drawing.Point(51, 39);
            this.rdClassic.Name = "rdClassic";
            this.rdClassic.Size = new System.Drawing.Size(117, 20);
            this.rdClassic.TabIndex = 6;
            this.rdClassic.TabStop = true;
            this.rdClassic.Text = "Классический";
            this.rdClassic.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2d);
            this.panel1.Controls.Add(this.rdClassic);
            this.panel1.Controls.Add(this.rdModern);
            this.panel1.Location = new System.Drawing.Point(424, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rdLowSpeed);
            this.panel2.Controls.Add(this.rdMediumSpeed);
            this.panel2.Controls.Add(this.rdFastSpeed);
            this.panel2.Location = new System.Drawing.Point(424, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 114);
            this.panel2.TabIndex = 11;
            // 
            // SettingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змейка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdLowSpeed;
        private System.Windows.Forms.RadioButton rdMediumSpeed;
        private System.Windows.Forms.RadioButton rdFastSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2d;
        private System.Windows.Forms.RadioButton rdModern;
        private System.Windows.Forms.RadioButton rdClassic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}