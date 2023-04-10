namespace MDIExample
{
    partial class MainWindow
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolBar1 = new Wisej.Web.ToolBar();
            this.addMdiChild = new Wisej.Web.ToolBarButton();
            this.Separator3 = new Wisej.Web.ToolBarButton();
            this.closeMdiChild = new Wisej.Web.ToolBarButton();
            this.separator4 = new Wisej.Web.ToolBarButton();
            this.activateFirstMdiChild = new Wisej.Web.ToolBarButton();
            this.separator1 = new Wisej.Web.ToolBarButton();
            this.showModeless = new Wisej.Web.ToolBarButton();
            this.separator2 = new Wisej.Web.ToolBarButton();
            this.showHideThumbnails = new Wisej.Web.ToolBarButton();
            this.test1 = new Wisej.Web.ToolBarButton();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colTooltiptext = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPosition = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPushed = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colVisible = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colAutohide = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colEnabled = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colImagesource = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colImage = new Wisej.Web.DataGridViewImageColumn();
            this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.AutoSize = false;
            this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.addMdiChild,
            this.Separator3,
            this.closeMdiChild,
            this.separator4,
            this.activateFirstMdiChild,
            this.separator1,
            this.showModeless,
            this.separator2,
            this.showHideThumbnails,
            this.test1});
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(676, 51);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.TabStop = false;
            this.toolBar1.ButtonClick += new Wisej.Web.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // addMdiChild
            // 
            this.addMdiChild.ImageSource = "window-maximize";
            this.addMdiChild.Name = "addMdiChild";
            this.addMdiChild.Text = "Create MDI";
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // closeMdiChild
            // 
            this.closeMdiChild.ImageSource = "window-minimize";
            this.closeMdiChild.Name = "closeMdiChild";
            this.closeMdiChild.Text = "Close MDI";
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            this.separator4.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // activateFirstMdiChild
            // 
            this.activateFirstMdiChild.ImageSource = "window-icon";
            this.activateFirstMdiChild.Name = "activateFirstMdiChild";
            this.activateFirstMdiChild.Text = "Activate First MDI";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // showModeless
            // 
            this.showModeless.ImageSource = "icon-file";
            this.showModeless.Name = "showModeless";
            this.showModeless.Text = "Show Modeless";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // showHideThumbnails
            // 
            this.showHideThumbnails.ImageSource = "icon-preview";
            this.showHideThumbnails.Name = "showHideThumbnails";
            this.showHideThumbnails.Text = "Hide Thumbnails Buttom";
            // 
            // test1
            // 
            this.test1.ImageSource = "messagebox-hand";
            this.test1.Name = "test1";
            this.test1.Text = "click je";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = Wisej.Web.AccessibleRole.ScrollBar;
            this.dataGridView1.AllowDrag = true;
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colTooltiptext,
            this.colPosition,
            this.colPushed,
            this.colVisible,
            this.colAutohide,
            this.colEnabled,
            this.colImagesource,
            this.colImage,
            this.colName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 331);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // colTooltiptext
            // 
            this.colTooltiptext.DataPropertyName = "ToolTipText";
            this.colTooltiptext.HeaderText = "ToolTipText";
            this.colTooltiptext.Name = "colTooltiptext";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Position";
            this.colPosition.Name = "colPosition";
            // 
            // colPushed
            // 
            this.colPushed.DataPropertyName = "Pushed";
            this.colPushed.HeaderText = "Pushed";
            this.colPushed.Name = "colPushed";
            // 
            // colVisible
            // 
            this.colVisible.DataPropertyName = "Visible";
            this.colVisible.HeaderText = "Visible";
            this.colVisible.Name = "colVisible";
            // 
            // colAutohide
            // 
            this.colAutohide.DataPropertyName = "AutoHide";
            this.colAutohide.HeaderText = "AutoHide";
            this.colAutohide.Name = "colAutohide";
            // 
            // colEnabled
            // 
            this.colEnabled.DataPropertyName = "Enabled";
            this.colEnabled.HeaderText = "Enabled";
            this.colEnabled.Name = "colEnabled";
            // 
            // colImagesource
            // 
            this.colImagesource.DataPropertyName = "ImageSource";
            this.colImagesource.HeaderText = "ImageSource";
            this.colImagesource.Name = "colImagesource";
            // 
            // colImage
            // 
            this.colImage.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.colImage.DataPropertyName = "Image";
            this.colImage.HeaderText = "Image";
            this.colImage.Name = "colImage";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MainWindow";
            this.Text = "Window1";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.ToolBar toolBar1;
        private Wisej.Web.ToolBarButton addMdiChild;
        private Wisej.Web.ToolBarButton closeMdiChild;
        private Wisej.Web.ToolBarButton activateFirstMdiChild;
        private Wisej.Web.ToolBarButton showModeless;
        private Wisej.Web.ToolBarButton separator1;
        private Wisej.Web.ToolBarButton separator2;
        private Wisej.Web.ToolBarButton showHideThumbnails;
        private Wisej.Web.ToolBarButton Separator3;
        private Wisej.Web.ToolBarButton separator4;
        private Wisej.Web.ToolBarButton test1;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colTooltiptext;
        private Wisej.Web.DataGridViewTextBoxColumn colPosition;
        private Wisej.Web.DataGridViewCheckBoxColumn colPushed;
        private Wisej.Web.DataGridViewCheckBoxColumn colVisible;
        private Wisej.Web.DataGridViewCheckBoxColumn colAutohide;
        private Wisej.Web.DataGridViewCheckBoxColumn colEnabled;
        private Wisej.Web.DataGridViewTextBoxColumn colImagesource;
        private Wisej.Web.DataGridViewImageColumn colImage;
        private Wisej.Web.DataGridViewTextBoxColumn colName;
    }
}

