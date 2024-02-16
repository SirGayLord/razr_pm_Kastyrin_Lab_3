namespace razr_pm_Kastyrin_Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            btnGenerateArray = new Button();
            btn_SelectionSort = new Button();
            btn_InsertionSort = new Button();
            btn_QuickSort = new Button();
            btnBubbleSort = new Button();
            btnShakerSort = new Button();
            btnMergeSort = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(32, 27);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(150, 40);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Загрузить массив из файла";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnGenerateArray
            // 
            btnGenerateArray.Location = new Point(32, 82);
            btnGenerateArray.Name = "btnGenerateArray";
            btnGenerateArray.Size = new Size(150, 40);
            btnGenerateArray.TabIndex = 1;
            btnGenerateArray.Text = "Сгенерировать";
            btnGenerateArray.UseVisualStyleBackColor = true;
            btnGenerateArray.Click += btnGenerateArray_Click;
            // 
            // btn_SelectionSort
            // 
            btn_SelectionSort.Location = new Point(32, 163);
            btn_SelectionSort.Name = "btn_SelectionSort";
            btn_SelectionSort.Size = new Size(150, 40);
            btn_SelectionSort.TabIndex = 2;
            btn_SelectionSort.Text = "Сортировка выбором";
            btn_SelectionSort.UseVisualStyleBackColor = true;
            btn_SelectionSort.Click += btn_SelectionSort_Click_1;
            // 
            // btn_InsertionSort
            // 
            btn_InsertionSort.Location = new Point(32, 220);
            btn_InsertionSort.Name = "btn_InsertionSort";
            btn_InsertionSort.Size = new Size(150, 40);
            btn_InsertionSort.TabIndex = 3;
            btn_InsertionSort.Text = "Сортировка включением";
            btn_InsertionSort.UseVisualStyleBackColor = true;
            btn_InsertionSort.Click += btn_InsertionSort_Click_1;
            // 
            // btn_QuickSort
            // 
            btn_QuickSort.Location = new Point(32, 275);
            btn_QuickSort.Name = "btn_QuickSort";
            btn_QuickSort.Size = new Size(150, 40);
            btn_QuickSort.TabIndex = 4;
            btn_QuickSort.Text = "Быстрая сортировка";
            btn_QuickSort.UseVisualStyleBackColor = true;
            btn_QuickSort.Click += btn_QuickSort_Click;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(32, 330);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(150, 40);
            btnBubbleSort.TabIndex = 5;
            btnBubbleSort.Text = "Пузырьковая сортировка";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnShakerSort
            // 
            btnShakerSort.Location = new Point(32, 391);
            btnShakerSort.Name = "btnShakerSort";
            btnShakerSort.Size = new Size(150, 40);
            btnShakerSort.TabIndex = 6;
            btnShakerSort.Text = "Шейкер сортировка";
            btnShakerSort.UseVisualStyleBackColor = true;
            btnShakerSort.Click += btnShakerSort_Click;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Location = new Point(32, 447);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(150, 40);
            btnMergeSort.TabIndex = 7;
            btnMergeSort.Text = "Сортировка слиянием";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlText;
            pictureBox1.Location = new Point(0, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 2);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlText;
            pictureBox2.Location = new Point(247, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 499);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 10;
            label1.Text = "Первоначальный массив";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 220);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 11;
            label2.Text = "Отсортированный массив";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(586, 434);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 12;
            label3.Text = "Время выполнения:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(586, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 150);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(586, 254);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 150);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(742, 432);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 499);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnMergeSort);
            Controls.Add(btnShakerSort);
            Controls.Add(btnBubbleSort);
            Controls.Add(btn_QuickSort);
            Controls.Add(btn_InsertionSort);
            Controls.Add(btn_SelectionSort);
            Controls.Add(btnGenerateArray);
            Controls.Add(btnLoadFile);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadFile;
        private Button btnGenerateArray;
        private Button btn_SelectionSort;
        private Button btn_InsertionSort;
        private Button btn_QuickSort;
        private Button btnBubbleSort;
        private Button btnShakerSort;
        private Button btnMergeSort;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}