namespace CalculatorApp
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.backSpaceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(176, 669);
            this.zeroButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Padding = new System.Windows.Forms.Padding(1);
            this.zeroButton.Size = new System.Drawing.Size(158, 114);
            this.zeroButton.TabIndex = 0;
            this.zeroButton.TabStop = false;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(340, 669);
            this.decimalButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Padding = new System.Windows.Forms.Padding(1);
            this.decimalButton.Size = new System.Drawing.Size(158, 114);
            this.decimalButton.TabIndex = 1;
            this.decimalButton.TabStop = false;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeButton.Location = new System.Drawing.Point(12, 669);
            this.negativeButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Padding = new System.Windows.Forms.Padding(1);
            this.negativeButton.Size = new System.Drawing.Size(158, 114);
            this.negativeButton.TabIndex = 2;
            this.negativeButton.TabStop = false;
            this.negativeButton.Text = "+/-";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.equalButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(504, 669);
            this.equalButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.equalButton.Name = "equalButton";
            this.equalButton.Padding = new System.Windows.Forms.Padding(1);
            this.equalButton.Size = new System.Drawing.Size(158, 114);
            this.equalButton.TabIndex = 3;
            this.equalButton.TabStop = false;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.Info;
            this.divideButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(504, 309);
            this.divideButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.divideButton.Name = "divideButton";
            this.divideButton.Padding = new System.Windows.Forms.Padding(1);
            this.divideButton.Size = new System.Drawing.Size(158, 114);
            this.divideButton.TabIndex = 7;
            this.divideButton.TabStop = false;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divieButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(12, 309);
            this.sevenButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Padding = new System.Windows.Forms.Padding(1);
            this.sevenButton.Size = new System.Drawing.Size(158, 114);
            this.sevenButton.TabIndex = 6;
            this.sevenButton.TabStop = false;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(340, 309);
            this.nineButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.nineButton.Name = "nineButton";
            this.nineButton.Padding = new System.Windows.Forms.Padding(1);
            this.nineButton.Size = new System.Drawing.Size(158, 114);
            this.nineButton.TabIndex = 5;
            this.nineButton.TabStop = false;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(176, 309);
            this.eightButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.eightButton.Name = "eightButton";
            this.eightButton.Padding = new System.Windows.Forms.Padding(1);
            this.eightButton.Size = new System.Drawing.Size(158, 114);
            this.eightButton.TabIndex = 4;
            this.eightButton.TabStop = false;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.Info;
            this.plusButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(504, 549);
            this.plusButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.plusButton.Name = "plusButton";
            this.plusButton.Padding = new System.Windows.Forms.Padding(1);
            this.plusButton.Size = new System.Drawing.Size(158, 114);
            this.plusButton.TabIndex = 11;
            this.plusButton.TabStop = false;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 549);
            this.oneButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.oneButton.Name = "oneButton";
            this.oneButton.Padding = new System.Windows.Forms.Padding(1);
            this.oneButton.Size = new System.Drawing.Size(158, 114);
            this.oneButton.TabIndex = 10;
            this.oneButton.TabStop = false;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(340, 549);
            this.threeButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.threeButton.Name = "threeButton";
            this.threeButton.Padding = new System.Windows.Forms.Padding(1);
            this.threeButton.Size = new System.Drawing.Size(158, 114);
            this.threeButton.TabIndex = 9;
            this.threeButton.TabStop = false;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(176, 549);
            this.twoButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.twoButton.Name = "twoButton";
            this.twoButton.Padding = new System.Windows.Forms.Padding(1);
            this.twoButton.Size = new System.Drawing.Size(158, 114);
            this.twoButton.TabIndex = 8;
            this.twoButton.TabStop = false;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.Info;
            this.minusButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(504, 429);
            this.minusButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.minusButton.Name = "minusButton";
            this.minusButton.Padding = new System.Windows.Forms.Padding(1);
            this.minusButton.Size = new System.Drawing.Size(158, 114);
            this.minusButton.TabIndex = 15;
            this.minusButton.TabStop = false;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 429);
            this.fourButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.fourButton.Name = "fourButton";
            this.fourButton.Padding = new System.Windows.Forms.Padding(1);
            this.fourButton.Size = new System.Drawing.Size(158, 114);
            this.fourButton.TabIndex = 14;
            this.fourButton.TabStop = false;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(340, 429);
            this.sixButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.sixButton.Name = "sixButton";
            this.sixButton.Padding = new System.Windows.Forms.Padding(1);
            this.sixButton.Size = new System.Drawing.Size(158, 114);
            this.sixButton.TabIndex = 13;
            this.sixButton.TabStop = false;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(176, 429);
            this.fiveButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Padding = new System.Windows.Forms.Padding(1);
            this.fiveButton.Size = new System.Drawing.Size(158, 114);
            this.fiveButton.TabIndex = 12;
            this.fiveButton.TabStop = false;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.Info;
            this.multiplyButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(504, 189);
            this.multiplyButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Padding = new System.Windows.Forms.Padding(1);
            this.multiplyButton.Size = new System.Drawing.Size(158, 114);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.TabStop = false;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.SystemColors.Info;
            this.sqrtButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.Location = new System.Drawing.Point(12, 189);
            this.sqrtButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Padding = new System.Windows.Forms.Padding(1);
            this.sqrtButton.Size = new System.Drawing.Size(158, 114);
            this.sqrtButton.TabIndex = 18;
            this.sqrtButton.TabStop = false;
            this.sqrtButton.Text = "√x";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // backSpaceButton
            // 
            this.backSpaceButton.BackColor = System.Drawing.SystemColors.Info;
            this.backSpaceButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpaceButton.Location = new System.Drawing.Point(340, 189);
            this.backSpaceButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.backSpaceButton.Name = "backSpaceButton";
            this.backSpaceButton.Padding = new System.Windows.Forms.Padding(1);
            this.backSpaceButton.Size = new System.Drawing.Size(158, 114);
            this.backSpaceButton.TabIndex = 17;
            this.backSpaceButton.TabStop = false;
            this.backSpaceButton.Text = "←";
            this.backSpaceButton.UseVisualStyleBackColor = false;
            this.backSpaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Info;
            this.clearButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(176, 189);
            this.clearButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(1);
            this.clearButton.Size = new System.Drawing.Size(158, 114);
            this.clearButton.TabIndex = 16;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.Black;
            this.displayLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.ForeColor = System.Drawing.Color.White;
            this.displayLabel.Location = new System.Drawing.Point(12, 94);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.displayLabel.MinimumSize = new System.Drawing.Size(648, 85);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(648, 85);
            this.displayLabel.TabIndex = 20;
            this.displayLabel.Text = "0";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historyLabel
            // 
            this.historyLabel.BackColor = System.Drawing.Color.Black;
            this.historyLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.ForeColor = System.Drawing.Color.White;
            this.historyLabel.Location = new System.Drawing.Point(12, 18);
            this.historyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.historyLabel.MinimumSize = new System.Drawing.Size(648, 85);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(648, 85);
            this.historyLabel.TabIndex = 21;
            this.historyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AcceptButton = this.equalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 795);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.backSpaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(688, 834);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
            this.Resize += new System.EventHandler(this.Calculator_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button backSpaceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label historyLabel;
    }
}

