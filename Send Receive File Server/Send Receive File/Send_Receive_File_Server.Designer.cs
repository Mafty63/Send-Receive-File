namespace Send_Receive_File
{
    partial class Send_Receive_File_Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               // clientSocket?.Close();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            lbConnections = new ListBox();
            label1 = new Label();
            IpAddress = new TextBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "My IP address is : ";
            // 
            // lbConnections
            // 
            lbConnections.FormattingEnabled = true;
            lbConnections.Location = new Point(12, 52);
            lbConnections.Name = "lbConnections";
            lbConnections.Size = new Size(362, 344);
            lbConnections.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // IpAddress
            // 
            IpAddress.Location = new Point(141, 23);
            IpAddress.Name = "IpAddress";
            IpAddress.Size = new Size(233, 27);
            IpAddress.TabIndex = 2;
            // 
            // Send_Receive_File_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 424);
            Controls.Add(IpAddress);
            Controls.Add(label1);
            Controls.Add(lbConnections);
            Controls.Add(lblStatus);
            Name = "Send_Receive_File_Server";
            Load += Send_Receive_File_Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private ListBox lbConnections;
        private Label label1;
        private TextBox IpAddress;
    }
}
