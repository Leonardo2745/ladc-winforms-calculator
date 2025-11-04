namespace Exemplo
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
            inputTextX = new TextBox();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextY = new TextBox();
            labelX = new Label();
            labelY = new Label();
            labelTitleResult = new Label();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnQuad = new Button();
            btnRaiz = new Button();
            btnMod = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(85, 106);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(118, 31);
            inputTextX.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(16, 18);
            labelTitle.MaximumSize = new Size(180, 65);
            labelTitle.MinimumSize = new Size(180, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(180, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            // 
            // labelOutput
            // 
            labelOutput.AllowDrop = true;
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(388, 62);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(85, 167);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(118, 31);
            inputTextY.TabIndex = 2;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelX.ForeColor = Color.Coral;
            labelX.Location = new Point(31, 93);
            labelX.Name = "labelX";
            labelX.Size = new Size(50, 45);
            labelX.TabIndex = 5;
            labelX.Text = "X:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelY.ForeColor = Color.Coral;
            labelY.Location = new Point(31, 154);
            labelY.Name = "labelY";
            labelY.Size = new Size(48, 45);
            labelY.TabIndex = 6;
            labelY.Text = "Y:";
            // 
            // labelTitleResult
            // 
            labelTitleResult.AutoSize = true;
            labelTitleResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitleResult.ForeColor = Color.Coral;
            labelTitleResult.Location = new Point(536, 9);
            labelTitleResult.Name = "labelTitleResult";
            labelTitleResult.Size = new Size(111, 45);
            labelTitleResult.TabIndex = 7;
            labelTitleResult.Text = "Result";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(31, 249);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(50, 52);
            btnSoma.TabIndex = 8;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(102, 249);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(50, 52);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(175, 249);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(50, 52);
            btnMult.TabIndex = 10;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(31, 319);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 53);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnQuad
            // 
            btnQuad.Location = new Point(102, 319);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(50, 53);
            btnQuad.TabIndex = 12;
            btnQuad.Text = "x²";
            btnQuad.UseVisualStyleBackColor = true;
            btnQuad.Click += btnQuad_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(175, 319);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(50, 53);
            btnRaiz.TabIndex = 13;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(31, 388);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(50, 50);
            btnMod.TabIndex = 14;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnPorc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(btnMod);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuad);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(labelTitleResult);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextX;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextY;
        private Label labelX;
        private Label labelY;
        private Label labelTitleResult;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnQuad;
        private Button btnRaiz;
        private Button btnMod;
    }
}
