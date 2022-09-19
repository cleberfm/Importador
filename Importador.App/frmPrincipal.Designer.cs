namespace Importador.App
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Números = new System.Windows.Forms.ColumnHeader();
            this.lstPrincipal = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lstPrincipal
            // 
            this.lstPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lstPrincipal.Name = "lstPrincipal";
            this.lstPrincipal.Size = new System.Drawing.Size(818, 306);
            this.lstPrincipal.TabIndex = 0;
            this.lstPrincipal.UseCompatibleStateImageBehavior = false;
            this.lstPrincipal.View = System.Windows.Forms.View.Details;
            this.lstPrincipal.DoubleClick += new System.EventHandler(this.lstPrincipal_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Números";
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(818, 306);
            this.Controls.Add(this.lstPrincipal);
            this.Name = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private ColumnHeader Números;
        private ListView lstPrincipal;
        private ColumnHeader columnHeader1;
    }
}