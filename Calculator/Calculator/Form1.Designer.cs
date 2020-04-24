namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVznos = new System.Windows.Forms.TextBox();
            this.txtSrok = new System.Windows.Forms.TextBox();
            this.txtProcent = new System.Windows.Forms.TextBox();
            this.txtEzPl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoimostN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVznos
            // 
            this.txtVznos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVznos.Location = new System.Drawing.Point(158, 55);
            this.txtVznos.Name = "txtVznos";
            this.txtVznos.Size = new System.Drawing.Size(100, 20);
            this.txtVznos.TabIndex = 0;
            this.txtVznos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVznos_KeyPress);
            // 
            // txtSrok
            // 
            this.txtSrok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrok.Location = new System.Drawing.Point(158, 89);
            this.txtSrok.Name = "txtSrok";
            this.txtSrok.Size = new System.Drawing.Size(100, 20);
            this.txtSrok.TabIndex = 1;
            this.txtSrok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrok_KeyPress);
            // 
            // txtProcent
            // 
            this.txtProcent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcent.Location = new System.Drawing.Point(158, 123);
            this.txtProcent.Name = "txtProcent";
            this.txtProcent.Size = new System.Drawing.Size(100, 20);
            this.txtProcent.TabIndex = 2;
            this.txtProcent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcent_KeyPress);
            // 
            // txtEzPl
            // 
            this.txtEzPl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEzPl.Location = new System.Drawing.Point(158, 162);
            this.txtEzPl.Name = "txtEzPl";
            this.txtEzPl.Size = new System.Drawing.Size(100, 20);
            this.txtEzPl.TabIndex = 3;
            this.txtEzPl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEzPl_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Первоначальный взнос";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Срок кредита (Месяцев)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ежемесячный платеж";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(52, 212);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(169, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Рассчитать";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоимость недвижимости";
            // 
            // txtStoimostN
            // 
            this.txtStoimostN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoimostN.Location = new System.Drawing.Point(158, 25);
            this.txtStoimostN.Name = "txtStoimostN";
            this.txtStoimostN.Size = new System.Drawing.Size(100, 20);
            this.txtStoimostN.TabIndex = 9;
            this.txtStoimostN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoimostN_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 247);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStoimostN);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEzPl);
            this.Controls.Add(this.txtProcent);
            this.Controls.Add(this.txtSrok);
            this.Controls.Add(this.txtVznos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор расчета ипотеки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVznos;
        private System.Windows.Forms.TextBox txtSrok;
        private System.Windows.Forms.TextBox txtProcent;
        private System.Windows.Forms.TextBox txtEzPl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStoimostN;
    }
}

