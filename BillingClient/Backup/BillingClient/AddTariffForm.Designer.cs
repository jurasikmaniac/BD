namespace BillingClient
{
    partial class AddTariffForm
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
            System.Windows.Forms.Label tariffNameLabel;
            System.Windows.Forms.Label tariffSecCostLabel;
            this.tariffNameTextBox = new System.Windows.Forms.TextBox();
            this.tariffSecCostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tariffNameLabel = new System.Windows.Forms.Label();
            tariffSecCostLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tariffNameLabel
            // 
            tariffNameLabel.AutoSize = true;
            tariffNameLabel.Location = new System.Drawing.Point(21, 22);
            tariffNameLabel.Name = "tariffNameLabel";
            tariffNameLabel.Size = new System.Drawing.Size(65, 13);
            tariffNameLabel.TabIndex = 1;
            tariffNameLabel.Text = "Tariff Name:";
            // 
            // tariffNameTextBox
            // 
            this.tariffNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "TariffName", true));
            this.tariffNameTextBox.Location = new System.Drawing.Point(92, 19);
            this.tariffNameTextBox.Name = "tariffNameTextBox";
            this.tariffNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tariffNameTextBox.TabIndex = 2;
            // 
            // tariffSecCostLabel
            // 
            tariffSecCostLabel.AutoSize = true;
            tariffSecCostLabel.Location = new System.Drawing.Point(6, 48);
            tariffSecCostLabel.Name = "tariffSecCostLabel";
            tariffSecCostLabel.Size = new System.Drawing.Size(80, 13);
            tariffSecCostLabel.TabIndex = 3;
            tariffSecCostLabel.Text = "Tariff Sec Cost:";
            // 
            // tariffSecCostTextBox
            // 
            this.tariffSecCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "TariffSecCost", true));
            this.tariffSecCostTextBox.Location = new System.Drawing.Point(92, 45);
            this.tariffSecCostTextBox.Name = "tariffSecCostTextBox";
            this.tariffSecCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.tariffSecCostTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tariffNameTextBox);
            this.groupBox1.Controls.Add(tariffSecCostLabel);
            this.groupBox1.Controls.Add(tariffNameLabel);
            this.groupBox1.Controls.Add(this.tariffSecCostTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Tariff";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(6, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cansel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(BillingLibrary.Tariff);
            // 
            // AddTariffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 143);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddTariffForm";
            this.Text = "AddTariffForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.TextBox tariffNameTextBox;
        private System.Windows.Forms.TextBox tariffSecCostTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}