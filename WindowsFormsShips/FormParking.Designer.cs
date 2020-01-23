namespace WindowsFormsShips
{
    partial class FormParking
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
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.groupBoxTaleShip = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.SetShip = new System.Windows.Forms.Button();
            this.groupBoxTaleShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(59, 67);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(86, 33);
            this.buttonTakeShip.TabIndex = 2;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // groupBoxTaleShip
            // 
            this.groupBoxTaleShip.Controls.Add(this.pictureBoxTakeShip);
            this.groupBoxTaleShip.Controls.Add(this.maskedTextBox);
            this.groupBoxTaleShip.Controls.Add(this.labelPlace);
            this.groupBoxTaleShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTaleShip.Location = new System.Drawing.Point(1063, 316);
            this.groupBoxTaleShip.Name = "groupBoxTaleShip";
            this.groupBoxTaleShip.Size = new System.Drawing.Size(222, 208);
            this.groupBoxTaleShip.TabIndex = 8;
            this.groupBoxTaleShip.TabStop = false;
            this.groupBoxTaleShip.Text = "Забрать Корабль";
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(10, 106);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(180, 82);
            this.pictureBoxTakeShip.TabIndex = 5;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(84, 39);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(49, 22);
            this.maskedTextBox.TabIndex = 4;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 39);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 3;
            this.labelPlace.Text = "Место:";
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(7, 13);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1031, 511);
            this.pictureBoxParking.TabIndex = 9;
            this.pictureBoxParking.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1085, 44);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(168, 148);
            this.listBoxLevels.TabIndex = 10;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // SetShip
            // 
            this.SetShip.Location = new System.Drawing.Point(1113, 228);
            this.SetShip.Name = "SetShip";
            this.SetShip.Size = new System.Drawing.Size(95, 40);
            this.SetShip.TabIndex = 11;
            this.SetShip.Text = "Заказ Коробля";
            this.SetShip.UseVisualStyleBackColor = true;
            this.SetShip.Click += new System.EventHandler(this.SetShip_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 594);
            this.Controls.Add(this.SetShip);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxTaleShip);
            this.Name = "FormParking";
            this.Text = "FormParking";
            this.groupBoxTaleShip.ResumeLayout(false);
            this.groupBoxTaleShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.GroupBox groupBoxTaleShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button SetShip;
    }
}