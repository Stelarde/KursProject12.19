namespace KursMuseum.View
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
            this.dgvMainTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtBalanceTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountTickets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExcItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeExcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMainTable
            // 
            this.dgvMainTable.AutoGenerateColumns = false;
            this.dgvMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.typeExcDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeFinishDataGridViewTextBoxColumn,
            this.typeTicketDataGridViewTextBoxColumn,
            this.priceTicketDataGridViewTextBoxColumn});
            this.dgvMainTable.DataSource = this.ExcItemBindingSource;
            this.dgvMainTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMainTable.Location = new System.Drawing.Point(0, 24);
            this.dgvMainTable.Name = "dgvMainTable";
            this.dgvMainTable.Size = new System.Drawing.Size(618, 426);
            this.dgvMainTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.txtBalanceTickets);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCountTickets);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(621, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 426);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Вырученные средства";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(3, 261);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(172, 20);
            this.txtSum.TabIndex = 11;
            // 
            // txtBalanceTickets
            // 
            this.txtBalanceTickets.Location = new System.Drawing.Point(3, 222);
            this.txtBalanceTickets.Name = "txtBalanceTickets";
            this.txtBalanceTickets.Size = new System.Drawing.Size(172, 20);
            this.txtBalanceTickets.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Оставшиеся билеты";
            // 
            // txtCountTickets
            // 
            this.txtCountTickets.Location = new System.Drawing.Point(3, 183);
            this.txtCountTickets.Name = "txtCountTickets";
            this.txtCountTickets.Size = new System.Drawing.Size(172, 20);
            this.txtCountTickets.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество билетов";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Информация по билету";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Отчет о проданных билетов";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Расписание экскурсий";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Продать билет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExcItemBindingSource
            // 
            this.ExcItemBindingSource.DataSource = typeof(KursMuseum.Model.ExcurceItem);
            // 
            // typeExcDataGridViewTextBoxColumn
            // 
            this.typeExcDataGridViewTextBoxColumn.DataPropertyName = "TypeExc";
            this.typeExcDataGridViewTextBoxColumn.HeaderText = "TypeExc";
            this.typeExcDataGridViewTextBoxColumn.Name = "typeExcDataGridViewTextBoxColumn";
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "TimeStart";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "TimeStart";
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            // 
            // timeFinishDataGridViewTextBoxColumn
            // 
            this.timeFinishDataGridViewTextBoxColumn.DataPropertyName = "TimeFinish";
            this.timeFinishDataGridViewTextBoxColumn.HeaderText = "TimeFinish";
            this.timeFinishDataGridViewTextBoxColumn.Name = "timeFinishDataGridViewTextBoxColumn";
            // 
            // typeTicketDataGridViewTextBoxColumn
            // 
            this.typeTicketDataGridViewTextBoxColumn.DataPropertyName = "TypeTicket";
            this.typeTicketDataGridViewTextBoxColumn.HeaderText = "TypeTicket";
            this.typeTicketDataGridViewTextBoxColumn.Name = "typeTicketDataGridViewTextBoxColumn";
            // 
            // priceTicketDataGridViewTextBoxColumn
            // 
            this.priceTicketDataGridViewTextBoxColumn.DataPropertyName = "PriceTicket";
            this.priceTicketDataGridViewTextBoxColumn.HeaderText = "PriceTicket";
            this.priceTicketDataGridViewTextBoxColumn.Name = "priceTicketDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtBalanceTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ExcItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeExcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTicketDataGridViewTextBoxColumn;
    }
}

