namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.завершитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПриоритетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реальногоВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.высокийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьВысокийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьНизкийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.низкийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПроцессеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProcess,
            this.Priority,
            this.Id,
            this.Memory});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MinimumSize = new System.Drawing.Size(387, 221);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 266);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NameProcess
            // 
            this.NameProcess.Text = "Имя процесса";
            this.NameProcess.Width = 150;
            // 
            // Priority
            // 
            this.Priority.Text = "Приоритет";
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Memory
            // 
            this.Memory.Text = "Память";
            this.Memory.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьПроцессToolStripMenuItem,
            this.изменитьПриоритетToolStripMenuItem,
            this.информацияОПроцессеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 70);
            // 
            // завершитьПроцессToolStripMenuItem
            // 
            this.завершитьПроцессToolStripMenuItem.Name = "завершитьПроцессToolStripMenuItem";
            this.завершитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.завершитьПроцессToolStripMenuItem.Text = "Завершить процесс";
            this.завершитьПроцессToolStripMenuItem.Click += new System.EventHandler(this.завершитьПроцессToolStripMenuItem_Click);
            // 
            // изменитьПриоритетToolStripMenuItem
            // 
            this.изменитьПриоритетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реальногоВремениToolStripMenuItem,
            this.высокийToolStripMenuItem,
            this.оченьВысокийToolStripMenuItem,
            this.обычныйToolStripMenuItem,
            this.оченьНизкийToolStripMenuItem,
            this.низкийToolStripMenuItem});
            this.изменитьПриоритетToolStripMenuItem.Name = "изменитьПриоритетToolStripMenuItem";
            this.изменитьПриоритетToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.изменитьПриоритетToolStripMenuItem.Text = "Изменить приоритет";
            // 
            // реальногоВремениToolStripMenuItem
            // 
            this.реальногоВремениToolStripMenuItem.Name = "реальногоВремениToolStripMenuItem";
            this.реальногоВремениToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.реальногоВремениToolStripMenuItem.Text = "Реального времени";
            this.реальногоВремениToolStripMenuItem.Click += new System.EventHandler(this.реальногоВремениToolStripMenuItem_Click);
            // 
            // высокийToolStripMenuItem
            // 
            this.высокийToolStripMenuItem.Name = "высокийToolStripMenuItem";
            this.высокийToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.высокийToolStripMenuItem.Text = "Высокий";
            this.высокийToolStripMenuItem.Click += new System.EventHandler(this.высокийToolStripMenuItem_Click);
            // 
            // оченьВысокийToolStripMenuItem
            // 
            this.оченьВысокийToolStripMenuItem.Name = "оченьВысокийToolStripMenuItem";
            this.оченьВысокийToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.оченьВысокийToolStripMenuItem.Text = "Выше среднего";
            this.оченьВысокийToolStripMenuItem.Click += new System.EventHandler(this.оченьВысокийToolStripMenuItem_Click);
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // оченьНизкийToolStripMenuItem
            // 
            this.оченьНизкийToolStripMenuItem.Name = "оченьНизкийToolStripMenuItem";
            this.оченьНизкийToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.оченьНизкийToolStripMenuItem.Text = "Ниже среднего";
            this.оченьНизкийToolStripMenuItem.Click += new System.EventHandler(this.оченьНизкийToolStripMenuItem_Click);
            // 
            // низкийToolStripMenuItem
            // 
            this.низкийToolStripMenuItem.Name = "низкийToolStripMenuItem";
            this.низкийToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.низкийToolStripMenuItem.Text = "Низкий";
            this.низкийToolStripMenuItem.Click += new System.EventHandler(this.низкийToolStripMenuItem_Click);
            // 
            // информацияОПроцессеToolStripMenuItem
            // 
            this.информацияОПроцессеToolStripMenuItem.Name = "информацияОПроцессеToolStripMenuItem";
            this.информацияОПроцессеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.информацияОПроцессеToolStripMenuItem.Text = "Информация о процессе";
            this.информацияОПроцессеToolStripMenuItem.Click += new System.EventHandler(this.информацияОПроцессеToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 269);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem1.Text = "Создать процесс";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem2.Text = "Обновить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 327);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(427, 366);
            this.Name = "Form1";
            this.Text = "Лаб №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameProcess;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПриоритетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реальногоВремениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem высокийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьВысокийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьНизкийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem низкийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПроцессеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

