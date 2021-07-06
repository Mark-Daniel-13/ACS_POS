
namespace NTT_POS.Helpers.HelperForms
{
    partial class LoadingScreen
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
            this.pbCircle = new CircularProgressBar.CircularProgressBar();
            this.lblWait = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStats = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCircle
            // 
            this.pbCircle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbCircle.AnimationSpeed = 500;
            this.pbCircle.BackColor = System.Drawing.Color.Transparent;
            this.pbCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCircle.Font = new System.Drawing.Font("Open Sans Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.pbCircle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.pbCircle.InnerMargin = 2;
            this.pbCircle.InnerWidth = -1;
            this.pbCircle.Location = new System.Drawing.Point(3, 3);
            this.pbCircle.MarqueeAnimationSpeed = 2000;
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.OuterColor = System.Drawing.Color.White;
            this.pbCircle.OuterMargin = -25;
            this.pbCircle.OuterWidth = 26;
            this.pbCircle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.pbCircle.ProgressWidth = 16;
            this.pbCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbCircle.Size = new System.Drawing.Size(443, 445);
            this.pbCircle.StartAngle = 270;
            this.pbCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbCircle.SubscriptText = "";
            this.pbCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbCircle.SuperscriptText = "";
            this.pbCircle.TabIndex = 0;
            this.pbCircle.Text = "10%";
            this.pbCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbCircle.Value = 68;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWait.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.lblWait.Location = new System.Drawing.Point(3, 451);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(443, 56);
            this.lblWait.TabIndex = 1;
            this.lblWait.Text = "Loading... Please Wait...";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblStats, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbCircle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWait, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 564);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStats.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.lblStats.Location = new System.Drawing.Point(3, 507);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(443, 57);
            this.lblStats.TabIndex = 2;
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 564);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStats;
        public CircularProgressBar.CircularProgressBar pbCircle;
    }
}