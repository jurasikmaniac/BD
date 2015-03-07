namespace BillingClient
{
    partial class AddClientForm
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
            System.Windows.Forms.Label clientEmailLabel;
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label clientPasNumberLabel;
            this.clientListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientPasNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            clientEmailLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            clientPasNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientEmailLabel
            // 
            clientEmailLabel.AutoSize = true;
            clientEmailLabel.Location = new System.Drawing.Point(8, 41);
            clientEmailLabel.Name = "clientEmailLabel";
            clientEmailLabel.Size = new System.Drawing.Size(64, 13);
            clientEmailLabel.TabIndex = 1;
            clientEmailLabel.Text = "Client Email:";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(8, 15);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(67, 13);
            clientNameLabel.TabIndex = 3;
            clientNameLabel.Text = "Client Name:";
            // 
            // clientPasNumberLabel
            // 
            clientPasNumberLabel.AutoSize = true;
            clientPasNumberLabel.Location = new System.Drawing.Point(8, 67);
            clientPasNumberLabel.Name = "clientPasNumberLabel";
            clientPasNumberLabel.Size = new System.Drawing.Size(97, 13);
            clientPasNumberLabel.TabIndex = 5;
            clientPasNumberLabel.Text = "Client Pas Number:";
            // 
            // clientListBindingSource
            // 
            this.clientListBindingSource.DataSource = typeof(BillingLibrary.Client);
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListBindingSource, "ClientEmail", true));
            this.clientEmailTextBox.Location = new System.Drawing.Point(111, 38);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientEmailTextBox.TabIndex = 2;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListBindingSource, "ClientName", true));
            this.clientNameTextBox.Location = new System.Drawing.Point(111, 12);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 4;
            // 
            // clientPasNumberTextBox
            // 
            this.clientPasNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListBindingSource, "ClientPasNumber", true));
            this.clientPasNumberTextBox.Location = new System.Drawing.Point(111, 64);
            this.clientPasNumberTextBox.Name = "clientPasNumberTextBox";
            this.clientPasNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPasNumberTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 120);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(clientPasNumberLabel);
            this.Controls.Add(this.clientPasNumberTextBox);
            this.Controls.Add(clientNameLabel);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(clientEmailLabel);
            this.Controls.Add(this.clientEmailTextBox);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientListBindingSource;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientPasNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}