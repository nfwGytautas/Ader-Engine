namespace Project_E
{
    partial class MainFrame
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Code");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mapping");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sprite models");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.EngineStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testAMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameLogisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCodeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignacfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectExplorer = new System.Windows.Forms.Panel();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.TreeViewCStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineTabs = new System.Windows.Forms.TabControl();
            this.Loger = new Project_E.UserControls.Logger();
            this.EngineStrip.SuspendLayout();
            this.ProjectExplorer.SuspendLayout();
            this.TreeViewCStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EngineStrip
            // 
            this.EngineStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.EngineStrip.Location = new System.Drawing.Point(0, 0);
            this.EngineStrip.Name = "EngineStrip";
            this.EngineStrip.Size = new System.Drawing.Size(1131, 24);
            this.EngineStrip.TabIndex = 2;
            this.EngineStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.newProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadProjectToolStripMenuItem.Text = "Load project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveProjectToolStripMenuItem.Text = "Save project";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.gameLogisticsToolStripMenuItem,
            this.codingToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMapToolStripMenuItem,
            this.testAMapToolStripMenuItem});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // addNewMapToolStripMenuItem
            // 
            this.addNewMapToolStripMenuItem.Name = "addNewMapToolStripMenuItem";
            this.addNewMapToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewMapToolStripMenuItem.Text = "Open map creator";
            this.addNewMapToolStripMenuItem.Click += new System.EventHandler(this.addNewMapToolStripMenuItem_Click);
            // 
            // testAMapToolStripMenuItem
            // 
            this.testAMapToolStripMenuItem.Name = "testAMapToolStripMenuItem";
            this.testAMapToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.testAMapToolStripMenuItem.Text = "Open map logistic";
            this.testAMapToolStripMenuItem.Click += new System.EventHandler(this.testAMapToolStripMenuItem_Click);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.characterToolStripMenuItem.Text = "Character creator";
            this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
            // 
            // gameLogisticsToolStripMenuItem
            // 
            this.gameLogisticsToolStripMenuItem.Name = "gameLogisticsToolStripMenuItem";
            this.gameLogisticsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gameLogisticsToolStripMenuItem.Text = "Game logistics";
            this.gameLogisticsToolStripMenuItem.Click += new System.EventHandler(this.gameLogisticsToolStripMenuItem_Click);
            // 
            // codingToolStripMenuItem
            // 
            this.codingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablesToolStripMenuItem,
            this.addNewCodeFileToolStripMenuItem,
            this.assignacfToolStripMenuItem});
            this.codingToolStripMenuItem.Name = "codingToolStripMenuItem";
            this.codingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.codingToolStripMenuItem.Text = "Coding";
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.variablesToolStripMenuItem.Text = "Variables";
            this.variablesToolStripMenuItem.Click += new System.EventHandler(this.variablesToolStripMenuItem_Click);
            // 
            // addNewCodeFileToolStripMenuItem
            // 
            this.addNewCodeFileToolStripMenuItem.Name = "addNewCodeFileToolStripMenuItem";
            this.addNewCodeFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewCodeFileToolStripMenuItem.Text = "Add new code file";
            this.addNewCodeFileToolStripMenuItem.Click += new System.EventHandler(this.addNewCodeFileToolStripMenuItem_Click);
            // 
            // assignacfToolStripMenuItem
            // 
            this.assignacfToolStripMenuItem.Name = "assignacfToolStripMenuItem";
            this.assignacfToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.assignacfToolStripMenuItem.Text = "Run an .acf";
            this.assignacfToolStripMenuItem.Click += new System.EventHandler(this.assignacfToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ProjectExplorer
            // 
            this.ProjectExplorer.BackColor = System.Drawing.Color.Gray;
            this.ProjectExplorer.Controls.Add(this.MainTreeView);
            this.ProjectExplorer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProjectExplorer.Location = new System.Drawing.Point(931, 24);
            this.ProjectExplorer.Name = "ProjectExplorer";
            this.ProjectExplorer.Size = new System.Drawing.Size(200, 291);
            this.ProjectExplorer.TabIndex = 3;
            // 
            // MainTreeView
            // 
            this.MainTreeView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainTreeView.ContextMenuStrip = this.TreeViewCStrip;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "CodeRoot";
            treeNode1.Text = "Code";
            treeNode2.Name = "MappingRoot";
            treeNode2.Text = "Mapping";
            treeNode3.Name = "SpriteRoot";
            treeNode3.Text = "Sprite models";
            treeNode4.Name = "ProjectRoot";
            treeNode4.Text = "Project";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.MainTreeView.Size = new System.Drawing.Size(200, 291);
            this.MainTreeView.TabIndex = 6;
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            this.MainTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainTreeView_MouseClick);
            // 
            // TreeViewCStrip
            // 
            this.TreeViewCStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.TreeViewCStrip.Name = "TreeViewCStrip";
            this.TreeViewCStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EngineTabs
            // 
            this.EngineTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EngineTabs.Location = new System.Drawing.Point(0, 24);
            this.EngineTabs.Name = "EngineTabs";
            this.EngineTabs.SelectedIndex = 0;
            this.EngineTabs.Size = new System.Drawing.Size(931, 291);
            this.EngineTabs.TabIndex = 5;
            this.EngineTabs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EngineTabs_MouseDoubleClick);
            // 
            // Loger
            // 
            this.Loger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Loger.Location = new System.Drawing.Point(0, 315);
            this.Loger.Name = "Loger";
            this.Loger.Size = new System.Drawing.Size(1131, 191);
            this.Loger.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 506);
            this.Controls.Add(this.EngineTabs);
            this.Controls.Add(this.ProjectExplorer);
            this.Controls.Add(this.EngineStrip);
            this.Controls.Add(this.Loger);
            this.Name = "MainFrame";
            this.Text = "Ader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.EngineStrip.ResumeLayout(false);
            this.EngineStrip.PerformLayout();
            this.ProjectExplorer.ResumeLayout(false);
            this.TreeViewCStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Logger Loger;
        private System.Windows.Forms.MenuStrip EngineStrip;
        private System.Windows.Forms.Panel ProjectExplorer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl EngineTabs;
        public System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TreeViewCStrip;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testAMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameLogisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCodeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignacfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
    }
}

