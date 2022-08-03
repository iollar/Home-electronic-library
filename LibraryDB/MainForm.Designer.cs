namespace LibraryDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.txtWay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронизироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnDelete,
            this.btnOpen,
            this.btnReturn,
            this.btnRefresh,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(532, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.toolStrip1.Size = new System.Drawing.Size(176, 410);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Меню";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(155, 54);
            this.btnCreate.Text = "Создать";
            this.btnCreate.ToolTipText = "Ctrl+A";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 54);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.ToolTipText = "Ctrl+D";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Gold;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(155, 54);
            this.btnOpen.Text = "Открыть";
            this.btnOpen.ToolTipText = "Ctrl+O";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Khaki;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 54);
            this.btnReturn.Text = "Вернуться";
            this.btnReturn.ToolTipText = "Ctrl+B";
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 54);
            this.btnRefresh.Text = "Синхронизировать";
            this.btnRefresh.ToolTipText = "Ctrl+R";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 54);
            this.btnClose.Text = "Выйти";
            this.btnClose.ToolTipText = "Ctrl+Z";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(12, 12);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.Size = new System.Drawing.Size(514, 386);
            this.dGV.TabIndex = 1;
            // 
            // txtWay
            // 
            this.txtWay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWay.Enabled = false;
            this.txtWay.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.txtWay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWay.Location = new System.Drawing.Point(12, 12);
            this.txtWay.Name = "txtWay";
            this.txtWay.Size = new System.Drawing.Size(680, 21);
            this.txtWay.TabIndex = 2;
            this.txtWay.Text = "путь: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dGV);
            this.panel1.Location = new System.Drawing.Point(-3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 410);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem,
            this.синхронизироватьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // синхронизироватьToolStripMenuItem
            // 
            this.синхронизироватьToolStripMenuItem.Name = "синхронизироватьToolStripMenuItem";
            this.синхронизироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.синхронизироватьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.синхронизироватьToolStripMenuItem.Text = "Синхронизировать";
            this.синхронизироватьToolStripMenuItem.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(704, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWay);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 498);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Activated += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox txtWay;
        private System.Windows.Forms.ToolStripButton btnReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синхронизироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

