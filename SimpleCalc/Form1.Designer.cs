
namespace SimpleCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRest = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonRest, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSum, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonMult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 218);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonRest
            // 
            this.buttonRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRest.Location = new System.Drawing.Point(330, 165);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(106, 50);
            this.buttonRest.TabIndex = 15;
            this.buttonRest.Text = "-";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.Location = new System.Drawing.Point(221, 165);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(103, 50);
            this.buttonEqual.TabIndex = 14;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(112, 165);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(103, 50);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonP
            // 
            this.buttonP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonP.Location = new System.Drawing.Point(3, 165);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(103, 50);
            this.buttonP.TabIndex = 12;
            this.buttonP.Text = ".";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSum.Location = new System.Drawing.Point(330, 111);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(106, 48);
            this.buttonSum.TabIndex = 11;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(221, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 48);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(112, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 48);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 48);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMult.Location = new System.Drawing.Point(330, 57);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(106, 48);
            this.buttonMult.TabIndex = 7;
            this.buttonMult.Text = "X";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(221, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(112, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiv.Location = new System.Drawing.Point(330, 3);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(106, 48);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(221, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(112, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 119);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";

            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

