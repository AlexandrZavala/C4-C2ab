namespace C4
{
    partial class CsLab3
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
            this.Side1ValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Side2ValueBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.SetValueButton = new System.Windows.Forms.Button();
            this.ShowValuesButton = new System.Windows.Forms.Button();
            this.RectanglesInfTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CounterBox = new System.Windows.Forms.TextBox();
            this.ParCounterBox = new System.Windows.Forms.TextBox();
            this.GenerateValuesPar = new System.Windows.Forms.Button();
            this.ParInfTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowValuesPar = new System.Windows.Forms.Button();
            this.SetValuesPar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeBoxPar = new System.Windows.Forms.TextBox();
            this.CreateButtonPar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Side2ValueBoxPar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Side1ValueBoxPar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Side1ValueBox
            // 
            this.Side1ValueBox.Enabled = false;
            this.Side1ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side1ValueBox.Location = new System.Drawing.Point(5, 71);
            this.Side1ValueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Side1ValueBox.Name = "Side1ValueBox";
            this.Side1ValueBox.Size = new System.Drawing.Size(100, 36);
            this.Side1ValueBox.TabIndex = 2;
            this.Side1ValueBox.Text = "0";
            this.Side1ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First side length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second side length";
            // 
            // Side2ValueBox
            // 
            this.Side2ValueBox.Enabled = false;
            this.Side2ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side2ValueBox.Location = new System.Drawing.Point(5, 132);
            this.Side2ValueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Side2ValueBox.Name = "Side2ValueBox";
            this.Side2ValueBox.Size = new System.Drawing.Size(100, 36);
            this.Side2ValueBox.TabIndex = 3;
            this.Side2ValueBox.Text = "0";
            this.Side2ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.Window;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(286, 10);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 36);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size of array of rectangles";
            // 
            // SizeBox
            // 
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeBox.Location = new System.Drawing.Point(189, 16);
            this.SizeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(39, 26);
            this.SizeBox.TabIndex = 0;
            this.SizeBox.Text = "0";
            this.SizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SetValueButton
            // 
            this.SetValueButton.Enabled = false;
            this.SetValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetValueButton.Location = new System.Drawing.Point(5, 174);
            this.SetValueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetValueButton.Name = "SetValueButton";
            this.SetValueButton.Size = new System.Drawing.Size(120, 36);
            this.SetValueButton.TabIndex = 4;
            this.SetValueButton.Text = "Set values";
            this.SetValueButton.UseVisualStyleBackColor = true;
            this.SetValueButton.Click += new System.EventHandler(this.SaveValueButton_Click);
            // 
            // ShowValuesButton
            // 
            this.ShowValuesButton.Enabled = false;
            this.ShowValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowValuesButton.Location = new System.Drawing.Point(7, 404);
            this.ShowValuesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowValuesButton.Name = "ShowValuesButton";
            this.ShowValuesButton.Size = new System.Drawing.Size(120, 36);
            this.ShowValuesButton.TabIndex = 6;
            this.ShowValuesButton.Text = "Show values";
            this.ShowValuesButton.UseVisualStyleBackColor = true;
            this.ShowValuesButton.Click += new System.EventHandler(this.DispInfo_Click);
            // 
            // RectanglesInfTextBox
            // 
            this.RectanglesInfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RectanglesInfTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RectanglesInfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesInfTextBox.Location = new System.Drawing.Point(157, 71);
            this.RectanglesInfTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesInfTextBox.Name = "RectanglesInfTextBox";
            this.RectanglesInfTextBox.ReadOnly = true;
            this.RectanglesInfTextBox.Size = new System.Drawing.Size(229, 368);
            this.RectanglesInfTextBox.TabIndex = 10;
            this.RectanglesInfTextBox.TabStop = false;
            this.RectanglesInfTextBox.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(5, 214);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(120, 36);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CounterBox
            // 
            this.CounterBox.BackColor = System.Drawing.SystemColors.Control;
            this.CounterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CounterBox.Enabled = false;
            this.CounterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterBox.Location = new System.Drawing.Point(7, 256);
            this.CounterBox.Margin = new System.Windows.Forms.Padding(4);
            this.CounterBox.Name = "CounterBox";
            this.CounterBox.ReadOnly = true;
            this.CounterBox.Size = new System.Drawing.Size(119, 16);
            this.CounterBox.TabIndex = 9;
            this.CounterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ParCounterBox
            // 
            this.ParCounterBox.BackColor = System.Drawing.SystemColors.Control;
            this.ParCounterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParCounterBox.Enabled = false;
            this.ParCounterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParCounterBox.Location = new System.Drawing.Point(460, 318);
            this.ParCounterBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParCounterBox.Name = "ParCounterBox";
            this.ParCounterBox.ReadOnly = true;
            this.ParCounterBox.Size = new System.Drawing.Size(131, 16);
            this.ParCounterBox.TabIndex = 21;
            this.ParCounterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateValuesPar
            // 
            this.GenerateValuesPar.Enabled = false;
            this.GenerateValuesPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateValuesPar.Location = new System.Drawing.Point(459, 276);
            this.GenerateValuesPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateValuesPar.Name = "GenerateValuesPar";
            this.GenerateValuesPar.Size = new System.Drawing.Size(120, 36);
            this.GenerateValuesPar.TabIndex = 18;
            this.GenerateValuesPar.Text = "Generate";
            this.GenerateValuesPar.UseVisualStyleBackColor = true;
            this.GenerateValuesPar.Click += new System.EventHandler(this.GenerateValuesPar_Click);
            // 
            // ParInfTextBox
            // 
            this.ParInfTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ParInfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParInfTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ParInfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParInfTextBox.Location = new System.Drawing.Point(612, 71);
            this.ParInfTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParInfTextBox.Name = "ParInfTextBox";
            this.ParInfTextBox.ReadOnly = true;
            this.ParInfTextBox.Size = new System.Drawing.Size(229, 368);
            this.ParInfTextBox.TabIndex = 22;
            this.ParInfTextBox.TabStop = false;
            this.ParInfTextBox.Text = "";
            // 
            // ShowValuesPar
            // 
            this.ShowValuesPar.Enabled = false;
            this.ShowValuesPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowValuesPar.Location = new System.Drawing.Point(461, 403);
            this.ShowValuesPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowValuesPar.Name = "ShowValuesPar";
            this.ShowValuesPar.Size = new System.Drawing.Size(120, 36);
            this.ShowValuesPar.TabIndex = 19;
            this.ShowValuesPar.Text = "Show values";
            this.ShowValuesPar.UseVisualStyleBackColor = true;
            this.ShowValuesPar.Click += new System.EventHandler(this.ShowValuesPar_Click);
            // 
            // SetValuesPar
            // 
            this.SetValuesPar.Enabled = false;
            this.SetValuesPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetValuesPar.Location = new System.Drawing.Point(459, 236);
            this.SetValuesPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetValuesPar.Name = "SetValuesPar";
            this.SetValuesPar.Size = new System.Drawing.Size(120, 36);
            this.SetValuesPar.TabIndex = 17;
            this.SetValuesPar.Text = "Set values";
            this.SetValuesPar.UseVisualStyleBackColor = true;
            this.SetValuesPar.Click += new System.EventHandler(this.SetValuesPar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(458, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Size of array of parallelepipeds\r\n";
            // 
            // SizeBoxPar
            // 
            this.SizeBoxPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeBoxPar.Location = new System.Drawing.Point(673, 16);
            this.SizeBoxPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeBoxPar.Name = "SizeBoxPar";
            this.SizeBoxPar.Size = new System.Drawing.Size(39, 26);
            this.SizeBoxPar.TabIndex = 11;
            this.SizeBoxPar.Text = "0";
            this.SizeBoxPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateButtonPar
            // 
            this.CreateButtonPar.BackColor = System.Drawing.SystemColors.Window;
            this.CreateButtonPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButtonPar.Location = new System.Drawing.Point(741, 11);
            this.CreateButtonPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButtonPar.Name = "CreateButtonPar";
            this.CreateButtonPar.Size = new System.Drawing.Size(100, 36);
            this.CreateButtonPar.TabIndex = 12;
            this.CreateButtonPar.Text = "Create";
            this.CreateButtonPar.UseVisualStyleBackColor = false;
            this.CreateButtonPar.Click += new System.EventHandler(this.CreateButtonPar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(458, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Second side length";
            // 
            // Side2ValueBoxPar
            // 
            this.Side2ValueBoxPar.Enabled = false;
            this.Side2ValueBoxPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side2ValueBoxPar.Location = new System.Drawing.Point(460, 132);
            this.Side2ValueBoxPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Side2ValueBoxPar.Name = "Side2ValueBoxPar";
            this.Side2ValueBoxPar.Size = new System.Drawing.Size(100, 36);
            this.Side2ValueBoxPar.TabIndex = 16;
            this.Side2ValueBoxPar.Text = "0";
            this.Side2ValueBoxPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(458, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "First side length";
            // 
            // Side1ValueBoxPar
            // 
            this.Side1ValueBoxPar.Enabled = false;
            this.Side1ValueBoxPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Side1ValueBoxPar.Location = new System.Drawing.Point(460, 71);
            this.Side1ValueBoxPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Side1ValueBoxPar.Name = "Side1ValueBoxPar";
            this.Side1ValueBoxPar.Size = new System.Drawing.Size(100, 36);
            this.Side1ValueBoxPar.TabIndex = 14;
            this.Side1ValueBoxPar.Text = "0";
            this.Side1ValueBoxPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(457, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Height length";
            // 
            // HeightBox
            // 
            this.HeightBox.Enabled = false;
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightBox.Location = new System.Drawing.Point(459, 195);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 36);
            this.HeightBox.TabIndex = 24;
            this.HeightBox.Text = "0";
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CsLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.ParCounterBox);
            this.Controls.Add(this.GenerateValuesPar);
            this.Controls.Add(this.ParInfTextBox);
            this.Controls.Add(this.ShowValuesPar);
            this.Controls.Add(this.SetValuesPar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeBoxPar);
            this.Controls.Add(this.CreateButtonPar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Side2ValueBoxPar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Side1ValueBoxPar);
            this.Controls.Add(this.CounterBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.RectanglesInfTextBox);
            this.Controls.Add(this.ShowValuesButton);
            this.Controls.Add(this.SetValueButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Side2ValueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Side1ValueBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CsLab3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsLab3_FormClosing);
            this.Shown += new System.EventHandler(this.CsLab3_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Side1ValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Side2ValueBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.Button SetValueButton;
        private System.Windows.Forms.Button ShowValuesButton;
        private System.Windows.Forms.RichTextBox RectanglesInfTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox CounterBox;
        private System.Windows.Forms.TextBox ParCounterBox;
        private System.Windows.Forms.Button GenerateValuesPar;
        private System.Windows.Forms.RichTextBox ParInfTextBox;
        private System.Windows.Forms.Button ShowValuesPar;
        private System.Windows.Forms.Button SetValuesPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SizeBoxPar;
        private System.Windows.Forms.Button CreateButtonPar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Side2ValueBoxPar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Side1ValueBoxPar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}