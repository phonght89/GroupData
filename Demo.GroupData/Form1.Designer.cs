namespace Demo.GroupData
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupDataControl1 = new Demo.GroupData.Controls.GroupDataControl();
            this.groupDataControl2 = new Demo.GroupData.Controls.GroupDataControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraScrollableControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1380, 727);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupDataControl2);
            this.xtraScrollableControl1.Controls.Add(this.groupDataControl1);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(55, 12);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1313, 703);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // groupDataControl1
            // 
            this.groupDataControl1.BackColor = System.Drawing.SystemColors.Control;
            this.groupDataControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupDataControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDataControl1.Location = new System.Drawing.Point(0, 0);
            this.groupDataControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataControl1.Name = "groupDataControl1";
            this.groupDataControl1.Size = new System.Drawing.Size(1313, 305);
            this.groupDataControl1.TabIndex = 0;
            // 
            // groupDataControl2
            // 
            this.groupDataControl2.BackColor = System.Drawing.SystemColors.Control;
            this.groupDataControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupDataControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDataControl2.Location = new System.Drawing.Point(0, 305);
            this.groupDataControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataControl2.Name = "groupDataControl2";
            this.groupDataControl2.Size = new System.Drawing.Size(1313, 398);
            this.groupDataControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 727);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private Controls.GroupDataControl groupDataControl1;
        private Controls.GroupDataControl groupDataControl2;
    }
}

