namespace train
{
    partial class Form
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
            this.vizualizeB = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizeB
            // 
            this.vizualizeB.Location = new System.Drawing.Point(12, 12);
            this.vizualizeB.Name = "vizualizeB";
            this.vizualizeB.Size = new System.Drawing.Size(75, 23);
            this.vizualizeB.TabIndex = 0;
            this.vizualizeB.Text = "vizualize";
            this.vizualizeB.UseVisualStyleBackColor = true;
            this.vizualizeB.Click += new System.EventHandler(this.vizualizeB_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(167, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1320, 324);
            this.panel.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 443);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.vizualizeB);
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vizualizeB;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label;
    }
}

