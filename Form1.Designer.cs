namespace ThaiQuynhNhu_buoi_6
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
            btn_IT = new Button();
            btn_biz = new Button();
            SuspendLayout();
            // 
            // btn_IT
            // 
            btn_IT.Location = new Point(161, 143);
            btn_IT.Name = "btn_IT";
            btn_IT.Size = new Size(108, 42);
            btn_IT.TabIndex = 0;
            btn_IT.Text = "SinhVienIT";
            btn_IT.UseVisualStyleBackColor = true;
            btn_IT.Click += btn_IT_Click;
            // 
            // btn_biz
            // 
            btn_biz.Location = new Point(428, 143);
            btn_biz.Name = "btn_biz";
            btn_biz.Size = new Size(98, 42);
            btn_biz.TabIndex = 1;
            btn_biz.Text = "SinhVienBiz";
            btn_biz.UseVisualStyleBackColor = true;
            btn_biz.Click += btn_biz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_biz);
            Controls.Add(btn_IT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_IT;
        private Button btn_biz;
    }
}
