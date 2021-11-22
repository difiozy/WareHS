
namespace WareHS
{
    partial class AddNewWareForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.name_lable = new System.Windows.Forms.Label();
            this.price_lable = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_ShippingDate = new System.Windows.Forms.Label();
            this.label_ReceiptDate = new System.Windows.Forms.Label();
            this.label_DisposalDate = new System.Windows.Forms.Label();
            this.ReceiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DisposalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShippingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonEndAddWare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Text = "box";
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lable.Location = new System.Drawing.Point(12, 9);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(48, 18);
            this.name_lable.TabIndex = 1;
            this.name_lable.Text = "Name";
            // 
            // price_lable
            // 
            this.price_lable.AutoSize = true;
            this.price_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_lable.Location = new System.Drawing.Point(12, 58);
            this.price_lable.Name = "price_lable";
            this.price_lable.Size = new System.Drawing.Size(42, 18);
            this.price_lable.TabIndex = 3;
            this.price_lable.Text = "Price";
            this.price_lable.UseWaitCursor = true;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(12, 84);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 2;
            this.textBox_Price.Text = "100";
            // 
            // label_ShippingDate
            // 
            this.label_ShippingDate.AutoSize = true;
            this.label_ShippingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ShippingDate.Location = new System.Drawing.Point(156, 58);
            this.label_ShippingDate.Name = "label_ShippingDate";
            this.label_ShippingDate.Size = new System.Drawing.Size(95, 18);
            this.label_ShippingDate.TabIndex = 5;
            this.label_ShippingDate.Text = "ShippingDate";
            // 
            // label_ReceiptDate
            // 
            this.label_ReceiptDate.AutoSize = true;
            this.label_ReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ReceiptDate.Location = new System.Drawing.Point(156, 34);
            this.label_ReceiptDate.Name = "label_ReceiptDate";
            this.label_ReceiptDate.Size = new System.Drawing.Size(89, 18);
            this.label_ReceiptDate.TabIndex = 6;
            this.label_ReceiptDate.Text = "ReceiptDate";
            // 
            // label_DisposalDate
            // 
            this.label_DisposalDate.AutoSize = true;
            this.label_DisposalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DisposalDate.Location = new System.Drawing.Point(154, 83);
            this.label_DisposalDate.Name = "label_DisposalDate";
            this.label_DisposalDate.Size = new System.Drawing.Size(97, 18);
            this.label_DisposalDate.TabIndex = 7;
            this.label_DisposalDate.Text = "DisposalDate";
            // 
            // ReceiptDateTimePicker
            // 
            this.ReceiptDateTimePicker.Location = new System.Drawing.Point(270, 29);
            this.ReceiptDateTimePicker.Name = "ReceiptDateTimePicker";
            this.ReceiptDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ReceiptDateTimePicker.TabIndex = 8;
            // 
            // DisposalDateTimePicker
            // 
            this.DisposalDateTimePicker.Location = new System.Drawing.Point(270, 81);
            this.DisposalDateTimePicker.Name = "DisposalDateTimePicker";
            this.DisposalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DisposalDateTimePicker.TabIndex = 9;
            // 
            // ShippingDateTimePicker
            // 
            this.ShippingDateTimePicker.Location = new System.Drawing.Point(270, 55);
            this.ShippingDateTimePicker.Name = "ShippingDateTimePicker";
            this.ShippingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ShippingDateTimePicker.TabIndex = 10;
            // 
            // ButtonEndAddWare
            // 
            this.ButtonEndAddWare.Location = new System.Drawing.Point(377, 107);
            this.ButtonEndAddWare.Name = "ButtonEndAddWare";
            this.ButtonEndAddWare.Size = new System.Drawing.Size(98, 44);
            this.ButtonEndAddWare.TabIndex = 11;
            this.ButtonEndAddWare.Text = "Add";
            this.ButtonEndAddWare.UseVisualStyleBackColor = true;
            this.ButtonEndAddWare.Click += new System.EventHandler(this.ButtonEndAddWare_Click);
            // 
            // AddNewWareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 163);
            this.Controls.Add(this.ButtonEndAddWare);
            this.Controls.Add(this.ShippingDateTimePicker);
            this.Controls.Add(this.DisposalDateTimePicker);
            this.Controls.Add(this.ReceiptDateTimePicker);
            this.Controls.Add(this.label_DisposalDate);
            this.Controls.Add(this.label_ReceiptDate);
            this.Controls.Add(this.label_ShippingDate);
            this.Controls.Add(this.price_lable);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.name_lable);
            this.Controls.Add(this.textBox_name);
            this.Name = "AddNewWareForm";
            this.Text = "AddNewWareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label price_lable;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_ShippingDate;
        private System.Windows.Forms.Label label_ReceiptDate;
        private System.Windows.Forms.Label label_DisposalDate;
        private System.Windows.Forms.DateTimePicker ReceiptDateTimePicker;
        private System.Windows.Forms.DateTimePicker DisposalDateTimePicker;
        private System.Windows.Forms.DateTimePicker ShippingDateTimePicker;
        private System.Windows.Forms.Button ButtonEndAddWare;
    }
}