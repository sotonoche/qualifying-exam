namespace WindowsFormsExam
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTask1X = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxTask1Y = new System.Windows.Forms.TextBox();
            this.buttonTask1GetRes = new System.Windows.Forms.Button();
            this.label1Task1X = new System.Windows.Forms.Label();
            this.labelTask1Y = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTask2Y = new System.Windows.Forms.Label();
            this.labelTask2X = new System.Windows.Forms.Label();
            this.buttonTask2GetRes = new System.Windows.Forms.Button();
            this.textBoxTask2Y = new System.Windows.Forms.TextBox();
            this.textBoxTask2X = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.опрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buttonToolStripMenuItem.Text = "Открыть";
            this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.опрограммеToolStripMenuItem.Text = "О программе";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // textBoxTask1X
            // 
            this.textBoxTask1X.Location = new System.Drawing.Point(12, 724);
            this.textBoxTask1X.Name = "textBoxTask1X";
            this.textBoxTask1X.Size = new System.Drawing.Size(100, 20);
            this.textBoxTask1X.TabIndex = 1;
            this.textBoxTask1X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTask1X_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1298, 670);
            this.webBrowser1.TabIndex = 2;
            // 
            // textBoxTask1Y
            // 
            this.textBoxTask1Y.Location = new System.Drawing.Point(161, 724);
            this.textBoxTask1Y.Name = "textBoxTask1Y";
            this.textBoxTask1Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxTask1Y.TabIndex = 3;
            this.textBoxTask1Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTask1Y_KeyPress);
            // 
            // buttonTask1GetRes
            // 
            this.buttonTask1GetRes.Location = new System.Drawing.Point(306, 724);
            this.buttonTask1GetRes.Name = "buttonTask1GetRes";
            this.buttonTask1GetRes.Size = new System.Drawing.Size(90, 23);
            this.buttonTask1GetRes.TabIndex = 4;
            this.buttonTask1GetRes.Text = "Узнать";
            this.buttonTask1GetRes.UseVisualStyleBackColor = true;
            this.buttonTask1GetRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1Task1X
            // 
            this.label1Task1X.AutoSize = true;
            this.label1Task1X.Location = new System.Drawing.Point(12, 708);
            this.label1Task1X.Name = "label1Task1X";
            this.label1Task1X.Size = new System.Drawing.Size(43, 13);
            this.label1Task1X.TabIndex = 5;
            this.label1Task1X.Text = "Ввод x:";
            // 
            // labelTask1Y
            // 
            this.labelTask1Y.AutoSize = true;
            this.labelTask1Y.Location = new System.Drawing.Point(158, 708);
            this.labelTask1Y.Name = "labelTask1Y";
            this.labelTask1Y.Size = new System.Drawing.Size(43, 13);
            this.labelTask1Y.TabIndex = 6;
            this.labelTask1Y.Text = "Ввод y:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 748);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1322, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // labelTask2Y
            // 
            this.labelTask2Y.AutoSize = true;
            this.labelTask2Y.Location = new System.Drawing.Point(685, 708);
            this.labelTask2Y.Name = "labelTask2Y";
            this.labelTask2Y.Size = new System.Drawing.Size(43, 13);
            this.labelTask2Y.TabIndex = 12;
            this.labelTask2Y.Text = "Ввод y:";
            // 
            // labelTask2X
            // 
            this.labelTask2X.AutoSize = true;
            this.labelTask2X.Location = new System.Drawing.Point(539, 708);
            this.labelTask2X.Name = "labelTask2X";
            this.labelTask2X.Size = new System.Drawing.Size(43, 13);
            this.labelTask2X.TabIndex = 11;
            this.labelTask2X.Text = "Ввод x:";
            // 
            // buttonTask2GetRes
            // 
            this.buttonTask2GetRes.Location = new System.Drawing.Point(833, 724);
            this.buttonTask2GetRes.Name = "buttonTask2GetRes";
            this.buttonTask2GetRes.Size = new System.Drawing.Size(90, 23);
            this.buttonTask2GetRes.TabIndex = 10;
            this.buttonTask2GetRes.Text = "Узнать";
            this.buttonTask2GetRes.UseVisualStyleBackColor = true;
            this.buttonTask2GetRes.Click += new System.EventHandler(this.buttonTask2GetRes_Click);
            // 
            // textBoxTask2Y
            // 
            this.textBoxTask2Y.Location = new System.Drawing.Point(688, 724);
            this.textBoxTask2Y.Name = "textBoxTask2Y";
            this.textBoxTask2Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxTask2Y.TabIndex = 9;
            // 
            // textBoxTask2X
            // 
            this.textBoxTask2X.Location = new System.Drawing.Point(539, 724);
            this.textBoxTask2X.Name = "textBoxTask2X";
            this.textBoxTask2X.Size = new System.Drawing.Size(100, 20);
            this.textBoxTask2X.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 770);
            this.Controls.Add(this.labelTask2Y);
            this.Controls.Add(this.labelTask2X);
            this.Controls.Add(this.buttonTask2GetRes);
            this.Controls.Add(this.textBoxTask2Y);
            this.Controls.Add(this.textBoxTask2X);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelTask1Y);
            this.Controls.Add(this.label1Task1X);
            this.Controls.Add(this.buttonTask1GetRes);
            this.Controls.Add(this.textBoxTask1Y);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBoxTask1X);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Автоматизация расчетов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTask1X;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxTask1Y;
        private System.Windows.Forms.Button buttonTask1GetRes;
        private System.Windows.Forms.Label label1Task1X;
        private System.Windows.Forms.Label labelTask1Y;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelTask2Y;
        private System.Windows.Forms.Label labelTask2X;
        private System.Windows.Forms.Button buttonTask2GetRes;
        private System.Windows.Forms.TextBox textBoxTask2Y;
        private System.Windows.Forms.TextBox textBoxTask2X;
    }
}

