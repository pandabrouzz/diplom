namespace testing
{
    partial class Form1
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
            this.on_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_lux_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thread_timer = new System.Windows.Forms.Timer(this.components);
            this.top_menuStrip = new System.Windows.Forms.MenuStrip();
            this.COM_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.port_label = new System.Windows.Forms.Label();
            this.connection_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.top_menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // on_button
            // 
            this.on_button.Location = new System.Drawing.Point(12, 31);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(122, 25);
            this.on_button.TabIndex = 3;
            this.on_button.Text = "ON/OFF";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.date_time,
            this.current_lux_value});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // date_time
            // 
            this.date_time.HeaderText = "Дата и время";
            this.date_time.Name = "date_time";
            this.date_time.ReadOnly = true;
            // 
            // current_lux_value
            // 
            this.current_lux_value.HeaderText = "Освещенность";
            this.current_lux_value.Name = "current_lux_value";
            this.current_lux_value.ReadOnly = true;
            // 
            // top_menuStrip
            // 
            this.top_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.top_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM_ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.top_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.top_menuStrip.Name = "top_menuStrip";
            this.top_menuStrip.Size = new System.Drawing.Size(553, 28);
            this.top_menuStrip.TabIndex = 5;
            this.top_menuStrip.Text = "menuStrip1";
            // 
            // COM_ToolStripMenuItem
            // 
            this.COM_ToolStripMenuItem.Name = "COM_ToolStripMenuItem";
            this.COM_ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.COM_ToolStripMenuItem.Text = "COM порты";
            this.COM_ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.COM_ToolStripMenuItem_DropDownOpening);
            this.COM_ToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.COM_ToolStripMenuItem_DropDownItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(3, 0);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(46, 17);
            this.port_label.TabIndex = 6;
            this.port_label.Text = "label1";
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Location = new System.Drawing.Point(281, 0);
            this.connection_label.Name = "connection_label";
            this.connection_label.Size = new System.Drawing.Size(46, 17);
            this.connection_label.TabIndex = 7;
            this.connection_label.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.port_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.connection_label, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 290);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 24);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.on_button);
            this.Controls.Add(this.top_menuStrip);
            this.MainMenuStrip = this.top_menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.top_menuStrip.ResumeLayout(false);
            this.top_menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button on_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_lux_value;
        private System.Windows.Forms.Timer thread_timer;
        private System.Windows.Forms.MenuStrip top_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem COM_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

