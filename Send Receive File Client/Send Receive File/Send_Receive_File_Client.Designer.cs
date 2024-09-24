namespace Send_Receive_File
{
    partial class Send_Receive_File_Client
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

            BrowseLabel = new Label();
            this.BrowseForm = new System.Windows.Forms.TextBox();
            Browse = new Button();

            ServerLabel = new Label();
            this.ServerForm = new System.Windows.Forms.TextBox();
            Send = new Button();

            SendedLabel = new Label();
            SuspendLayout();
            // 
            // BrowseLabel
            // 
            BrowseLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BrowseLabel.AutoSize = true;
            BrowseLabel.Location = new Point(10, 23);
            BrowseLabel.Name = "File";
            BrowseLabel.Size = new Size(10, 20);
            BrowseLabel.TabIndex = 0;
            BrowseLabel.Text = "File:";
            // 
            // Text Fill
            // 
            this.BrowseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseForm.Location = new System.Drawing.Point(65, 20);
            this.BrowseForm.Name = "File";
            this.BrowseForm.Size = new System.Drawing.Size(230, 20);
            this.BrowseForm.TabIndex = 1;
            // 
            // Browse
            // 
            Browse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Browse.Location = new Point(300, 17);
            Browse.Name = "Browse";
            Browse.Size = new Size(75, 30);
            Browse.TabIndex = 2;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);

            // 
            // ServerLabel
            // 
            ServerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ServerLabel.AutoSize = true;
            ServerLabel.Location = new Point(10, 73);
            ServerLabel.Name = "Server";
            ServerLabel.Size = new Size(10, 20);
            ServerLabel.TabIndex = 3;
            ServerLabel.Text = "Server:";
            // 
            // Server Text Fill
            // 
            this.ServerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerForm.Location = new System.Drawing.Point(65, 70);
            this.ServerForm.Name = "File";
            this.ServerForm.Size = new System.Drawing.Size(230, 20);
            this.ServerForm.TabIndex = 4;
            // 
            // Send Button
            // 
            Send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Send.Location = new Point(300, 67);
            Send.Name = "Send";
            Send.Size = new Size(75, 30);
            Send.TabIndex = 5;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);


            // 
            // SendedLabel
            // 
            SendedLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SendedLabel.AutoSize = true;
            SendedLabel.Location = new Point(10, 70);
            SendedLabel.Name = "Sended";
            SendedLabel.Size = new Size(10, 20);
            SendedLabel.TabIndex = 6;
            SendedLabel.Text = "";

            // 
            // Form1
            // this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 124);
            Name = "TCP Simple Client";
            ResumeLayout(false);
            this.Controls.Add(this.BrowseLabel);
            this.Controls.Add(this.BrowseForm);
            this.Controls.Add(this.Browse);

            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.ServerForm);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendedLabel);
        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox BrowseForm;
        private System.Windows.Forms.Label BrowseLabel;

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox ServerForm;
        private System.Windows.Forms.Label ServerLabel;


        private System.Windows.Forms.Label SendedLabel;


    }
}
