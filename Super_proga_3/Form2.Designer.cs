namespace Super_Proga_3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_back = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Button_Sort_list = new System.Windows.Forms.ToolStripLabel();
            this.Button_Recalculate = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.A0 = new System.Windows.Forms.ToolStripLabel();
            this.A1 = new System.Windows.Forms.ToolStripLabel();
            this.A2 = new System.Windows.Forms.ToolStripLabel();
            this.A3 = new System.Windows.Forms.ToolStripLabel();
            this.A4 = new System.Windows.Forms.ToolStripLabel();
            this.A5 = new System.Windows.Forms.ToolStripLabel();
            this.A6 = new System.Windows.Forms.ToolStripLabel();
            this.A7 = new System.Windows.Forms.ToolStripLabel();
            this.A8 = new System.Windows.Forms.ToolStripLabel();
            this.A9 = new System.Windows.Forms.ToolStripLabel();
            this.A10 = new System.Windows.Forms.ToolStripLabel();
            this.A11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_back,
            this.toolStripButton1,
            this.Button_Sort_list,
            this.Button_Recalculate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_back
            // 
            this.Button_back.AutoSize = false;
            this.Button_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_back.Image = ((System.Drawing.Image)(resources.GetObject("Button_back.Image")));
            this.Button_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(40, 32);
            this.Button_back.Text = "toolStripButton1";
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Sort_list
            // 
            this.Button_Sort_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Sort_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Sort_list.Name = "Button_Sort_list";
            this.Button_Sort_list.Size = new System.Drawing.Size(169, 32);
            this.Button_Sort_list.Text = "Отсортировать   ";
            this.Button_Sort_list.Click += new System.EventHandler(this.Button_SortList_Click);
            // 
            // Button_Recalculate
            // 
            this.Button_Recalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Recalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Recalculate.Name = "Button_Recalculate";
            this.Button_Recalculate.Size = new System.Drawing.Size(155, 32);
            this.Button_Recalculate.Text = "Пересчитать     ";
            this.Button_Recalculate.Click += new System.EventHandler(this.Button_Recalculate_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 599);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A0,
            this.A1,
            this.A2,
            this.A3,
            this.A4,
            this.A5,
            this.A6,
            this.A7,
            this.A8,
            this.A9,
            this.A10,
            this.A11});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1185, 23);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // A0
            // 
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(98, 20);
            this.A0.Text = "Название     ";
            this.A0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A1
            // 
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(89, 20);
            this.A1.Text = "Прайс         ";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A2
            // 
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(96, 20);
            this.A2.Text = "Длина          ";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A3
            // 
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(96, 20);
            this.A3.Text = "Ширина       ";
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A4
            // 
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(69, 20);
            this.A4.Text = "Кол-во  ";
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A5
            // 
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(97, 20);
            this.A5.Text = "Площадь     ";
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A6
            // 
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(98, 20);
            this.A6.Text = "Сумма          ";
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A7
            // 
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(99, 20);
            this.A7.Text = "Толщина      ";
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A8
            // 
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(95, 20);
            this.A8.Text = "Объем         ";
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A9
            // 
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(102, 20);
            this.A9.Text = "Общ.Площ.  ";
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A10
            // 
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(104, 20);
            this.A10.Text = "Общ. Сумма ";
            this.A10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A11
            // 
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(105, 20);
            this.A11.Text = "Общ. Объем ";
            this.A11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_back;
        private System.Windows.Forms.ToolStripLabel Button_Sort_list;
        private System.Windows.Forms.ToolStripLabel Button_Recalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel A0;
        private System.Windows.Forms.ToolStripLabel A2;
        private System.Windows.Forms.ToolStripLabel A3;
        private System.Windows.Forms.ToolStripLabel A4;
        private System.Windows.Forms.ToolStripLabel A5;
        private System.Windows.Forms.ToolStripLabel A6;
        private System.Windows.Forms.ToolStripLabel A7;
        private System.Windows.Forms.ToolStripLabel A8;
        private System.Windows.Forms.ToolStripLabel A9;
        private System.Windows.Forms.ToolStripLabel A10;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel A11;
        private System.Windows.Forms.ToolStripLabel A1;
    }
}