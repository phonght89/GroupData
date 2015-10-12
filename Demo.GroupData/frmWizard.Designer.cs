namespace Demo.GroupData
{
    partial class frmWizard
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.PChoosePath = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureBox1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtPassZip = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.PChooseClient = new DevExpress.XtraWizard.WizardPage();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PChooseMap = new DevExpress.XtraWizard.WizardPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.PFinish = new DevExpress.XtraWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.PChoosePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.PChooseClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.PChooseMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.PChoosePath);
            this.wizardControl1.Controls.Add(this.PChooseClient);
            this.wizardControl1.Controls.Add(this.PChooseMap);
            this.wizardControl1.Controls.Add(this.PFinish);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&Next>";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.PChoosePath,
            this.PChooseClient,
            this.PChooseMap,
            this.PFinish});
            this.wizardControl1.Size = new System.Drawing.Size(1140, 535);
            this.wizardControl1.Text = "KLIB-Import";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            // 
            // PChoosePath
            // 
            this.PChoosePath.Controls.Add(this.pictureBox1);
            this.PChoosePath.Controls.Add(this.txtPassZip);
            this.PChoosePath.Controls.Add(this.labelControl2);
            this.PChoosePath.Controls.Add(this.labelControl1);
            this.PChoosePath.Controls.Add(this.textEdit2);
            this.PChoosePath.Name = "PChoosePath";
            this.PChoosePath.Size = new System.Drawing.Size(1080, 373);
            this.PChoosePath.Text = "Please choose a file to import";
            // 
            // pictureBox1
            // 
            this.pictureBox1.EditValue = global::Demo.GroupData.Properties.Resources.group_add_item;
            this.pictureBox1.Location = new System.Drawing.Point(540, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 5;
            // 
            // txtPassZip
            // 
            this.txtPassZip.Location = new System.Drawing.Point(113, 57);
            this.txtPassZip.Name = "txtPassZip";
            this.txtPassZip.Size = new System.Drawing.Size(421, 20);
            this.txtPassZip.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Folder Path";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(113, 17);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(421, 20);
            this.textEdit2.TabIndex = 0;
            // 
            // PChooseClient
            // 
            this.PChooseClient.Controls.Add(this.checkEdit1);
            this.PChooseClient.Controls.Add(this.comboBoxEdit2);
            this.PChooseClient.Controls.Add(this.labelControl4);
            this.PChooseClient.Controls.Add(this.labelControl3);
            this.PChooseClient.Controls.Add(this.comboBoxEdit1);
            this.PChooseClient.Name = "PChooseClient";
            this.PChooseClient.Size = new System.Drawing.Size(1080, 373);
            this.PChooseClient.Text = "Please choose desired client and case";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(251, 70);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Create a new client";
            this.checkEdit1.Size = new System.Drawing.Size(126, 19);
            this.checkEdit1.TabIndex = 4;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(125, 67);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(16, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Fall";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Klient";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(125, 21);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // PChooseMap
            // 
            this.PChooseMap.Controls.Add(this.xtraScrollableControl1);
            this.PChooseMap.Name = "PChooseMap";
            this.PChooseMap.Size = new System.Drawing.Size(1088, 373);
            this.PChooseMap.Text = "Mapping entities";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.MaximumSize = new System.Drawing.Size(1088, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1088, 373);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // PFinish
            // 
            this.PFinish.Name = "PFinish";
            this.PFinish.Size = new System.Drawing.Size(1080, 373);
            this.PFinish.Text = "Complete maping";
            // 
            // frmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 535);
            this.Controls.Add(this.wizardControl1);
            this.Name = "frmWizard";
            this.Text = "frmWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.PChoosePath.ResumeLayout(false);
            this.PChoosePath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.PChooseClient.ResumeLayout(false);
            this.PChooseClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.PChooseMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage PChoosePath;
        private DevExpress.XtraWizard.WizardPage PChooseClient;
        private DevExpress.XtraWizard.WizardPage PChooseMap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtPassZip;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraWizard.WizardPage PFinish;
        private DevExpress.XtraEditors.PictureEdit pictureBox1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}