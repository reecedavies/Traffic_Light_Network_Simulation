namespace TrafficLightServer
{
    partial class FormServer
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
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxLightIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLightColour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerTickTock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(35, 10);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(176, 31);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to sort of proxy";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(35, 148);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(380, 251);
            this.listBoxOutput.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(231, 17);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 18);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            // 
            // textBoxLightIP
            // 
            this.textBoxLightIP.Location = new System.Drawing.Point(113, 76);
            this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLightIP.Name = "textBoxLightIP";
            this.textBoxLightIP.Size = new System.Drawing.Size(88, 20);
            this.textBoxLightIP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP number of light";
            // 
            // comboBoxLightColour
            // 
            this.comboBoxLightColour.Enabled = false;
            this.comboBoxLightColour.FormattingEnabled = true;
            this.comboBoxLightColour.Items.AddRange(new object[] {
            "Red",
            "Amber",
            "Green",
            "Red & Amber"});
            this.comboBoxLightColour.Location = new System.Drawing.Point(290, 76);
            this.comboBoxLightColour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLightColour.Name = "comboBoxLightColour";
            this.comboBoxLightColour.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLightColour.TabIndex = 5;
            this.comboBoxLightColour.SelectedIndexChanged += new System.EventHandler(this.comboBoxLightColour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set colour";
            // 
            // timerTickTock
            // 
            this.timerTickTock.Tick += new System.EventHandler(this.timerTickTock_Tick);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLightColour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLightIP);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormServer";
            this.Text = "Server (sort of)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLightColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerTickTock;
    }
}

