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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.buttonGetRacers = new System.Windows.Forms.Button();
            this.listViewRacers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(40, 52);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCountries.TabIndex = 2;
            // 
            // buttonGetRacers
            // 
            this.buttonGetRacers.Location = new System.Drawing.Point(280, 52);
            this.buttonGetRacers.Name = "buttonGetRacers";
            this.buttonGetRacers.Size = new System.Drawing.Size(135, 23);
            this.buttonGetRacers.TabIndex = 3;
            this.buttonGetRacers.Text = "Get Racers";
            this.buttonGetRacers.UseVisualStyleBackColor = true;
            this.buttonGetRacers.Click += new System.EventHandler(this.OnGetRacers);
            // 
            // listViewRacers
            // 
            this.listViewRacers.Location = new System.Drawing.Point(40, 117);
            this.listViewRacers.Name = "listViewRacers";
            this.listViewRacers.Size = new System.Drawing.Size(253, 278);
            this.listViewRacers.TabIndex = 4;
            this.listViewRacers.UseCompatibleStateImageBehavior = false;
            // 
            // Formula1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 428);
            this.Controls.Add(this.listViewRacers);
            this.Controls.Add(this.buttonGetRacers);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.button1);
            this.Name = "Formula1Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonGetRacers;
        private System.Windows.Forms.ListView listViewRacers;
    }
}

