namespace Server
{
    partial class Server
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
            this.IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxMsgtoClients = new System.Windows.Forms.TextBox();
            this.TextBoxfromClients = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.BroadcastcheckBox = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(147, 33);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(246, 20);
            this.IP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(147, 78);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(246, 20);
            this.Port.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStart.Location = new System.Drawing.Point(487, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 41);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Listening";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnStop.Location = new System.Drawing.Point(634, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 41);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop Listening";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broadcast Message to Clients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message from clients";
            // 
            // TextBoxMsgtoClients
            // 
            this.TextBoxMsgtoClients.Location = new System.Drawing.Point(72, 375);
            this.TextBoxMsgtoClients.Multiline = true;
            this.TextBoxMsgtoClients.Name = "TextBoxMsgtoClients";
            this.TextBoxMsgtoClients.Size = new System.Drawing.Size(321, 63);
            this.TextBoxMsgtoClients.TabIndex = 8;
            // 
            // TextBoxfromClients
            // 
            this.TextBoxfromClients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxfromClients.Location = new System.Drawing.Point(72, 176);
            this.TextBoxfromClients.Multiline = true;
            this.TextBoxfromClients.Name = "TextBoxfromClients";
            this.TextBoxfromClients.Size = new System.Drawing.Size(597, 166);
            this.TextBoxfromClients.TabIndex = 9;
            this.TextBoxfromClients.TextChanged += new System.EventHandler(this.TextBoxfromClients_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(399, 394);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BroadcastcheckBox
            // 
            this.BroadcastcheckBox.AutoSize = true;
            this.BroadcastcheckBox.Location = new System.Drawing.Point(399, 371);
            this.BroadcastcheckBox.Name = "BroadcastcheckBox";
            this.BroadcastcheckBox.Size = new System.Drawing.Size(169, 17);
            this.BroadcastcheckBox.TabIndex = 11;
            this.BroadcastcheckBox.Text = "Broadcast incoming messages";
            this.BroadcastcheckBox.UseVisualStyleBackColor = true;
            this.BroadcastcheckBox.CheckedChanged += new System.EventHandler(this.BroadcastcheckBox_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BroadcastcheckBox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.TextBoxfromClients);
            this.Controls.Add(this.TextBoxMsgtoClients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxMsgtoClients;
        private System.Windows.Forms.TextBox TextBoxfromClients;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox BroadcastcheckBox;
        private System.Windows.Forms.Button btnClose;
    }
}

