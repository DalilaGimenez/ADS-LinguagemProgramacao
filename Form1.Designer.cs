
namespace Prova01_Dalila_Gimenez
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escolha a operação desejada:";
            // 
            // txtresultado
            // 
            this.txtresultado.AutoSize = true;
            this.txtresultado.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtresultado.Location = new System.Drawing.Point(428, 349);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(127, 32);
            this.txtresultado.TabIndex = 3;
            this.txtresultado.Text = "Resultado:";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1.Location = new System.Drawing.Point(156, 50);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(209, 29);
            this.num1.TabIndex = 4;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2.Location = new System.Drawing.Point(156, 98);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(209, 29);
            this.num2.TabIndex = 5;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soma
            // 
            this.soma.AutoSize = true;
            this.soma.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.soma.Location = new System.Drawing.Point(381, 160);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(88, 33);
            this.soma.TabIndex = 7;
            this.soma.TabStop = true;
            this.soma.Text = "soma";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.CheckedChanged += new System.EventHandler(this.soma_CheckedChanged);
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.sub.Location = new System.Drawing.Point(381, 202);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(135, 33);
            this.sub.TabIndex = 8;
            this.sub.TabStop = true;
            this.sub.Text = "subtração";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.CheckedChanged += new System.EventHandler(this.sub_CheckedChanged);
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(381, 241);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(103, 33);
            this.div.TabIndex = 9;
            this.div.TabStop = true;
            this.div.Text = "divisão";
            this.div.UseVisualStyleBackColor = true;
            this.div.CheckedChanged += new System.EventHandler(this.div_CheckedChanged);
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.mult.Location = new System.Drawing.Point(381, 283);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(166, 33);
            this.mult.TabIndex = 10;
            this.mult.TabStop = true;
            this.mult.Text = "multiplicação";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.CheckedChanged += new System.EventHandler(this.mult_CheckedChanged);
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtresult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtresult.Location = new System.Drawing.Point(561, 346);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(166, 39);
            this.txtresult.TabIndex = 11;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prova01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtresultado;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.RadioButton soma;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.TextBox txtresult;
    }
}

