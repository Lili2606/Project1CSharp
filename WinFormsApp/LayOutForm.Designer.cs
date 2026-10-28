namespace WinFormsApp
{
    partial class LayOutForm
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
            menuStrip1 = new MenuStrip();
            دانشجوToolStripMenuItem = new ToolStripMenuItem();
            لیستدروسToolStripMenuItem = new ToolStripMenuItem();
            ترمهاToolStripMenuItem = new ToolStripMenuItem();
            لیستترمهاToolStripMenuItem = new ToolStripMenuItem();
            نمراتترمهاToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهدانشجوToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { دانشجوToolStripMenuItem, ترمهاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // دانشجوToolStripMenuItem
            // 
            دانشجوToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { لیستدروسToolStripMenuItem, مشاهدهدانشجوToolStripMenuItem });
            دانشجوToolStripMenuItem.Name = "دانشجوToolStripMenuItem";
            دانشجوToolStripMenuItem.Size = new Size(90, 24);
            دانشجوToolStripMenuItem.Text = "دانشجویان";
            دانشجوToolStripMenuItem.Click += دانشجوToolStripMenuItem_Click;
            // 
            // لیستدروسToolStripMenuItem
            // 
            لیستدروسToolStripMenuItem.Name = "لیستدروسToolStripMenuItem";
            لیستدروسToolStripMenuItem.Size = new Size(224, 26);
            لیستدروسToolStripMenuItem.Text = "ثبت نام دانشجو";
            // 
            // ترمهاToolStripMenuItem
            // 
            ترمهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { لیستترمهاToolStripMenuItem, نمراتترمهاToolStripMenuItem });
            ترمهاToolStripMenuItem.Name = "ترمهاToolStripMenuItem";
            ترمهاToolStripMenuItem.Size = new Size(60, 24);
            ترمهاToolStripMenuItem.Text = "ترم ها";
            // 
            // لیستترمهاToolStripMenuItem
            // 
            لیستترمهاToolStripMenuItem.Name = "لیستترمهاToolStripMenuItem";
            لیستترمهاToolStripMenuItem.Size = new Size(224, 26);
            لیستترمهاToolStripMenuItem.Text = "ایجاد ترم";
            // 
            // نمراتترمهاToolStripMenuItem
            // 
            نمراتترمهاToolStripMenuItem.Name = "نمراتترمهاToolStripMenuItem";
            نمراتترمهاToolStripMenuItem.Size = new Size(224, 26);
            نمراتترمهاToolStripMenuItem.Text = "مشاهده ترم";
            // 
            // مشاهدهدانشجوToolStripMenuItem
            // 
            مشاهدهدانشجوToolStripMenuItem.Name = "مشاهدهدانشجوToolStripMenuItem";
            مشاهدهدانشجوToolStripMenuItem.Size = new Size(224, 26);
            مشاهدهدانشجوToolStripMenuItem.Text = "مشاهده دانشجویان";
            // 
            // LayOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LayOutForm";
            Text = "LayOutForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem دانشجوToolStripMenuItem;
        private ToolStripMenuItem لیستدروسToolStripMenuItem;
        private ToolStripMenuItem ترمهاToolStripMenuItem;
        private ToolStripMenuItem لیستترمهاToolStripMenuItem;
        private ToolStripMenuItem نمراتترمهاToolStripMenuItem;
        private ToolStripMenuItem مشاهدهدانشجوToolStripMenuItem;
    }
}