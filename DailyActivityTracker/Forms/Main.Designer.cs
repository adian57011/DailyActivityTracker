
namespace DailyActivityTracker.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.todoAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoAppToolStripMenuItem,
            this.passwordManagerToolStripMenuItem,
            this.financeManagerToolStripMenuItem,
            this.expenseTrackerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // todoAppToolStripMenuItem
            // 
            this.todoAppToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoAppToolStripMenuItem.Name = "todoAppToolStripMenuItem";
            this.todoAppToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.todoAppToolStripMenuItem.Text = "Todo App";
            // 
            // passwordManagerToolStripMenuItem
            // 
            this.passwordManagerToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordManagerToolStripMenuItem.Name = "passwordManagerToolStripMenuItem";
            this.passwordManagerToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.passwordManagerToolStripMenuItem.Text = "Password Manager";
            // 
            // financeManagerToolStripMenuItem
            // 
            this.financeManagerToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeManagerToolStripMenuItem.Name = "financeManagerToolStripMenuItem";
            this.financeManagerToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.financeManagerToolStripMenuItem.Text = "Finance Manager";
            // 
            // expenseTrackerToolStripMenuItem
            // 
            this.expenseTrackerToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTrackerToolStripMenuItem.Name = "expenseTrackerToolStripMenuItem";
            this.expenseTrackerToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.expenseTrackerToolStripMenuItem.Text = "Expense Tracker";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 428);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EASI:-Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem todoAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}