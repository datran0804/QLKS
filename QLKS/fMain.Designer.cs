namespace QLKS
{
    partial class fMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btAddroom = new Button();
            btAddcustomer = new Button();
            btCheckout = new Button();
            btCustomerdetail = new Button();
            btEmployee = new Button();
            panel1 = new Panel();
            bindingSource1 = new BindingSource(components);
            btnExit = new Button();
            btMinimized = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btAddroom);
            flowLayoutPanel1.Controls.Add(btAddcustomer);
            flowLayoutPanel1.Controls.Add(btCheckout);
            flowLayoutPanel1.Controls.Add(btCustomerdetail);
            flowLayoutPanel1.Controls.Add(btEmployee);
            flowLayoutPanel1.Location = new Point(70, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1214, 130);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btAddroom
            // 
            btAddroom.FlatStyle = FlatStyle.Flat;
            btAddroom.Image = (Image)resources.GetObject("btAddroom.Image");
            btAddroom.ImageAlign = ContentAlignment.MiddleLeft;
            btAddroom.Location = new Point(3, 3);
            btAddroom.Name = "btAddroom";
            btAddroom.Size = new Size(220, 114);
            btAddroom.TabIndex = 0;
            btAddroom.Text = "Thêm Phòng";
            btAddroom.UseVisualStyleBackColor = true;
            btAddroom.Click += btAddroom_Click;
            // 
            // btAddcustomer
            // 
            btAddcustomer.FlatStyle = FlatStyle.Flat;
            btAddcustomer.Image = (Image)resources.GetObject("btAddcustomer.Image");
            btAddcustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btAddcustomer.Location = new Point(229, 3);
            btAddcustomer.Name = "btAddcustomer";
            btAddcustomer.Size = new Size(220, 114);
            btAddcustomer.TabIndex = 1;
            btAddcustomer.Text = "Đăng ký khách hàng";
            btAddcustomer.UseVisualStyleBackColor = true;
            // 
            // btCheckout
            // 
            btCheckout.FlatStyle = FlatStyle.Flat;
            btCheckout.Image = (Image)resources.GetObject("btCheckout.Image");
            btCheckout.ImageAlign = ContentAlignment.MiddleLeft;
            btCheckout.Location = new Point(455, 3);
            btCheckout.Name = "btCheckout";
            btCheckout.Size = new Size(220, 114);
            btCheckout.TabIndex = 2;
            btCheckout.Text = "Check Out";
            btCheckout.UseVisualStyleBackColor = true;
            // 
            // btCustomerdetail
            // 
            btCustomerdetail.FlatStyle = FlatStyle.Flat;
            btCustomerdetail.Image = (Image)resources.GetObject("btCustomerdetail.Image");
            btCustomerdetail.ImageAlign = ContentAlignment.MiddleLeft;
            btCustomerdetail.Location = new Point(681, 3);
            btCustomerdetail.Name = "btCustomerdetail";
            btCustomerdetail.Size = new Size(220, 114);
            btCustomerdetail.TabIndex = 3;
            btCustomerdetail.Text = "Chi tiết khách hàng";
            btCustomerdetail.UseVisualStyleBackColor = true;
            // 
            // btEmployee
            // 
            btEmployee.FlatStyle = FlatStyle.Flat;
            btEmployee.Image = (Image)resources.GetObject("btEmployee.Image");
            btEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btEmployee.Location = new Point(907, 3);
            btEmployee.Name = "btEmployee";
            btEmployee.Size = new Size(220, 114);
            btEmployee.TabIndex = 4;
            btEmployee.Text = "Nhân viên";
            btEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 505);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 50);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btMinimized
            // 
            btMinimized.BackColor = Color.Transparent;
            btMinimized.BackgroundImage = (Image)resources.GetObject("btMinimized.BackgroundImage");
            btMinimized.BackgroundImageLayout = ImageLayout.Center;
            btMinimized.FlatStyle = FlatStyle.Popup;
            btMinimized.Location = new Point(12, 79);
            btMinimized.Name = "btMinimized";
            btMinimized.Size = new Size(52, 50);
            btMinimized.TabIndex = 2;
            btMinimized.UseVisualStyleBackColor = false;
            btMinimized.Click += btMinimized_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 120, 138);
            ClientSize = new Size(1329, 676);
            Controls.Add(btMinimized);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fMain";
            Text = "fTrangchu";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private BindingSource bindingSource1;
        private Button btnExit;
        private Button btMinimized;
        private Button btAddroom;
        private Button btAddcustomer;
        private Button btCheckout;
        private Button btCustomerdetail;
        private Button btEmployee;
    }
}