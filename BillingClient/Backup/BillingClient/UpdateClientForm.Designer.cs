namespace BillingClient
{
    partial class UpdateClientForm
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
            System.Windows.Forms.Label clientIDLabel;
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientPasNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            clientEmailLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            clientPasNumberLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEditBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientEmailLabel
            // 
            clientEmailLabel.AutoSize = true;
            clientEmailLabel.Location = new System.Drawing.Point(6, 79);
            clientEmailLabel.Name = "clientEmailLabel";
            clientEmailLabel.Size = new System.Drawing.Size(35, 13);
            clientEmailLabel.TabIndex = 1;
            clientEmailLabel.Text = "Email:";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(6, 27);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(32, 13);
            clientNameLabel.TabIndex = 3;
            clientNameLabel.Text = "Имя:";
            // 
            // clientPasNumberLabel
            // 
            clientPasNumberLabel.AutoSize = true;
            clientPasNumberLabel.Location = new System.Drawing.Point(6, 53);
            clientPasNumberLabel.Name = "clientPasNumberLabel";
            clientPasNumberLabel.Size = new System.Drawing.Size(94, 13);
            clientPasNumberLabel.TabIndex = 5;
            clientPasNumberLabel.Text = "Номер паспорта:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(12, 9);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(113, 13);
            clientIDLabel.TabIndex = 6;
            clientIDLabel.Text = "Изменяемый клиент";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BillingLibrary.Client);
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientEmail", true));
            this.clientEmailTextBox.Location = new System.Drawing.Point(116, 76);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(165, 20);
            this.clientEmailTextBox.TabIndex = 2;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(116, 24);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.clientNameTextBox.TabIndex = 4;
            // 
            // clientPasNumberTextBox
            // 
            this.clientPasNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientPasNumber", true));
            this.clientPasNumberTextBox.Location = new System.Drawing.Point(116, 50);
            this.clientPasNumberTextBox.Name = "clientPasNumberTextBox";
            this.clientPasNumberTextBox.Size = new System.Drawing.Size(165, 20);
            this.clientPasNumberTextBox.TabIndex = 6;
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientEditBindingSource;
            this.clientIDComboBox.DisplayMember = "ClientName";
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(131, 6);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(171, 21);
            this.clientIDComboBox.TabIndex = 7;
            this.clientIDComboBox.ValueMember = "ClientID";
            this.clientIDComboBox.SelectedValueChanged += new System.EventHandler(this.clientIDComboBox_SelectedValueChanged);
            // 
            // clientEditBindingSource
            // 
            this.clientEditBindingSource.DataSource = typeof(BillingLibrary.ClientList);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientNameTextBox);
            this.groupBox1.Controls.Add(this.clientEmailTextBox);
            this.groupBox1.Controls.Add(clientEmailLabel);
            this.groupBox1.Controls.Add(clientPasNumberLabel);
            this.groupBox1.Controls.Add(clientNameLabel);
            this.groupBox1.Controls.Add(this.clientPasNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новые данные";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 183);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDComboBox);
            this.Name = "UpdateClientForm";
            this.Text = "UpdateClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEditBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientPasNumberTextBox;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.BindingSource clientEditBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}