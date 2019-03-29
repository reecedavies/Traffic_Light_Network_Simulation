namespace TrafficLight
{
    partial class FormTrafficLight
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLightIP = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelAmber = new System.Windows.Forms.Label();
            this.buttonCarArrived = new System.Windows.Forms.Button();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.labelSouthAmber = new System.Windows.Forms.Label();
            this.labelSouthGreen = new System.Windows.Forms.Label();
            this.labelSouthRed = new System.Windows.Forms.Label();
            this.labelWestAmber = new System.Windows.Forms.Label();
            this.labelWestGreen = new System.Windows.Forms.Label();
            this.labelWestRed = new System.Windows.Forms.Label();
            this.labelEastAmber = new System.Windows.Forms.Label();
            this.labelEastGreen = new System.Windows.Forms.Label();
            this.labelEastRed = new System.Windows.Forms.Label();
            this.labelWestCarNumber = new System.Windows.Forms.Label();
            this.labelSouthCarNumber = new System.Windows.Forms.Label();
            this.labelEastCarNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP number of server";
            // 
            // textBoxLightIP
            // 
            this.textBoxLightIP.Location = new System.Drawing.Point(133, 92);
            this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLightIP.Name = "textBoxLightIP";
            this.textBoxLightIP.Size = new System.Drawing.Size(88, 20);
            this.textBoxLightIP.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(239, 32);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 18);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(34, 238);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(315, 225);
            this.listBoxOutput.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(44, 25);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(176, 31);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect to sort of proxy";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.Location = new System.Drawing.Point(489, 102);
            this.labelRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(39, 37);
            this.labelRed.TabIndex = 12;
            this.labelRed.Text = "R";
            this.labelRed.Visible = false;
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.BackColor = System.Drawing.Color.Lime;
            this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.Location = new System.Drawing.Point(489, 192);
            this.labelGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(42, 37);
            this.labelGreen.TabIndex = 13;
            this.labelGreen.Text = "G";
            this.labelGreen.Visible = false;
            // 
            // labelAmber
            // 
            this.labelAmber.AutoSize = true;
            this.labelAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmber.Location = new System.Drawing.Point(489, 147);
            this.labelAmber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmber.Name = "labelAmber";
            this.labelAmber.Size = new System.Drawing.Size(39, 37);
            this.labelAmber.TabIndex = 14;
            this.labelAmber.Text = "A";
            this.labelAmber.Visible = false;
            // 
            // buttonCarArrived
            // 
            this.buttonCarArrived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCarArrived.Enabled = false;
            this.buttonCarArrived.Location = new System.Drawing.Point(443, 56);
            this.buttonCarArrived.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCarArrived.Name = "buttonCarArrived";
            this.buttonCarArrived.Size = new System.Drawing.Size(120, 19);
            this.buttonCarArrived.TabIndex = 15;
            this.buttonCarArrived.Text = "Car Arrived at north";
            this.buttonCarArrived.UseVisualStyleBackColor = true;
            this.buttonCarArrived.Click += new System.EventHandler(this.buttonCarArrived_Click);
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Location = new System.Drawing.Point(439, 77);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(130, 13);
            this.labelCarNumber.TabIndex = 16;
            this.labelCarNumber.Text = "Number of cars at north: 0";
            // 
            // labelSouthAmber
            // 
            this.labelSouthAmber.AutoSize = true;
            this.labelSouthAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSouthAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouthAmber.Location = new System.Drawing.Point(489, 390);
            this.labelSouthAmber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSouthAmber.Name = "labelSouthAmber";
            this.labelSouthAmber.Size = new System.Drawing.Size(39, 37);
            this.labelSouthAmber.TabIndex = 19;
            this.labelSouthAmber.Text = "A";
            this.labelSouthAmber.Visible = false;
            // 
            // labelSouthGreen
            // 
            this.labelSouthGreen.AutoSize = true;
            this.labelSouthGreen.BackColor = System.Drawing.Color.Lime;
            this.labelSouthGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouthGreen.Location = new System.Drawing.Point(489, 435);
            this.labelSouthGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSouthGreen.Name = "labelSouthGreen";
            this.labelSouthGreen.Size = new System.Drawing.Size(42, 37);
            this.labelSouthGreen.TabIndex = 18;
            this.labelSouthGreen.Text = "G";
            this.labelSouthGreen.Visible = false;
            // 
            // labelSouthRed
            // 
            this.labelSouthRed.AutoSize = true;
            this.labelSouthRed.BackColor = System.Drawing.Color.Red;
            this.labelSouthRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouthRed.Location = new System.Drawing.Point(489, 345);
            this.labelSouthRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSouthRed.Name = "labelSouthRed";
            this.labelSouthRed.Size = new System.Drawing.Size(39, 37);
            this.labelSouthRed.TabIndex = 17;
            this.labelSouthRed.Text = "R";
            this.labelSouthRed.Visible = false;
            // 
            // labelWestAmber
            // 
            this.labelWestAmber.AutoSize = true;
            this.labelWestAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWestAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWestAmber.Location = new System.Drawing.Point(398, 266);
            this.labelWestAmber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWestAmber.Name = "labelWestAmber";
            this.labelWestAmber.Size = new System.Drawing.Size(39, 37);
            this.labelWestAmber.TabIndex = 22;
            this.labelWestAmber.Text = "A";
            this.labelWestAmber.Visible = false;
            // 
            // labelWestGreen
            // 
            this.labelWestGreen.AutoSize = true;
            this.labelWestGreen.BackColor = System.Drawing.Color.Lime;
            this.labelWestGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWestGreen.Location = new System.Drawing.Point(398, 311);
            this.labelWestGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWestGreen.Name = "labelWestGreen";
            this.labelWestGreen.Size = new System.Drawing.Size(42, 37);
            this.labelWestGreen.TabIndex = 21;
            this.labelWestGreen.Text = "G";
            this.labelWestGreen.Visible = false;
            // 
            // labelWestRed
            // 
            this.labelWestRed.AutoSize = true;
            this.labelWestRed.BackColor = System.Drawing.Color.Red;
            this.labelWestRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWestRed.Location = new System.Drawing.Point(398, 221);
            this.labelWestRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWestRed.Name = "labelWestRed";
            this.labelWestRed.Size = new System.Drawing.Size(39, 37);
            this.labelWestRed.TabIndex = 20;
            this.labelWestRed.Text = "R";
            this.labelWestRed.Visible = false;
            // 
            // labelEastAmber
            // 
            this.labelEastAmber.AutoSize = true;
            this.labelEastAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelEastAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEastAmber.Location = new System.Drawing.Point(583, 265);
            this.labelEastAmber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEastAmber.Name = "labelEastAmber";
            this.labelEastAmber.Size = new System.Drawing.Size(39, 37);
            this.labelEastAmber.TabIndex = 25;
            this.labelEastAmber.Text = "A";
            this.labelEastAmber.Visible = false;
            // 
            // labelEastGreen
            // 
            this.labelEastGreen.AutoSize = true;
            this.labelEastGreen.BackColor = System.Drawing.Color.Lime;
            this.labelEastGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEastGreen.Location = new System.Drawing.Point(583, 310);
            this.labelEastGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEastGreen.Name = "labelEastGreen";
            this.labelEastGreen.Size = new System.Drawing.Size(42, 37);
            this.labelEastGreen.TabIndex = 24;
            this.labelEastGreen.Text = "G";
            this.labelEastGreen.Visible = false;
            // 
            // labelEastRed
            // 
            this.labelEastRed.AutoSize = true;
            this.labelEastRed.BackColor = System.Drawing.Color.Red;
            this.labelEastRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEastRed.Location = new System.Drawing.Point(583, 220);
            this.labelEastRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEastRed.Name = "labelEastRed";
            this.labelEastRed.Size = new System.Drawing.Size(39, 37);
            this.labelEastRed.TabIndex = 23;
            this.labelEastRed.Text = "R";
            this.labelEastRed.Visible = false;
            // 
            // labelWestCarNumber
            // 
            this.labelWestCarNumber.AutoSize = true;
            this.labelWestCarNumber.Location = new System.Drawing.Point(354, 192);
            this.labelWestCarNumber.Name = "labelWestCarNumber";
            this.labelWestCarNumber.Size = new System.Drawing.Size(128, 13);
            this.labelWestCarNumber.TabIndex = 26;
            this.labelWestCarNumber.Text = "Number of cars at west: 0";
            // 
            // labelSouthCarNumber
            // 
            this.labelSouthCarNumber.AutoSize = true;
            this.labelSouthCarNumber.Location = new System.Drawing.Point(446, 323);
            this.labelSouthCarNumber.Name = "labelSouthCarNumber";
            this.labelSouthCarNumber.Size = new System.Drawing.Size(132, 13);
            this.labelSouthCarNumber.TabIndex = 27;
            this.labelSouthCarNumber.Text = "Number of cars at south: 0";
            // 
            // labelEastCarNumber
            // 
            this.labelEastCarNumber.AutoSize = true;
            this.labelEastCarNumber.Location = new System.Drawing.Point(545, 192);
            this.labelEastCarNumber.Name = "labelEastCarNumber";
            this.labelEastCarNumber.Size = new System.Drawing.Size(126, 13);
            this.labelEastCarNumber.TabIndex = 28;
            this.labelEastCarNumber.Text = "Number of cars at east: 0";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(548, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 19);
            this.button1.TabIndex = 29;
            this.button1.Text = "Car Arrived at east";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEastCarNumber);
            this.Controls.Add(this.labelSouthCarNumber);
            this.Controls.Add(this.labelWestCarNumber);
            this.Controls.Add(this.labelEastAmber);
            this.Controls.Add(this.labelEastGreen);
            this.Controls.Add(this.labelEastRed);
            this.Controls.Add(this.labelWestAmber);
            this.Controls.Add(this.labelWestGreen);
            this.Controls.Add(this.labelWestRed);
            this.Controls.Add(this.labelSouthAmber);
            this.Controls.Add(this.labelSouthGreen);
            this.Controls.Add(this.labelSouthRed);
            this.Controls.Add(this.labelCarNumber);
            this.Controls.Add(this.buttonCarArrived);
            this.Controls.Add(this.labelAmber);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLightIP);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTrafficLight";
            this.Text = "top right traffic lights";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrafficLight_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelAmber;
        private System.Windows.Forms.Button buttonCarArrived;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.Label labelSouthAmber;
        private System.Windows.Forms.Label labelSouthGreen;
        private System.Windows.Forms.Label labelSouthRed;
        private System.Windows.Forms.Label labelWestAmber;
        private System.Windows.Forms.Label labelWestGreen;
        private System.Windows.Forms.Label labelWestRed;
        private System.Windows.Forms.Label labelEastAmber;
        private System.Windows.Forms.Label labelEastGreen;
        private System.Windows.Forms.Label labelEastRed;
        private System.Windows.Forms.Label labelWestCarNumber;
        private System.Windows.Forms.Label labelSouthCarNumber;
        private System.Windows.Forms.Label labelEastCarNumber;
        private System.Windows.Forms.Button button1;
    }
}

