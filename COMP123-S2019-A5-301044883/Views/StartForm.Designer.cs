namespace COMP123_S2019_A5_301044883.Views
{
    partial class StartForm
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
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StartOrderButton.Location = new System.Drawing.Point(66, 216);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(230, 62);
            this.StartOrderButton.TabIndex = 0;
            this.StartOrderButton.Text = "Start New Order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(66, 300);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(230, 60);
            this.OpenSavedOrderButton.TabIndex = 0;
            this.OpenSavedOrderButton.Text = "Open Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ExitButton.Location = new System.Drawing.Point(66, 380);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(230, 59);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Your Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.StartOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

