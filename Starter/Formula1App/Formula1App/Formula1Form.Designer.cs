namespace Formula1App
{
    partial class Formula1Form
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
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.buttonGetRacers = new System.Windows.Forms.Button();
            this.listBoxRacers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(101, 100);
            this.comboBoxCountries.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(326, 33);
            this.comboBoxCountries.TabIndex = 2;
            // 
            // buttonGetRacers
            // 
            this.buttonGetRacers.Location = new System.Drawing.Point(560, 100);
            this.buttonGetRacers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGetRacers.Name = "buttonGetRacers";
            this.buttonGetRacers.Size = new System.Drawing.Size(270, 44);
            this.buttonGetRacers.TabIndex = 3;
            this.buttonGetRacers.Text = "Get Racers";
            this.buttonGetRacers.UseVisualStyleBackColor = true;
            this.buttonGetRacers.Click += new System.EventHandler(this.OnGetRacers);
            // 
            // listBoxRacers
            // 
            this.listBoxRacers.FormattingEnabled = true;
            this.listBoxRacers.ItemHeight = 25;
            this.listBoxRacers.Location = new System.Drawing.Point(101, 234);
            this.listBoxRacers.Name = "listBoxRacers";
            this.listBoxRacers.Size = new System.Drawing.Size(427, 529);
            this.listBoxRacers.TabIndex = 4;
            // 
            // Formula1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 823);
            this.Controls.Add(this.listBoxRacers);
            this.Controls.Add(this.buttonGetRacers);
            this.Controls.Add(this.comboBoxCountries);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Formula1Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonGetRacers;
        private System.Windows.Forms.ListBox listBoxRacers;
    }
}

