namespace BillingClient
{
    partial class UpdateSimForm
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
            System.Windows.Forms.Label simIDLabel;
            System.Windows.Forms.Label simClientIDLabel;
            System.Windows.Forms.Label tariffIDLabel;
            this.simBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simIDComboBox = new System.Windows.Forms.ComboBox();
            this.simEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simClientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffIDComboBox = new System.Windows.Forms.ComboBox();
            this.tariffNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            simIDLabel = new System.Windows.Forms.Label();
            simClientIDLabel = new System.Windows.Forms.Label();
            tariffIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffNameBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simIDLabel
            // 
            simIDLabel.AutoSize = true;
            simIDLabel.Location = new System.Drawing.Point(18, 9);
            simIDLabel.Name = "simIDLabel";
            simIDLabel.Size = new System.Drawing.Size(111, 13);
            simIDLabel.TabIndex = 1;
            simIDLabel.Text = "Изменяемая симка:";
            // 
            // simClientIDLabel
            // 
            simClientIDLabel.AutoSize = true;
            simClientIDLabel.Location = new System.Drawing.Point(6, 27);
            simClientIDLabel.Name = "simClientIDLabel";
            simClientIDLabel.Size = new System.Drawing.Size(94, 13);
            simClientIDLabel.TabIndex = 3;
            simClientIDLabel.Text = "Владелец симки:";
            // 
            // tariffIDLabel
            // 
            tariffIDLabel.AutoSize = true;
            tariffIDLabel.Location = new System.Drawing.Point(6, 51);
            tariffIDLabel.Name = "tariffIDLabel";
            tariffIDLabel.Size = new System.Drawing.Size(43, 13);
            tariffIDLabel.TabIndex = 7;
            tariffIDLabel.Text = "Тариф:";
            // 
            // simBindingSource
            // 
            this.simBindingSource.DataSource = typeof(BillingLibrary.Sim);
            // 
            // simIDComboBox
            // 
            this.simIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simBindingSource, "SimID", true));
            this.simIDComboBox.DataSource = this.simEditBindingSource;
            this.simIDComboBox.DisplayMember = "SimCode";
            this.simIDComboBox.FormattingEnabled = true;
            this.simIDComboBox.Location = new System.Drawing.Point(135, 6);
            this.simIDComboBox.Name = "simIDComboBox";
            this.simIDComboBox.Size = new System.Drawing.Size(165, 21);
            this.simIDComboBox.TabIndex = 2;
            this.simIDComboBox.ValueMember = "SimID";
            this.simIDComboBox.SelectedValueChanged += new System.EventHandler(this.simIDComboBox_SelectedValueChanged);
            // 
            // simEditBindingSource
            // 
            this.simEditBindingSource.DataSource = typeof(BillingLibrary.SimList);
            // 
            // simClientIDComboBox
            // 
            this.simClientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simBindingSource, "SimClientID", true));
            this.simClientIDComboBox.DataSource = this.clientNameBindingSource;
            this.simClientIDComboBox.DisplayMember = "ClientName";
            this.simClientIDComboBox.FormattingEnabled = true;
            this.simClientIDComboBox.Location = new System.Drawing.Point(123, 24);
            this.simClientIDComboBox.Name = "simClientIDComboBox";
            this.simClientIDComboBox.Size = new System.Drawing.Size(148, 21);
            this.simClientIDComboBox.TabIndex = 4;
            this.simClientIDComboBox.ValueMember = "ClientID";
            // 
            // clientNameBindingSource
            // 
            this.clientNameBindingSource.DataSource = typeof(BillingLibrary.ClientList);
            // 
            // tariffIDComboBox
            // 
            this.tariffIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simBindingSource, "TariffID", true));
            this.tariffIDComboBox.DataSource = this.tariffNameBindingSource;
            this.tariffIDComboBox.DisplayMember = "TariffName";
            this.tariffIDComboBox.FormattingEnabled = true;
            this.tariffIDComboBox.Location = new System.Drawing.Point(123, 51);
            this.tariffIDComboBox.Name = "tariffIDComboBox";
            this.tariffIDComboBox.Size = new System.Drawing.Size(148, 21);
            this.tariffIDComboBox.TabIndex = 8;
            this.tariffIDComboBox.ValueMember = "TariffID";
            // 
            // tariffNameBindingSource
            // 
            this.tariffNameBindingSource.DataSource = typeof(BillingLibrary.SimList);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(simClientIDLabel);
            this.groupBox1.Controls.Add(tariffIDLabel);
            this.groupBox1.Controls.Add(this.simClientIDComboBox);
            this.groupBox1.Controls.Add(this.tariffIDComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новые данные";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 156);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(simIDLabel);
            this.Controls.Add(this.simIDComboBox);
            this.Name = "UpdateSimForm";
            this.Text = "UpdateSimForm";
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffNameBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource simBindingSource;
        private System.Windows.Forms.ComboBox simIDComboBox;
        private System.Windows.Forms.ComboBox simClientIDComboBox;
        private System.Windows.Forms.ComboBox tariffIDComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource simEditBindingSource;
        private System.Windows.Forms.BindingSource clientNameBindingSource;
        private System.Windows.Forms.BindingSource tariffNameBindingSource;
    }
}