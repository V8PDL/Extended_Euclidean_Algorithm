namespace Extended_Euclideanean_Algorithm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Euclidean_datagrid = new System.Windows.Forms.DataGridView();
            this.Euclid_run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A_textbox = new System.Windows.Forms.TextBox();
            this.B_textbox = new System.Windows.Forms.TextBox();
            this.result_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Euclidean_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Euclidean_datagrid
            // 
            this.Euclidean_datagrid.AllowUserToAddRows = false;
            this.Euclidean_datagrid.AllowUserToDeleteRows = false;
            this.Euclidean_datagrid.AllowUserToResizeColumns = false;
            this.Euclidean_datagrid.AllowUserToResizeRows = false;
            this.Euclidean_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Euclidean_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Euclidean_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Euclidean_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Euclidean_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Euclidean_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Euclidean_datagrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Euclidean_datagrid.Location = new System.Drawing.Point(12, 188);
            this.Euclidean_datagrid.Name = "Euclidean_datagrid";
            this.Euclidean_datagrid.ReadOnly = true;
            this.Euclidean_datagrid.RowHeadersVisible = false;
            this.Euclidean_datagrid.RowHeadersWidth = 20;
            this.Euclidean_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Euclidean_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Euclidean_datagrid.RowTemplate.Height = 28;
            this.Euclidean_datagrid.Size = new System.Drawing.Size(514, 178);
            this.Euclidean_datagrid.StandardTab = true;
            this.Euclidean_datagrid.TabIndex = 12;
            this.Euclidean_datagrid.TabStop = false;
            // 
            // Euclid_run
            // 
            this.Euclid_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Euclid_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Euclid_run.Location = new System.Drawing.Point(289, 76);
            this.Euclid_run.Name = "Euclid_run";
            this.Euclid_run.Size = new System.Drawing.Size(192, 42);
            this.Euclid_run.TabIndex = 11;
            this.Euclid_run.Text = "Запустить";
            this.Euclid_run.UseVisualStyleBackColor = true;
            this.Euclid_run.Click += new System.EventHandler(this.Euclidean_run_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(37, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "B";
            // 
            // A_textbox
            // 
            this.A_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.A_textbox.Location = new System.Drawing.Point(42, 47);
            this.A_textbox.Name = "A_textbox";
            this.A_textbox.Size = new System.Drawing.Size(203, 30);
            this.A_textbox.TabIndex = 7;
            // 
            // B_textbox
            // 
            this.B_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_textbox.Location = new System.Drawing.Point(42, 132);
            this.B_textbox.Name = "B_textbox";
            this.B_textbox.Size = new System.Drawing.Size(203, 30);
            this.B_textbox.TabIndex = 8;
            // 
            // result_text
            // 
            this.result_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_text.BackColor = System.Drawing.SystemColors.Control;
            this.result_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_text.CausesValidation = false;
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.result_text.Location = new System.Drawing.Point(12, 372);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.Size = new System.Drawing.Size(514, 159);
            this.result_text.TabIndex = 0;
            this.result_text.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(538, 534);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.B_textbox);
            this.Controls.Add(this.A_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Euclid_run);
            this.Controls.Add(this.Euclidean_datagrid);
            this.MinimumSize = new System.Drawing.Size(560, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расширенный алгоритм Евклида";
            ((System.ComponentModel.ISupportInitialize)(this.Euclidean_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Euclidean_datagrid;
        private System.Windows.Forms.Button Euclid_run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A_textbox;
        private System.Windows.Forms.TextBox B_textbox;
        private System.Windows.Forms.TextBox result_text;
    }
}

