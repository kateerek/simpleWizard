namespace simpleWizard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SimpleWizard = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.SimpleWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.SimpleWizardPage6 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.DataListViewPage6 = new System.Windows.Forms.ListView();
            this.Column1DataListViewPage6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2DataListViewPage6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WarningLabelPage6 = new System.Windows.Forms.Label();
            this.ClearDataButtonPage6 = new System.Windows.Forms.Button();
            this.ShowDataButtonPage6 = new System.Windows.Forms.Button();
            this.SimpleWizardPage5 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.PhoneTextBoxPage5 = new System.Windows.Forms.TextBox();
            this.PhoneLabelPage5 = new System.Windows.Forms.Label();
            this.SimpleWizardPage4 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.AddressTextBoxPage4 = new System.Windows.Forms.TextBox();
            this.AddressLabelPage4 = new System.Windows.Forms.Label();
            this.SimpleWizardPage3 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.SurnameTextBoxPage3 = new System.Windows.Forms.TextBox();
            this.SurnameLabelPage3 = new System.Windows.Forms.Label();
            this.SimpleWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.NameTextBoxPage2 = new System.Windows.Forms.TextBox();
            this.NameLabelPage2 = new System.Windows.Forms.Label();
            this.SimpleWizard.SuspendLayout();
            this.SimpleWizardPage6.SuspendLayout();
            this.SimpleWizardPage5.SuspendLayout();
            this.SimpleWizardPage4.SuspendLayout();
            this.SimpleWizardPage3.SuspendLayout();
            this.SimpleWizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimpleWizard
            // 
            this.SimpleWizard.BackButtonEnabled = true;
            this.SimpleWizard.BackButtonText = "< Back";
            this.SimpleWizard.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Office97;
            this.SimpleWizard.ButtonsVisible = true;
            this.SimpleWizard.CancelButtonText = "&Cancel";
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage6);
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage5);
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage4);
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage3);
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage2);
            this.SimpleWizard.Controls.Add(this.SimpleWizardPage1);
            this.SimpleWizard.CurrentPageIsFinishPage = false;
            this.SimpleWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizard.FinishButton = false;
            this.SimpleWizard.FinishButtonEnabled = true;
            this.SimpleWizard.FinishButtonText = "&Finish";
            this.SimpleWizard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.SimpleWizard.HelpButton = false;
            this.SimpleWizard.HelpButtonText = "&Help";
            this.SimpleWizard.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizard.Name = "SimpleWizard";
            this.SimpleWizard.NextButtonEnabled = true;
            this.SimpleWizard.NextButtonText = "Next >";
            this.SimpleWizard.ProcessKeys = false;
            this.SimpleWizard.Size = new System.Drawing.Size(782, 453);
            this.SimpleWizard.TabIndex = 0;
            this.SimpleWizard.TouchScreen = false;
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage1);
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage2);
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage3);
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage4);
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage5);
            this.SimpleWizard.WizardPages.Add(this.SimpleWizardPage6);
            this.SimpleWizard.Cancel += new System.EventHandler(this.CancelButtonSimpleWizardEvent);
            this.SimpleWizard.Finish += new System.EventHandler(this.FinishButtonSimpleWizardEvent);
            this.SimpleWizard.PageChanged += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageChangedEventArgs>(this.PageChangedSimpleWizardEvent);
            this.SimpleWizard.LastPage += new System.EventHandler(this.LastPageSimpleWizardEvent);
            // 
            // SimpleWizardPage1
            // 
            this.SimpleWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage1.Header = true;
            this.SimpleWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage1.HeaderImage")));
            this.SimpleWizardPage1.HeaderImageVisible = true;
            this.SimpleWizardPage1.HeaderTitle = "Welcome to Simple Wizard that will help you display informations";
            this.SimpleWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage1.Name = "SimpleWizardPage1";
            this.SimpleWizardPage1.PreviousPage = 0;
            this.SimpleWizardPage1.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage1.SubTitle = "";
            this.SimpleWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage1.TabIndex = 1;
            // 
            // SimpleWizardPage6
            // 
            this.SimpleWizardPage6.Controls.Add(this.WarningLabelPage6);
            this.SimpleWizardPage6.Controls.Add(this.DataListViewPage6);
            this.SimpleWizardPage6.Controls.Add(this.ClearDataButtonPage6);
            this.SimpleWizardPage6.Controls.Add(this.ShowDataButtonPage6);
            this.SimpleWizardPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage6.Header = true;
            this.SimpleWizardPage6.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage6.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage6.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage6.HeaderImage")));
            this.SimpleWizardPage6.HeaderImageVisible = true;
            this.SimpleWizardPage6.HeaderTitle = "Step 6: Display informations";
            this.SimpleWizardPage6.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage6.Name = "SimpleWizardPage6";
            this.SimpleWizardPage6.PreviousPage = 4;
            this.SimpleWizardPage6.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage6.SubTitle = "";
            this.SimpleWizardPage6.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage6.TabIndex = 6;
            // 
            // DataListViewPage6
            // 
            this.DataListViewPage6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1DataListViewPage6,
            this.Column2DataListViewPage6});
            this.DataListViewPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataListViewPage6.Location = new System.Drawing.Point(76, 92);
            this.DataListViewPage6.Name = "DataListViewPage6";
            this.DataListViewPage6.Size = new System.Drawing.Size(633, 172);
            this.DataListViewPage6.TabIndex = 5;
            this.DataListViewPage6.TabStop = false;
            this.DataListViewPage6.UseCompatibleStateImageBehavior = false;
            this.DataListViewPage6.View = System.Windows.Forms.View.Details;
            // 
            // Column1DataListViewPage6
            // 
            this.Column1DataListViewPage6.Text = "Field:";
            this.Column1DataListViewPage6.Width = 120;
            // 
            // Column2DataListViewPage6
            // 
            this.Column2DataListViewPage6.Text = "Personal data:";
            this.Column2DataListViewPage6.Width = 250;
            // 
            // WarningLabelPage6
            // 
            this.WarningLabelPage6.BackColor = System.Drawing.SystemColors.Control;
            this.WarningLabelPage6.Enabled = false;
            this.WarningLabelPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningLabelPage6.ForeColor = System.Drawing.Color.Yellow;
            this.WarningLabelPage6.Location = new System.Drawing.Point(440, 338);
            this.WarningLabelPage6.Name = "WarningLabelPage6";
            this.WarningLabelPage6.Size = new System.Drawing.Size(221, 26);
            this.WarningLabelPage6.TabIndex = 4;
            // 
            // ClearDataButtonPage6
            // 
            this.ClearDataButtonPage6.Location = new System.Drawing.Point(160, 279);
            this.ClearDataButtonPage6.Name = "ClearDataButtonPage6";
            this.ClearDataButtonPage6.Size = new System.Drawing.Size(190, 45);
            this.ClearDataButtonPage6.TabIndex = 2;
            this.ClearDataButtonPage6.TabStop = false;
            this.ClearDataButtonPage6.Text = "Clear layout";
            this.ClearDataButtonPage6.UseVisualStyleBackColor = true;
            this.ClearDataButtonPage6.Click += new System.EventHandler(this.ClearDataButtonPage6_Click);
            // 
            // ShowDataButtonPage6
            // 
            this.ShowDataButtonPage6.Location = new System.Drawing.Point(440, 279);
            this.ShowDataButtonPage6.Name = "ShowDataButtonPage6";
            this.ShowDataButtonPage6.Size = new System.Drawing.Size(190, 45);
            this.ShowDataButtonPage6.TabIndex = 1;
            this.ShowDataButtonPage6.TabStop = false;
            this.ShowDataButtonPage6.Text = "Display personal data";
            this.ShowDataButtonPage6.UseVisualStyleBackColor = true;
            this.ShowDataButtonPage6.Click += new System.EventHandler(this.ShowDataButtonPage6_Click);
            // 
            // SimpleWizardPage5
            // 
            this.SimpleWizardPage5.Controls.Add(this.PhoneTextBoxPage5);
            this.SimpleWizardPage5.Controls.Add(this.PhoneLabelPage5);
            this.SimpleWizardPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage5.Header = true;
            this.SimpleWizardPage5.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage5.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage5.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage5.HeaderImage")));
            this.SimpleWizardPage5.HeaderImageVisible = true;
            this.SimpleWizardPage5.HeaderTitle = "Step 4: Phone";
            this.SimpleWizardPage5.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage5.Name = "SimpleWizardPage5";
            this.SimpleWizardPage5.PreviousPage = 3;
            this.SimpleWizardPage5.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage5.SubTitle = "";
            this.SimpleWizardPage5.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage5.TabIndex = 5;
            // 
            // PhoneTextBoxPage5
            // 
            this.PhoneTextBoxPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneTextBoxPage5.Location = new System.Drawing.Point(50, 230);
            this.PhoneTextBoxPage5.Name = "PhoneTextBoxPage5";
            this.PhoneTextBoxPage5.Size = new System.Drawing.Size(400, 34);
            this.PhoneTextBoxPage5.TabIndex = 1;
            this.PhoneTextBoxPage5.TabStop = false;
            // 
            // PhoneLabelPage5
            // 
            this.PhoneLabelPage5.AutoSize = true;
            this.PhoneLabelPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneLabelPage5.Location = new System.Drawing.Point(50, 190);
            this.PhoneLabelPage5.Name = "PhoneLabelPage5";
            this.PhoneLabelPage5.Size = new System.Drawing.Size(385, 36);
            this.PhoneLabelPage5.TabIndex = 0;
            this.PhoneLabelPage5.Text = "Enter your phone number:";
            // 
            // SimpleWizardPage4
            // 
            this.SimpleWizardPage4.Controls.Add(this.AddressTextBoxPage4);
            this.SimpleWizardPage4.Controls.Add(this.AddressLabelPage4);
            this.SimpleWizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage4.Header = true;
            this.SimpleWizardPage4.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage4.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage4.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage4.HeaderImage")));
            this.SimpleWizardPage4.HeaderImageVisible = true;
            this.SimpleWizardPage4.HeaderTitle = "Step 3: Address";
            this.SimpleWizardPage4.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage4.Name = "SimpleWizardPage4";
            this.SimpleWizardPage4.PreviousPage = 2;
            this.SimpleWizardPage4.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage4.SubTitle = "";
            this.SimpleWizardPage4.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage4.TabIndex = 4;
            // 
            // AddressTextBoxPage4
            // 
            this.AddressTextBoxPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressTextBoxPage4.Location = new System.Drawing.Point(50, 230);
            this.AddressTextBoxPage4.Name = "AddressTextBoxPage4";
            this.AddressTextBoxPage4.Size = new System.Drawing.Size(550, 34);
            this.AddressTextBoxPage4.TabIndex = 1;
            this.AddressTextBoxPage4.TabStop = false;
            // 
            // AddressLabelPage4
            // 
            this.AddressLabelPage4.AutoSize = true;
            this.AddressLabelPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressLabelPage4.Location = new System.Drawing.Point(50, 190);
            this.AddressLabelPage4.Name = "AddressLabelPage4";
            this.AddressLabelPage4.Size = new System.Drawing.Size(294, 36);
            this.AddressLabelPage4.TabIndex = 0;
            this.AddressLabelPage4.Text = "Enter your address:";
            // 
            // SimpleWizardPage3
            // 
            this.SimpleWizardPage3.Controls.Add(this.SurnameTextBoxPage3);
            this.SimpleWizardPage3.Controls.Add(this.SurnameLabelPage3);
            this.SimpleWizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage3.Header = true;
            this.SimpleWizardPage3.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage3.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage3.HeaderImage")));
            this.SimpleWizardPage3.HeaderImageVisible = true;
            this.SimpleWizardPage3.HeaderTitle = "Step 2: Surname";
            this.SimpleWizardPage3.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage3.Name = "SimpleWizardPage3";
            this.SimpleWizardPage3.PreviousPage = 1;
            this.SimpleWizardPage3.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage3.SubTitle = "";
            this.SimpleWizardPage3.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage3.TabIndex = 3;
            // 
            // SurnameTextBoxPage3
            // 
            this.SurnameTextBoxPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBoxPage3.Location = new System.Drawing.Point(50, 230);
            this.SurnameTextBoxPage3.Name = "SurnameTextBoxPage3";
            this.SurnameTextBoxPage3.Size = new System.Drawing.Size(350, 34);
            this.SurnameTextBoxPage3.TabIndex = 1;
            this.SurnameTextBoxPage3.TabStop = false;
            // 
            // SurnameLabelPage3
            // 
            this.SurnameLabelPage3.AutoSize = true;
            this.SurnameLabelPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameLabelPage3.Location = new System.Drawing.Point(50, 190);
            this.SurnameLabelPage3.Name = "SurnameLabelPage3";
            this.SurnameLabelPage3.Size = new System.Drawing.Size(302, 36);
            this.SurnameLabelPage3.TabIndex = 0;
            this.SurnameLabelPage3.Text = "Enter your surname:";
            // 
            // SimpleWizardPage2
            // 
            this.SimpleWizardPage2.Controls.Add(this.NameTextBoxPage2);
            this.SimpleWizardPage2.Controls.Add(this.NameLabelPage2);
            this.SimpleWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleWizardPage2.Header = true;
            this.SimpleWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.SimpleWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("SimpleWizardPage2.HeaderImage")));
            this.SimpleWizardPage2.HeaderImageVisible = true;
            this.SimpleWizardPage2.HeaderTitle = "Step 1: Name";
            this.SimpleWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.SimpleWizardPage2.Name = "SimpleWizardPage2";
            this.SimpleWizardPage2.PreviousPage = 0;
            this.SimpleWizardPage2.Size = new System.Drawing.Size(782, 413);
            this.SimpleWizardPage2.SubTitle = "";
            this.SimpleWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.SimpleWizardPage2.TabIndex = 2;
            // 
            // NameTextBoxPage2
            // 
            this.NameTextBoxPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBoxPage2.Location = new System.Drawing.Point(50, 230);
            this.NameTextBoxPage2.Name = "NameTextBoxPage2";
            this.NameTextBoxPage2.Size = new System.Drawing.Size(350, 34);
            this.NameTextBoxPage2.TabIndex = 1;
            this.NameTextBoxPage2.TabStop = false;
            // 
            // NameLabelPage2
            // 
            this.NameLabelPage2.AutoSize = true;
            this.NameLabelPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabelPage2.Location = new System.Drawing.Point(50, 190);
            this.NameLabelPage2.Name = "NameLabelPage2";
            this.NameLabelPage2.Size = new System.Drawing.Size(257, 36);
            this.NameLabelPage2.TabIndex = 0;
            this.NameLabelPage2.Text = "Enter your name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.SimpleWizard);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Wizzard displaying informations about person";
            this.SimpleWizard.ResumeLayout(false);
            this.SimpleWizardPage6.ResumeLayout(false);
            this.SimpleWizardPage5.ResumeLayout(false);
            this.SimpleWizardPage5.PerformLayout();
            this.SimpleWizardPage4.ResumeLayout(false);
            this.SimpleWizardPage4.PerformLayout();
            this.SimpleWizardPage3.ResumeLayout(false);
            this.SimpleWizardPage3.PerformLayout();
            this.SimpleWizardPage2.ResumeLayout(false);
            this.SimpleWizardPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard SimpleWizard;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage2;
        private System.Windows.Forms.TextBox NameTextBoxPage2;
        private System.Windows.Forms.Label NameLabelPage2;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage3;
        private System.Windows.Forms.Label SurnameLabelPage3;
        private System.Windows.Forms.TextBox SurnameTextBoxPage3;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage4;
        private System.Windows.Forms.TextBox AddressTextBoxPage4;
        private System.Windows.Forms.Label AddressLabelPage4;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage5;
        private System.Windows.Forms.TextBox PhoneTextBoxPage5;
        private System.Windows.Forms.Label PhoneLabelPage5;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage SimpleWizardPage6;
        private System.Windows.Forms.Button ShowDataButtonPage6;
        private System.Windows.Forms.Button ClearDataButtonPage6;
        private System.Windows.Forms.Label WarningLabelPage6;
        private System.Windows.Forms.ListView DataListViewPage6;
        private System.Windows.Forms.ColumnHeader Column1DataListViewPage6;
        private System.Windows.Forms.ColumnHeader Column2DataListViewPage6;
    }
}

