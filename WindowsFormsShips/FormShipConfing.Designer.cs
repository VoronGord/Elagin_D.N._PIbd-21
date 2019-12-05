namespace WindowsFormsShips
{
    partial class FormShipConfing
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
            this.groupBoxShip = new System.Windows.Forms.GroupBox();
            this.labelWar_Ship = new System.Windows.Forms.Label();
            this.labelLincor = new System.Windows.Forms.Label();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.panelShip = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelSilver = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.panelShip.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShip
            // 
            this.groupBoxShip.Controls.Add(this.buttonAdd);
            this.groupBoxShip.Controls.Add(this.buttonCancel);
            this.groupBoxShip.Controls.Add(this.labelLincor);
            this.groupBoxShip.Controls.Add(this.labelWar_Ship);
            this.groupBoxShip.Location = new System.Drawing.Point(12, 40);
            this.groupBoxShip.Name = "groupBoxShip";
            this.groupBoxShip.Size = new System.Drawing.Size(225, 232);
            this.groupBoxShip.TabIndex = 0;
            this.groupBoxShip.TabStop = false;
            this.groupBoxShip.Text = "Tipe Ships";
            // 
            // labelWar_Ship
            // 
            this.labelWar_Ship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWar_Ship.Location = new System.Drawing.Point(34, 47);
            this.labelWar_Ship.Name = "labelWar_Ship";
            this.labelWar_Ship.Size = new System.Drawing.Size(141, 45);
            this.labelWar_Ship.TabIndex = 1;
            this.labelWar_Ship.Text = "War_Ship";
            this.labelWar_Ship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWar_Ship_MouseDown);
            // 
            // labelLincor
            // 
            this.labelLincor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLincor.Location = new System.Drawing.Point(34, 112);
            this.labelLincor.Name = "labelLincor";
            this.labelLincor.Size = new System.Drawing.Size(141, 43);
            this.labelLincor.TabIndex = 2;
            this.labelLincor.Text = "Lincor";
            this.labelLincor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLincor_MouseDown);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShip.Location = new System.Drawing.Point(15, 14);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(207, 121);
            this.pictureBoxShip.TabIndex = 1;
            this.pictureBoxShip.TabStop = false;
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Controls.Add(this.labelMainColor);
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(310, 50);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(240, 222);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelFuchsia);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelSilver);
            this.groupBoxColor.Controls.Add(this.panelAqua);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Location = new System.Drawing.Point(613, 50);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(175, 244);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Colors";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(33, 37);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(43, 44);
            this.panelWhite.TabIndex = 0;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(94, 38);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(43, 44);
            this.panelAqua.TabIndex = 1;
            // 
            // panelSilver
            // 
            this.panelSilver.BackColor = System.Drawing.Color.Silver;
            this.panelSilver.Location = new System.Drawing.Point(33, 92);
            this.panelSilver.Name = "panelSilver";
            this.panelSilver.Size = new System.Drawing.Size(43, 44);
            this.panelSilver.TabIndex = 2;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(94, 92);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(43, 44);
            this.panelBlack.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(33, 142);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(43, 44);
            this.panelYellow.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(94, 142);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(43, 44);
            this.panelGreen.TabIndex = 3;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(94, 192);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(43, 44);
            this.panelBlue.TabIndex = 3;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(33, 192);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(43, 44);
            this.panelFuchsia.TabIndex = 5;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(15, 157);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(97, 42);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "MainColor";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(133, 157);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(89, 42);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "DopColor";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(58, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(58, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormShipConfing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 372);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBoxShip);
            this.Name = "FormShipConfing";
            this.Text = "FormShipConfing";
            this.groupBoxShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.panelShip.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShip;
        private System.Windows.Forms.Label labelLincor;
        private System.Windows.Forms.Label labelWar_Ship;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelSilver;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}