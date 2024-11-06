namespace УП_2
{
    partial class PlayListForm
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
            listBox1 = new ListBox();
            goBackBut = new Button();
            goNextBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            addBut = new Button();
            beginBut = new Button();
            playBut = new Button();
            deleteBut = new Button();
            clearBut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 224);
            listBox1.TabIndex = 0;
            // 
            // goBackBut
            // 
            goBackBut.Location = new Point(112, 242);
            goBackBut.Name = "goBackBut";
            goBackBut.Size = new Size(74, 29);
            goBackBut.TabIndex = 1;
            goBackBut.Text = "<<";
            goBackBut.UseVisualStyleBackColor = true;
            goBackBut.Click += goBackBut_Click;
            // 
            // goNextBut
            // 
            goNextBut.Location = new Point(344, 242);
            goNextBut.Name = "goNextBut";
            goNextBut.Size = new Size(62, 29);
            goNextBut.TabIndex = 2;
            goNextBut.Text = ">>";
            goNextBut.UseVisualStyleBackColor = true;
            goNextBut.Click += goNextBut_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Автор";
            textBox1.Size = new Size(298, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 45);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Название песни";
            textBox2.Size = new Size(298, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(490, 78);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Путь до файла с мелодией";
            textBox3.Size = new Size(298, 27);
            textBox3.TabIndex = 5;
            // 
            // addBut
            // 
            addBut.Location = new Point(561, 111);
            addBut.Name = "addBut";
            addBut.Size = new Size(151, 29);
            addBut.TabIndex = 6;
            addBut.Text = "Добавить песню";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += addBut_Click;
            // 
            // beginBut
            // 
            beginBut.Location = new Point(12, 242);
            beginBut.Name = "beginBut";
            beginBut.Size = new Size(94, 29);
            beginBut.TabIndex = 7;
            beginBut.Text = "Начало";
            beginBut.UseVisualStyleBackColor = true;
            beginBut.Click += beginBut_Click;
            // 
            // playBut
            // 
            playBut.Location = new Point(192, 242);
            playBut.Name = "playBut";
            playBut.Size = new Size(146, 29);
            playBut.TabIndex = 8;
            playBut.Text = "Play";
            playBut.UseVisualStyleBackColor = true;
            playBut.Click += playBut_Click;
            // 
            // deleteBut
            // 
            deleteBut.Location = new Point(12, 277);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(174, 29);
            deleteBut.TabIndex = 9;
            deleteBut.Text = "Удалить песню";
            deleteBut.UseVisualStyleBackColor = true;
            deleteBut.Click += deleteBut_Click;
            // 
            // clearBut
            // 
            clearBut.Location = new Point(192, 277);
            clearBut.Name = "clearBut";
            clearBut.Size = new Size(214, 29);
            clearBut.TabIndex = 10;
            clearBut.Text = "Очистить плейлист";
            clearBut.UseVisualStyleBackColor = true;
            clearBut.Click += clearBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 398);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // PlayListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(clearBut);
            Controls.Add(deleteBut);
            Controls.Add(playBut);
            Controls.Add(beginBut);
            Controls.Add(addBut);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(goNextBut);
            Controls.Add(goBackBut);
            Controls.Add(listBox1);
            Name = "PlayListForm";
            Text = "PlayListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button goBackBut;
        private Button goNextBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button addBut;
        private Button beginBut;
        private Button playBut;
        private Button deleteBut;
        private Button clearBut;
        private Label label1;
    }
}