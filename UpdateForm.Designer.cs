
namespace WareHS
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.ReceiptdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShippingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DisposalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ReceiptDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ShippingDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "DisposalDate";
            // 
            // id_comboBox
            // 
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(124, 10);
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(51, 21);
            this.id_comboBox.TabIndex = 9;
            this.id_comboBox.Text = "0";
            this.id_comboBox.SelectedIndexChanged += new System.EventHandler(this.id_comboBox_SelectedIndexChanged);
            // 
            // ReceiptdateTimePicker
            // 
            this.ReceiptdateTimePicker.Location = new System.Drawing.Point(124, 100);
            this.ReceiptdateTimePicker.Name = "ReceiptdateTimePicker";
            this.ReceiptdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ReceiptdateTimePicker.TabIndex = 12;
            // 
            // ShippingDateTimePicker
            // 
            this.ShippingDateTimePicker.Location = new System.Drawing.Point(124, 130);
            this.ShippingDateTimePicker.Name = "ShippingDateTimePicker";
            this.ShippingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ShippingDateTimePicker.TabIndex = 13;
            // 
            // DisposalDateTimePicker
            // 
            this.DisposalDateTimePicker.Location = new System.Drawing.Point(124, 160);
            this.DisposalDateTimePicker.Name = "DisposalDateTimePicker";
            this.DisposalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DisposalDateTimePicker.TabIndex = 14;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(124, 40);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 15;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(124, 70);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(100, 20);
            this.price_textBox.TabIndex = 16;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(208, 186);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(116, 23);
            this.update_button.TabIndex = 17;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 218);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.DisposalDateTimePicker);
            this.Controls.Add(this.ShippingDateTimePicker);
            this.Controls.Add(this.ReceiptdateTimePicker);
            this.Controls.Add(this.id_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox id_comboBox;
        private System.Windows.Forms.DateTimePicker ReceiptdateTimePicker;
        private System.Windows.Forms.DateTimePicker ShippingDateTimePicker;
        private System.Windows.Forms.DateTimePicker DisposalDateTimePicker;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Button update_button;
    }
}