namespace testing
{
    partial class cabForm
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
            this.top_menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.current_lightness_label = new System.Windows.Forms.Label();
            this.connection_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.current_lux_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.top_menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_menuStrip
            // 
            this.top_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.top_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.form2ToolStripMenuItem,
            this.form1ToolStripMenuItem});
            this.top_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.top_menuStrip.Name = "top_menuStrip";
            this.top_menuStrip.Size = new System.Drawing.Size(800, 28);
            this.top_menuStrip.TabIndex = 5;
            this.top_menuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.form2ToolStripMenuItem.Text = "form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.form1ToolStripMenuItem.Text = "form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // current_lightness_label
            // 
            this.current_lightness_label.AutoSize = true;
            this.current_lightness_label.Location = new System.Drawing.Point(3, 0);
            this.current_lightness_label.Name = "current_lightness_label";
            this.current_lightness_label.Size = new System.Drawing.Size(46, 17);
            this.current_lightness_label.TabIndex = 6;
            this.current_lightness_label.Text = "label1";
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Location = new System.Drawing.Point(405, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.current_lightness_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.connection_label, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 611);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 24);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(12, 31);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(389, 343);
            this.LogTextBox.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(408, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 342);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // current_lux_value
            // 
            this.current_lux_value.HeaderText = "Освещенность";
            this.current_lux_value.Name = "current_lux_value";
            this.current_lux_value.ReadOnly = true;
            // 
            // date_time
            // 
            this.date_time.HeaderText = "Дата и время";
            this.date_time.Name = "date_time";
            this.date_time.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // cabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.top_menuStrip);
            this.MainMenuStrip = this.top_menuStrip;
            this.Name = "cabForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top_menuStrip.ResumeLayout(false);
            this.top_menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip top_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label current_lightness_label;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_lux_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

