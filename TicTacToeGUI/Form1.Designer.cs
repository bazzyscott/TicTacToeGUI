namespace TicTacToeGUI
{
    partial class Board
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
            TopLeftBtn = new Button();
            TopMiddleBtn = new Button();
            TopRightBtn = new Button();
            MiddleLeftBtn = new Button();
            MiddleMiddleBtn = new Button();
            MiddleRightBtn = new Button();
            BottomLeftBtn = new Button();
            BottomMiddleBtn = new Button();
            BottomRightBtn = new Button();
            GameLbl = new Label();
            SuspendLayout();
            // 
            // TopLeftBtn
            // 
            TopLeftBtn.Location = new Point(56, 131);
            TopLeftBtn.Name = "TopLeftBtn";
            TopLeftBtn.Size = new Size(173, 167);
            TopLeftBtn.TabIndex = 0;
            TopLeftBtn.UseVisualStyleBackColor = true;
            TopLeftBtn.Click += TopLeftBtn_Click;
            // 
            // TopMiddleBtn
            // 
            TopMiddleBtn.Location = new Point(235, 131);
            TopMiddleBtn.Name = "TopMiddleBtn";
            TopMiddleBtn.Size = new Size(173, 167);
            TopMiddleBtn.TabIndex = 1;
            TopMiddleBtn.UseVisualStyleBackColor = true;
            TopMiddleBtn.Click += TopMiddleBtn_Click;
            // 
            // TopRightBtn
            // 
            TopRightBtn.Location = new Point(414, 131);
            TopRightBtn.Name = "TopRightBtn";
            TopRightBtn.Size = new Size(173, 167);
            TopRightBtn.TabIndex = 2;
            TopRightBtn.UseVisualStyleBackColor = true;
            TopRightBtn.Click += TopRightBtn_Click;
            // 
            // MiddleLeftBtn
            // 
            MiddleLeftBtn.Location = new Point(56, 304);
            MiddleLeftBtn.Name = "MiddleLeftBtn";
            MiddleLeftBtn.Size = new Size(173, 167);
            MiddleLeftBtn.TabIndex = 3;
            MiddleLeftBtn.UseVisualStyleBackColor = true;
            MiddleLeftBtn.Click += MiddleLeftBtn_Click;
            // 
            // MiddleMiddleBtn
            // 
            MiddleMiddleBtn.Location = new Point(235, 304);
            MiddleMiddleBtn.Name = "MiddleMiddleBtn";
            MiddleMiddleBtn.Size = new Size(173, 167);
            MiddleMiddleBtn.TabIndex = 4;
            MiddleMiddleBtn.UseVisualStyleBackColor = true;
            MiddleMiddleBtn.Click += MiddleMiddleBtn_Click;
            // 
            // MiddleRightBtn
            // 
            MiddleRightBtn.Location = new Point(414, 304);
            MiddleRightBtn.Name = "MiddleRightBtn";
            MiddleRightBtn.Size = new Size(173, 167);
            MiddleRightBtn.TabIndex = 5;
            MiddleRightBtn.UseVisualStyleBackColor = true;
            MiddleRightBtn.Click += MiddleRightBtn_Click;
            // 
            // BottomLeftBtn
            // 
            BottomLeftBtn.Location = new Point(56, 477);
            BottomLeftBtn.Name = "BottomLeftBtn";
            BottomLeftBtn.Size = new Size(173, 167);
            BottomLeftBtn.TabIndex = 6;
            BottomLeftBtn.UseVisualStyleBackColor = true;
            BottomLeftBtn.Click += BottomLeftBtn_Click;
            // 
            // BottomMiddleBtn
            // 
            BottomMiddleBtn.Location = new Point(235, 477);
            BottomMiddleBtn.Name = "BottomMiddleBtn";
            BottomMiddleBtn.Size = new Size(173, 167);
            BottomMiddleBtn.TabIndex = 7;
            BottomMiddleBtn.UseVisualStyleBackColor = true;
            BottomMiddleBtn.Click += BottomMiddleBtn_Click;
            // 
            // BottomRightBtn
            // 
            BottomRightBtn.Location = new Point(414, 477);
            BottomRightBtn.Name = "BottomRightBtn";
            BottomRightBtn.Size = new Size(173, 167);
            BottomRightBtn.TabIndex = 8;
            BottomRightBtn.UseVisualStyleBackColor = true;
            BottomRightBtn.Click += BottomRightBtn_Click;
            // 
            // GameLbl
            // 
            GameLbl.AutoSize = true;
            GameLbl.Location = new Point(326, 78);
            GameLbl.Name = "GameLbl";
            GameLbl.Size = new Size(0, 32);
            GameLbl.TabIndex = 9;
            GameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 751);
            Controls.Add(GameLbl);
            Controls.Add(BottomRightBtn);
            Controls.Add(BottomMiddleBtn);
            Controls.Add(BottomLeftBtn);
            Controls.Add(MiddleRightBtn);
            Controls.Add(MiddleMiddleBtn);
            Controls.Add(MiddleLeftBtn);
            Controls.Add(TopRightBtn);
            Controls.Add(TopMiddleBtn);
            Controls.Add(TopLeftBtn);
            Name = "Board";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TopLeftBtn;
        private Button TopMiddleBtn;
        private Button TopRightBtn;
        private Button MiddleMiddleBtn;
        private Button MiddleRightBtn;
        private Button BottomLeftBtn;
        private Button BottomMiddleBtn;
        private Button BottomRightBtn;
        private Label GameLbl;
        private Button MiddleLeftBtn;
    }
}
