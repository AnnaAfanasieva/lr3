namespace lr3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComp = new System.Windows.Forms.ComboBox();
            this.readiness = new System.Windows.Forms.Label();
            this.countcomp = new System.Windows.Forms.Label();
            this.counttask = new System.Windows.Forms.Label();
            this.comboBoxTasks = new System.Windows.Forms.ComboBox();
            this.wifi = new System.Windows.Forms.Label();
            this.wifipassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Компьютеры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Готовность к работе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество компьютеров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Все задачи компьютера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество задач компьютера";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(463, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "WiFi роутер";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(645, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Пароль";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(30, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Добавить компьютер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxComp
            // 
            this.comboBoxComp.FormattingEnabled = true;
            this.comboBoxComp.Location = new System.Drawing.Point(271, 43);
            this.comboBoxComp.Name = "comboBoxComp";
            this.comboBoxComp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComp.TabIndex = 17;
            // 
            // readiness
            // 
            this.readiness.AutoSize = true;
            this.readiness.Location = new System.Drawing.Point(268, 119);
            this.readiness.Name = "readiness";
            this.readiness.Size = new System.Drawing.Size(51, 17);
            this.readiness.TabIndex = 18;
            this.readiness.Text = "waiting";
            // 
            // countcomp
            // 
            this.countcomp.AutoSize = true;
            this.countcomp.Location = new System.Drawing.Point(268, 179);
            this.countcomp.Name = "countcomp";
            this.countcomp.Size = new System.Drawing.Size(51, 17);
            this.countcomp.TabIndex = 19;
            this.countcomp.Text = "waiting";
            // 
            // counttask
            // 
            this.counttask.AutoSize = true;
            this.counttask.Location = new System.Drawing.Point(268, 320);
            this.counttask.Name = "counttask";
            this.counttask.Size = new System.Drawing.Size(51, 17);
            this.counttask.TabIndex = 20;
            this.counttask.Text = "waiting";
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Location = new System.Drawing.Point(271, 238);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTasks.TabIndex = 21;
            // 
            // wifi
            // 
            this.wifi.AutoSize = true;
            this.wifi.Location = new System.Drawing.Point(485, 94);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(27, 17);
            this.wifi.TabIndex = 22;
            this.wifi.Text = "wifi";
            // 
            // wifipassword
            // 
            this.wifipassword.AutoSize = true;
            this.wifipassword.Location = new System.Drawing.Point(645, 94);
            this.wifipassword.Name = "wifipassword";
            this.wifipassword.Size = new System.Drawing.Size(68, 17);
            this.wifipassword.TabIndex = 23;
            this.wifipassword.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.wifipassword);
            this.Controls.Add(this.wifi);
            this.Controls.Add(this.comboBoxTasks);
            this.Controls.Add(this.counttask);
            this.Controls.Add(this.countcomp);
            this.Controls.Add(this.readiness);
            this.Controls.Add(this.comboBoxComp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxComp;
        private System.Windows.Forms.Label readiness;
        private System.Windows.Forms.Label countcomp;
        private System.Windows.Forms.Label counttask;
        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.Label wifi;
        private System.Windows.Forms.Label wifipassword;
    }
}

