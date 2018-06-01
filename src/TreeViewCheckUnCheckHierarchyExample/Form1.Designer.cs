namespace TreeViewCheckUnCheckHierarchyExample
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
            this.exTreeView1 = new TreeViewCheckUnCheckHierarchyExample.ExTreeView();
            this.SuspendLayout();
            // 
            // exTreeView1
            // 
            this.exTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exTreeView1.Location = new System.Drawing.Point(0, 0);
            this.exTreeView1.Name = "exTreeView1";
            this.exTreeView1.Size = new System.Drawing.Size(408, 411);
            this.exTreeView1.TabIndex = 0;
            this.exTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.exTreeView1_AfterCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 411);
            this.Controls.Add(this.exTreeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ExTreeView exTreeView1;
    }
}

