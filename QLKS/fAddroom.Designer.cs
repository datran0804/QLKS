namespace QLKS
{
    partial class fAddroom
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
            btAddroom = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btAddroom
            // 
            btAddroom.Location = new Point(916, 402);
            btAddroom.Name = "btAddroom";
            btAddroom.Size = new Size(123, 29);
            btAddroom.TabIndex = 19;
            btAddroom.Text = "Thêm phòng";
            btAddroom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(695, 328);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 18;
            label4.Text = "Số Giường";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 246);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 17;
            label3.Text = "Loại phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 155);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 16;
            label2.Text = "Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(695, 82);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 15;
            label1.Text = "Số phòng";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Một giường", "Hai giường ", "Ba giường" });
            comboBox2.Location = new Point(695, 351);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 28);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Có view biển", "Không có view biển" });
            comboBox1.Location = new Point(695, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(695, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(695, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(547, 380);
            dataGridView1.TabIndex = 10;
            // 
            // fAddroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 512);
            Controls.Add(btAddroom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "fAddroom";
            Text = "fAddroom";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddroom;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}