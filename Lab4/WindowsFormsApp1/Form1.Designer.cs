namespace _4._1
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(102, 23);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Чтение из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(299, 14);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.ReadOnly = true;
            this.textBoxFileReadTime.Size = new System.Drawing.Size(288, 20);
            this.textBoxFileReadTime.TabIndex = 1;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(375, 40);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.ReadOnly = true;
            this.textBoxFileReadCount.Size = new System.Drawing.Size(212, 20);
            this.textBoxFileReadCount.TabIndex = 2;
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(12, 120);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(102, 23);
            this.buttonExact.TabIndex = 3;
            this.buttonExact.Text = "Четкий поиск";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(191, 81);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(206, 20);
            this.textBoxFind.TabIndex = 4;
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(299, 120);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.ReadOnly = true;
            this.textBoxExactTime.Size = new System.Drawing.Size(288, 20);
            this.textBoxExactTime.TabIndex = 5;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(12, 278);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(264, 160);
            this.listBoxResult.TabIndex = 6;
            // 
            // buttonApprox
            // 
            this.buttonApprox.Location = new System.Drawing.Point(12, 191);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(100, 38);
            this.buttonApprox.TabIndex = 7;
            this.buttonApprox.Text = "Параллельный нечеткий поиск";
            this.buttonApprox.UseVisualStyleBackColor = true;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(438, 146);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(149, 20);
            this.textBoxMaxDist.TabIndex = 8;
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(285, 188);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreadCount.TabIndex = 9;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(355, 214);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.ReadOnly = true;
            this.textBoxApproxTime.Size = new System.Drawing.Size(152, 20);
            this.textBoxApproxTime.TabIndex = 10;
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(308, 240);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.ReadOnly = true;
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(199, 20);
            this.textBoxThreadCountAll.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время чтения из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Слово для поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время четкого поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Максимальное расстояние для нечеткого поиска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Количество потоков:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Вычисленное количество потоков:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Время нечеткого поиска:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "Form1";
            this.Text = "Поиск в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}



