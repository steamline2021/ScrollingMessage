
namespace ScrollingMessage
{
    partial class EquityDisplay
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
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddSymbol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemoveSymbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ICE:136";
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(248, 263);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.PlaceholderText = "symbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(100, 23);
            this.textBoxSymbol.TabIndex = 1;
            this.textBoxSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSymbol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSymbol_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Equity Symbol To Add";
            // 
            // buttonAddSymbol
            // 
            this.buttonAddSymbol.Location = new System.Drawing.Point(248, 308);
            this.buttonAddSymbol.Name = "buttonAddSymbol";
            this.buttonAddSymbol.Size = new System.Drawing.Size(159, 34);
            this.buttonAddSymbol.TabIndex = 3;
            this.buttonAddSymbol.Text = "Add Symbol";
            this.buttonAddSymbol.UseVisualStyleBackColor = true;
            this.buttonAddSymbol.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop Engine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Start Engine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(364, 263);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PlaceholderText = "price";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 229);
            this.listBox1.TabIndex = 7;
            // 
            // buttonRemoveSymbol
            // 
            this.buttonRemoveSymbol.Location = new System.Drawing.Point(248, 115);
            this.buttonRemoveSymbol.Name = "buttonRemoveSymbol";
            this.buttonRemoveSymbol.Size = new System.Drawing.Size(159, 34);
            this.buttonRemoveSymbol.TabIndex = 4;
            this.buttonRemoveSymbol.Text = "Remove Symbol";
            this.buttonRemoveSymbol.UseVisualStyleBackColor = true;
            this.buttonRemoveSymbol.Click += new System.EventHandler(this.button4_Click);
            // 
            // EquityDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 354);
            this.Controls.Add(this.buttonRemoveSymbol);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddSymbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.label1);
            this.Name = "EquityDisplay";
            this.Text = "Equity Display Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddSymbol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRemoveSymbol;
    }
}

