namespace TileEnemies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUnitMovP = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblCursorY = new System.Windows.Forms.Label();
            this.lblCursorX = new System.Windows.Forms.Label();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyTurn = new System.Windows.Forms.Timer(this.components);
            this.btnStartEnemyTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnitMovP
            // 
            this.lblUnitMovP.AutoSize = true;
            this.lblUnitMovP.Location = new System.Drawing.Point(12, 972);
            this.lblUnitMovP.Name = "lblUnitMovP";
            this.lblUnitMovP.Size = new System.Drawing.Size(35, 13);
            this.lblUnitMovP.TabIndex = 10;
            this.lblUnitMovP.Text = "label1";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(12, 959);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(35, 13);
            this.lblSelected.TabIndex = 9;
            this.lblSelected.Text = "label1";
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Location = new System.Drawing.Point(12, 946);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(35, 13);
            this.lblTile.TabIndex = 8;
            this.lblTile.Text = "label1";
            // 
            // lblCursorY
            // 
            this.lblCursorY.AutoSize = true;
            this.lblCursorY.Location = new System.Drawing.Point(12, 933);
            this.lblCursorY.Name = "lblCursorY";
            this.lblCursorY.Size = new System.Drawing.Size(35, 13);
            this.lblCursorY.TabIndex = 7;
            this.lblCursorY.Text = "label1";
            // 
            // lblCursorX
            // 
            this.lblCursorX.AutoSize = true;
            this.lblCursorX.Location = new System.Drawing.Point(12, 920);
            this.lblCursorX.Name = "lblCursorX";
            this.lblCursorX.Size = new System.Drawing.Size(35, 13);
            this.lblCursorX.TabIndex = 6;
            this.lblCursorX.Text = "label1";
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Interval = 1;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Enabled = true;
            this.tmrAnimation.Interval = 1;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // tmrEnemyTurn
            // 
            this.tmrEnemyTurn.Interval = 1;
            this.tmrEnemyTurn.Tick += new System.EventHandler(this.tmrEnemyTurn_Tick);
            // 
            // btnStartEnemyTurn
            // 
            this.btnStartEnemyTurn.Location = new System.Drawing.Point(1508, 908);
            this.btnStartEnemyTurn.Name = "btnStartEnemyTurn";
            this.btnStartEnemyTurn.Size = new System.Drawing.Size(80, 80);
            this.btnStartEnemyTurn.TabIndex = 11;
            this.btnStartEnemyTurn.Text = "button1";
            this.btnStartEnemyTurn.UseVisualStyleBackColor = true;
            this.btnStartEnemyTurn.Click += new System.EventHandler(this.btnStartEnemyTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.btnStartEnemyTurn);
            this.Controls.Add(this.lblUnitMovP);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.lblCursorY);
            this.Controls.Add(this.lblCursorX);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1616, 1039);
            this.MinimumSize = new System.Drawing.Size(1616, 1039);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitMovP;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblCursorY;
        private System.Windows.Forms.Label lblCursorX;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer tmrEnemyTurn;
        private System.Windows.Forms.Button btnStartEnemyTurn;
    }
}

