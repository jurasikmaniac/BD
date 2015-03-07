namespace BillingClient
{
    partial class AddSimForm
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
            System.Windows.Forms.Label simCodeLabel;
            System.Windows.Forms.Label simPhoneNumberLabel;
            System.Windows.Forms.Label tariffIDLabel;
            System.Windows.Forms.Label simClientIDLabel;
            this.simBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simCodeTextBox = new System.Windows.Forms.TextBox();
            this.simPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.tariffIDComboBox = new System.Windows.Forms.ComboBox();
            this.tariffListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simClientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            simCodeLabel = new System.Windows.Forms.Label();
            simPhoneNumberLabel = new System.Windows.Forms.Label();
            tariffIDLabel = new System.Windows.Forms.Label();
            simClientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientListBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simCodeLabel
            // 
            simCodeLabel.AutoSize = true;
            simCodeLabel.Location = new System.Drawing.Point(56, 75);
            simCodeLabel.Name = "simCodeLabel";
            simCodeLabel.Size = new System.Drawing.Size(55, 13);
            simCodeLabel.TabIndex = 2;
            simCodeLabel.Text = "Sim Code:";
            // 
            // simPhoneNumberLabel
            // 
            simPhoneNumberLabel.AutoSize = true;
            simPhoneNumberLabel.Location = new System.Drawing.Point(10, 49);
            simPhoneNumberLabel.Name = "simPhoneNumberLabel";
            simPhoneNumberLabel.Size = new System.Drawing.Size(101, 13);
            simPhoneNumberLabel.TabIndex = 4;
            simPhoneNumberLabel.Text = "Sim Phone Number:";
            // 
            // tariffIDLabel
            // 
            tariffIDLabel.AutoSize = true;
            tariffIDLabel.Location = new System.Drawing.Point(77, 101);
            tariffIDLabel.Name = "tariffIDLabel";
            tariffIDLabel.Size = new System.Drawing.Size(34, 13);
            tariffIDLabel.TabIndex = 8;
            tariffIDLabel.Text = "Tariff:";
            // 
            // simClientIDLabel
            // 
            simClientIDLabel.AutoSize = true;
            simClientIDLabel.Location = new System.Drawing.Point(44, 22);
            simClientIDLabel.Name = "simClientIDLabel";
            simClientIDLabel.Size = new System.Drawing.Size(67, 13);
            simClientIDLabel.TabIndex = 9;
            simClientIDLabel.Text = "Client Name:";
            // 
            // simBindingSource
            // 
            this.simBindingSource.DataSource = typeof(BillingLibrary.Sim);
            // 
            // simCodeTextBox
            // 
            this.simCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simBindingSource, "SimCode", true));
            this.simCodeTextBox.Location = new System.Drawing.Point(117, 72);
            this.simCodeTextBox.Name = "simCodeTextBox";
            this.simCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.simCodeTextBox.TabIndex = 3;
            // 
            // simPhoneNumberTextBox
            // 
            this.simPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simBindingSource, "SimPhoneNumber", true));
            this.simPhoneNumberTextBox.Location = new System.Drawing.Point(117, 46);
            this.simPhoneNumberTextBox.Name = "simPhoneNumberTextBox";
            this.simPhoneNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.simPhoneNumberTextBox.TabIndex = 5;
            // 
            // tariffIDComboBox
            // 
            this.tariffIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simBindingSource, "TariffID", true));
            this.tariffIDComboBox.DataSource = this.tariffListBindingSource;
            this.tariffIDComboBox.DisplayMember = "TariffName";
            this.tariffIDComboBox.FormattingEnabled = true;
            this.tariffIDComboBox.Location = new System.Drawing.Point(117, 98);
            this.tariffIDComboBox.Name = "tariffIDComboBox";
            this.tariffIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.tariffIDComboBox.TabIndex = 9;
            this.tariffIDComboBox.ValueMember = "TariffID";
            // 
            // tariffListBindingSource
            // 
            this.tariffListBindingSource.DataSource = typeof(BillingLibrary.TariffList);
            // 
            // simClientIDComboBox
            // 
            this.simClientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.simBindingSource, "SimClientID", true));
            this.simClientIDComboBox.DataSource = this.clientListBindingSource;
            this.simClientIDComboBox.DisplayMember = "ClientName";
            this.simClientIDComboBox.FormattingEnabled = true;
            this.simClientIDComboBox.Location = new System.Drawing.Point(117, 19);
            this.simClientIDComboBox.Name = "simClientIDComboBox";
            this.simClientIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.simClientIDComboBox.TabIndex = 10;
            this.simClientIDComboBox.ValueMember = "ClientID";
            // 
            // clientListBindingSource
            // 
            this.clientListBindingSource.DataSource = typeof(BillingLibrary.ClientList);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(10, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.simCodeTextBox);
            this.groupBox1.Controls.Add(simCodeLabel);
            this.groupBox1.Controls.Add(simClientIDLabel);
            this.groupBox1.Controls.Add(this.simPhoneNumberTextBox);
            this.groupBox1.Controls.Add(this.simClientIDComboBox);
            this.groupBox1.Controls.Add(simPhoneNumberLabel);
            this.groupBox1.Controls.Add(tariffIDLabel);
            this.groupBox1.Controls.Add(this.tariffIDComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 172);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Sim";
            // 
            // AddSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 196);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSimForm";
            this.Text = "AddSimForm";
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientListBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource simBindingSource;
        private System.Windows.Forms.TextBox simCodeTextBox;
        private System.Windows.Forms.TextBox simPhoneNumberTextBox;
        private System.Windows.Forms.ComboBox tariffIDComboBox;
        private System.Windows.Forms.ComboBox simClientIDComboBox;
        private System.Windows.Forms.BindingSource clientListBindingSource;
        private System.Windows.Forms.BindingSource tariffListBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}