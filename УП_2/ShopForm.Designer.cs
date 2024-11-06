namespace УП_2
{
    partial class ShopForm
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
            groupBox1 = new GroupBox();
            addBut = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            addInBasket = new Button();
            sellBut = new Button();
            label3 = new Label();
            label4 = new Label();
            deleteBut = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addBut);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление товара";
            // 
            // addBut
            // 
            addBut.Location = new Point(137, 58);
            addBut.Name = "addBut";
            addBut.Size = new Size(125, 29);
            addBut.TabIndex = 3;
            addBut.Text = "Добавить";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += addBut_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 26);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Количество";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 59);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Цена";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 224);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 136);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = "Список продуктов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Корзина";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(518, 122);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(270, 264);
            listBox2.TabIndex = 3;
            // 
            // addInBasket
            // 
            addInBasket.Location = new Point(12, 389);
            addInBasket.Name = "addInBasket";
            addInBasket.Size = new Size(270, 49);
            addInBasket.TabIndex = 5;
            addInBasket.Text = "Добавить выбранный товар в корзину";
            addInBasket.UseVisualStyleBackColor = true;
            addInBasket.Click += addInBasket_Click;
            // 
            // sellBut
            // 
            sellBut.Location = new Point(518, 392);
            sellBut.Name = "sellBut";
            sellBut.Size = new Size(97, 49);
            sellBut.TabIndex = 6;
            sellBut.Text = "Продать";
            sellBut.UseVisualStyleBackColor = true;
            sellBut.Click += sellBut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 12);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 7;
            label3.Text = "Прибыль магазина:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(660, 12);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // deleteBut
            // 
            deleteBut.Location = new Point(621, 392);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(167, 49);
            deleteBut.TabIndex = 9;
            deleteBut.Text = "Удалить выбранный товар";
            deleteBut.UseVisualStyleBackColor = true;
            deleteBut.Click += deleteBut_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sellBut);
            Controls.Add(addInBasket);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "ShopForm";
            Text = "ShopForm";
            Load += ShopForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button addBut;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Button addInBasket;
        private Button sellBut;
        private Label label3;
        private Label label4;
        private Button deleteBut;
    }
}