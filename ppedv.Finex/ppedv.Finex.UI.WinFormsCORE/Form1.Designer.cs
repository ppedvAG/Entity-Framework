using MetroFramework.Controls;
using System.Windows.Forms;

namespace ppedv.Finex.UI.WinForms
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.medikamentenView1 = new ppedv.Finex.UI.WinForms.MedikamentenView();
            this.apothekenView1 = new ppedv.Finex.UI.WinForms.ApothekenView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(804, 347);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.medikamentenView1);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 5;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(796, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medikamente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.apothekenView1);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 5;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(796, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Apotheken";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // medikamentenView1
            // 
            this.medikamentenView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medikamentenView1.Location = new System.Drawing.Point(3, 4);
            this.medikamentenView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medikamentenView1.Name = "medikamentenView1";
            this.medikamentenView1.Size = new System.Drawing.Size(790, 297);
            this.medikamentenView1.TabIndex = 0;
            this.medikamentenView1.UseSelectable = true;
            // 
            // apothekenView1
            // 
            this.apothekenView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apothekenView1.Location = new System.Drawing.Point(3, 4);
            this.apothekenView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apothekenView1.Name = "apothekenView1";
            this.apothekenView1.Size = new System.Drawing.Size(790, 297);
            this.apothekenView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 427);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Finex v1.0 Metro Edition";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MedikamentenView medikamentenView1;
        private ApothekenView apothekenView1;
        private MetroTabControl tabControl1;
        private MetroTabPage tabPage1;
        private MetroTabPage tabPage2;
    }
}

