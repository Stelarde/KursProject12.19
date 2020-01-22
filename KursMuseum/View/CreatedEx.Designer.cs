namespace KursMuseum.View
{
    partial class CreatedEx
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
            this.button1 = new System.Windows.Forms.Button();
            this.NameEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeStartEx = new System.Windows.Forms.DateTimePicker();
            this.DateTimeFinishEx = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NameEx
            // 
            this.NameEx.Location = new System.Drawing.Point(12, 25);
            this.NameEx.Name = "NameEx";
            this.NameEx.Size = new System.Drawing.Size(226, 20);
            this.NameEx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите название экскурсии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите дату и время начала экскурсии";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите дату и время конца экскурсии";
            // 
            // DateTimeStartEx
            // 
            this.DateTimeStartEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeStartEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeStartEx.Location = new System.Drawing.Point(12, 62);
            this.DateTimeStartEx.Name = "DateTimeStartEx";
            this.DateTimeStartEx.Size = new System.Drawing.Size(226, 20);
            this.DateTimeStartEx.TabIndex = 12;
            // 
            // DateTimeFinishEx
            // 
            this.DateTimeFinishEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeFinishEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFinishEx.Location = new System.Drawing.Point(12, 101);
            this.DateTimeFinishEx.Name = "DateTimeFinishEx";
            this.DateTimeFinishEx.Size = new System.Drawing.Size(226, 20);
            this.DateTimeFinishEx.TabIndex = 13;
            // 
            // CreatedEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 158);
            this.Controls.Add(this.DateTimeFinishEx);
            this.Controls.Add(this.DateTimeStartEx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameEx);
            this.Controls.Add(this.button1);
            this.Name = "CreatedEx";
            this.Text = "CreatedEx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeStartEx;
        private System.Windows.Forms.DateTimePicker DateTimeFinishEx;
    }
}