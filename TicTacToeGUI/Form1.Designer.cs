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
            NewGameBtn = new Button();
            SuspendLayout();
            // 
            // TopLeftBtn
            // 
            TopLeftBtn.Location = new Point(30, 61);
            TopLeftBtn.Margin = new Padding(2, 1, 2, 1);
            TopLeftBtn.Name = "TopLeftBtn";
            TopLeftBtn.Size = new Size(93, 78);
            TopLeftBtn.TabIndex = 0;
            TopLeftBtn.UseVisualStyleBackColor = true;
            TopLeftBtn.Click += TopLeftBtn_Click;
            // 
            // TopMiddleBtn
            // 
            TopMiddleBtn.Location = new Point(127, 61);
            TopMiddleBtn.Margin = new Padding(2, 1, 2, 1);
            TopMiddleBtn.Name = "TopMiddleBtn";
            TopMiddleBtn.Size = new Size(93, 78);
            TopMiddleBtn.TabIndex = 1;
            TopMiddleBtn.UseVisualStyleBackColor = true;
            TopMiddleBtn.Click += TopMiddleBtn_Click;
            // 
            // TopRightBtn
            // 
            TopRightBtn.Location = new Point(223, 61);
            TopRightBtn.Margin = new Padding(2, 1, 2, 1);
            TopRightBtn.Name = "TopRightBtn";
            TopRightBtn.Size = new Size(93, 78);
            TopRightBtn.TabIndex = 2;
            TopRightBtn.UseVisualStyleBackColor = true;
            TopRightBtn.Click += TopRightBtn_Click;
            // 
            // MiddleLeftBtn
            // 
            MiddleLeftBtn.Location = new Point(30, 142);
            MiddleLeftBtn.Margin = new Padding(2, 1, 2, 1);
            MiddleLeftBtn.Name = "MiddleLeftBtn";
            MiddleLeftBtn.Size = new Size(93, 78);
            MiddleLeftBtn.TabIndex = 3;
            MiddleLeftBtn.UseVisualStyleBackColor = true;
            MiddleLeftBtn.Click += MiddleLeftBtn_Click;
            // 
            // MiddleMiddleBtn
            // 
            MiddleMiddleBtn.Location = new Point(127, 142);
            MiddleMiddleBtn.Margin = new Padding(2, 1, 2, 1);
            MiddleMiddleBtn.Name = "MiddleMiddleBtn";
            MiddleMiddleBtn.Size = new Size(93, 78);
            MiddleMiddleBtn.TabIndex = 4;
            MiddleMiddleBtn.UseVisualStyleBackColor = true;
            MiddleMiddleBtn.Click += MiddleMiddleBtn_Click;
            // 
            // MiddleRightBtn
            // 
            MiddleRightBtn.Location = new Point(223, 142);
            MiddleRightBtn.Margin = new Padding(2, 1, 2, 1);
            MiddleRightBtn.Name = "MiddleRightBtn";
            MiddleRightBtn.Size = new Size(93, 78);
            MiddleRightBtn.TabIndex = 5;
            MiddleRightBtn.UseVisualStyleBackColor = true;
            MiddleRightBtn.Click += MiddleRightBtn_Click;
            // 
            // BottomLeftBtn
            // 
            BottomLeftBtn.Location = new Point(30, 224);
            BottomLeftBtn.Margin = new Padding(2, 1, 2, 1);
            BottomLeftBtn.Name = "BottomLeftBtn";
            BottomLeftBtn.Size = new Size(93, 78);
            BottomLeftBtn.TabIndex = 6;
            BottomLeftBtn.UseVisualStyleBackColor = true;
            BottomLeftBtn.Click += BottomLeftBtn_Click;
            // 
            // BottomMiddleBtn
            // 
            BottomMiddleBtn.Location = new Point(127, 224);
            BottomMiddleBtn.Margin = new Padding(2, 1, 2, 1);
            BottomMiddleBtn.Name = "BottomMiddleBtn";
            BottomMiddleBtn.Size = new Size(93, 78);
            BottomMiddleBtn.TabIndex = 7;
            BottomMiddleBtn.UseVisualStyleBackColor = true;
            BottomMiddleBtn.Click += BottomMiddleBtn_Click;
            // 
            // BottomRightBtn
            // 
            BottomRightBtn.Location = new Point(223, 224);
            BottomRightBtn.Margin = new Padding(2, 1, 2, 1);
            BottomRightBtn.Name = "BottomRightBtn";
            BottomRightBtn.Size = new Size(93, 78);
            BottomRightBtn.TabIndex = 8;
            BottomRightBtn.UseVisualStyleBackColor = true;
            BottomRightBtn.Click += BottomRightBtn_Click;
            // 
            // GameLbl
            // 
            GameLbl.AutoSize = true;
            GameLbl.Location = new Point(176, 37);
            GameLbl.Margin = new Padding(2, 0, 2, 0);
            GameLbl.Name = "GameLbl";
            GameLbl.Size = new Size(0, 15);
            GameLbl.TabIndex = 9;
            GameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // NewGameBtn
            // 
            NewGameBtn.Location = new Point(127, 306);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(93, 43);
            NewGameBtn.TabIndex = 10;
            NewGameBtn.Text = "New Game!";
            NewGameBtn.UseVisualStyleBackColor = true;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 352);
            Controls.Add(NewGameBtn);
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
            Margin = new Padding(2, 1, 2, 1);
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
        private Button NewGameBtn;
    }
}
