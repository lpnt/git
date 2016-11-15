namespace Lpnt.CoBan.Common
{
    partial class FrmBaseDialog
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
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawBorder = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            // 
            // FrmBaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Name = "FrmBaseDialog";
            this.Text = "FrmBaseDialog";
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}