namespace WindowsFormsShips
{
    partial class FormLincor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.GenerLincor = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(937, 499);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // GenerLincor
            // 
            this.GenerLincor.Location = new System.Drawing.Point(25, 12);
            this.GenerLincor.Name = "GenerLincor";
            this.GenerLincor.Size = new System.Drawing.Size(103, 45);
            this.GenerLincor.TabIndex = 1;
            this.GenerLincor.Text = "GenerLincor";
            this.GenerLincor.UseVisualStyleBackColor = true;
            this.GenerLincor.Click += new System.EventHandler(this.GenerLincor_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(727, 393);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(91, 45);
            this.Up.TabIndex = 2;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(727, 444);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(91, 45);
            this.Down.TabIndex = 3;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(613, 444);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(91, 45);
            this.Left.TabIndex = 4;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(837, 444);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(91, 45);
            this.Right.TabIndex = 5;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormLincor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 514);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.GenerLincor);
            this.Controls.Add(this.pictureBoxShip);
            this.Name = "FormLincor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button GenerLincor;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
    }
}

