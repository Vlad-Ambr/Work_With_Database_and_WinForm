namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            updateListToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            ukranianToolStripMenuItem = new ToolStripMenuItem();
            spanishToolStripMenuItem = new ToolStripMenuItem();
            germanToolStripMenuItem = new ToolStripMenuItem();
            frenchToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, updateListToolStripMenuItem, toolStripMenuItem2 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // updateListToolStripMenuItem
            // 
            updateListToolStripMenuItem.Name = "updateListToolStripMenuItem";
            resources.ApplyResources(updateListToolStripMenuItem, "updateListToolStripMenuItem");
            updateListToolStripMenuItem.Click += updateListToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem2.CheckState = CheckState.Checked;
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, ukranianToolStripMenuItem, spanishToolStripMenuItem, germanToolStripMenuItem, frenchToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // ukranianToolStripMenuItem
            // 
            ukranianToolStripMenuItem.Name = "ukranianToolStripMenuItem";
            resources.ApplyResources(ukranianToolStripMenuItem, "ukranianToolStripMenuItem");
            ukranianToolStripMenuItem.Click += ukranianToolStripMenuItem_Click;
            // 
            // spanishToolStripMenuItem
            // 
            spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            resources.ApplyResources(spanishToolStripMenuItem, "spanishToolStripMenuItem");
            spanishToolStripMenuItem.Click += spanishToolStripMenuItem_Click;
            // 
            // germanToolStripMenuItem
            // 
            germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(germanToolStripMenuItem, "germanToolStripMenuItem");
            germanToolStripMenuItem.Click += germanToolStripMenuItem_Click;
            // 
            // frenchToolStripMenuItem
            // 
            frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(frenchToolStripMenuItem, "frenchToolStripMenuItem");
            frenchToolStripMenuItem.Click += frenchToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem updateListToolStripMenuItem;
        private ToolStripMenuItem ukranianToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem germanToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
    }
}