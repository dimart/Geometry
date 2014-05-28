namespace GeometryForm
{
    partial class Desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desk));
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.firstSideLabel = new System.Windows.Forms.Label();
            this.thirdSideLabel = new System.Windows.Forms.Label();
            this.secondSideLabel = new System.Windows.Forms.Label();
            this.firstSideTB = new System.Windows.Forms.TextBox();
            this.secondSideTB = new System.Windows.Forms.TextBox();
            this.thirdSideTB = new System.Windows.Forms.TextBox();
            this.eqTriangleLabel = new System.Windows.Forms.Label();
            this.recTriangleLabel = new System.Windows.Forms.Label();
            this.eqCheck = new System.Windows.Forms.PictureBox();
            this.recCheck = new System.Windows.Forms.PictureBox();
            this.pointCheck = new System.Windows.Forms.PictureBox();
            this.pointInsideLabel = new System.Windows.Forms.Label();
            this.switchPB0 = new System.Windows.Forms.PictureBox();
            this.switchPB1 = new System.Windows.Forms.PictureBox();
            this.drawModeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchPB0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // debugCheckBox
            // 
            resources.ApplyResources(this.debugCheckBox, "debugCheckBox");
            this.debugCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.UseVisualStyleBackColor = false;
            this.debugCheckBox.Click += new System.EventHandler(this.debugCheckBox_Click);
            // 
            // canvas
            // 
            resources.ApplyResources(this.canvas, "canvas");
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Name = "canvas";
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // firstSideLabel
            // 
            resources.ApplyResources(this.firstSideLabel, "firstSideLabel");
            this.firstSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.firstSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.firstSideLabel.Name = "firstSideLabel";
            // 
            // thirdSideLabel
            // 
            resources.ApplyResources(this.thirdSideLabel, "thirdSideLabel");
            this.thirdSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.thirdSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.thirdSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.thirdSideLabel.Name = "thirdSideLabel";
            // 
            // secondSideLabel
            // 
            resources.ApplyResources(this.secondSideLabel, "secondSideLabel");
            this.secondSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.secondSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.secondSideLabel.Name = "secondSideLabel";
            // 
            // firstSideTB
            // 
            resources.ApplyResources(this.firstSideTB, "firstSideTB");
            this.firstSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.firstSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstSideTB.Name = "firstSideTB";
            this.firstSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // secondSideTB
            // 
            resources.ApplyResources(this.secondSideTB, "secondSideTB");
            this.secondSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.secondSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondSideTB.Name = "secondSideTB";
            this.secondSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // thirdSideTB
            // 
            resources.ApplyResources(this.thirdSideTB, "thirdSideTB");
            this.thirdSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.thirdSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdSideTB.Name = "thirdSideTB";
            this.thirdSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // eqTriangleLabel
            // 
            resources.ApplyResources(this.eqTriangleLabel, "eqTriangleLabel");
            this.eqTriangleLabel.BackColor = System.Drawing.Color.Transparent;
            this.eqTriangleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.eqTriangleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eqTriangleLabel.Name = "eqTriangleLabel";
            // 
            // recTriangleLabel
            // 
            resources.ApplyResources(this.recTriangleLabel, "recTriangleLabel");
            this.recTriangleLabel.BackColor = System.Drawing.Color.Transparent;
            this.recTriangleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.recTriangleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recTriangleLabel.Name = "recTriangleLabel";
            // 
            // eqCheck
            // 
            resources.ApplyResources(this.eqCheck, "eqCheck");
            this.eqCheck.BackColor = System.Drawing.Color.Transparent;
            this.eqCheck.Name = "eqCheck";
            this.eqCheck.TabStop = false;
            // 
            // recCheck
            // 
            resources.ApplyResources(this.recCheck, "recCheck");
            this.recCheck.BackColor = System.Drawing.Color.Transparent;
            this.recCheck.Name = "recCheck";
            this.recCheck.TabStop = false;
            // 
            // pointCheck
            // 
            resources.ApplyResources(this.pointCheck, "pointCheck");
            this.pointCheck.BackColor = System.Drawing.Color.Transparent;
            this.pointCheck.Name = "pointCheck";
            this.pointCheck.TabStop = false;
            // 
            // pointInsideLabel
            // 
            resources.ApplyResources(this.pointInsideLabel, "pointInsideLabel");
            this.pointInsideLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointInsideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.pointInsideLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointInsideLabel.Name = "pointInsideLabel";
            // 
            // switchPB0
            // 
            resources.ApplyResources(this.switchPB0, "switchPB0");
            this.switchPB0.BackColor = System.Drawing.Color.Transparent;
            this.switchPB0.Image = global::GeometryForm.Properties.Resources._0;
            this.switchPB0.Name = "switchPB0";
            this.switchPB0.TabStop = false;
            this.switchPB0.Click += new System.EventHandler(this.switchPB_Click);
            // 
            // switchPB1
            // 
            resources.ApplyResources(this.switchPB1, "switchPB1");
            this.switchPB1.BackColor = System.Drawing.Color.Transparent;
            this.switchPB1.Image = global::GeometryForm.Properties.Resources._1;
            this.switchPB1.Name = "switchPB1";
            this.switchPB1.TabStop = false;
            this.switchPB1.Click += new System.EventHandler(this.switchPB_Click);
            // 
            // drawModeLabel
            // 
            resources.ApplyResources(this.drawModeLabel, "drawModeLabel");
            this.drawModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawModeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawModeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.drawModeLabel.Name = "drawModeLabel";
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Desk
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeometryForm.Properties.Resources.picture10051;
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drawModeLabel);
            this.Controls.Add(this.pointCheck);
            this.Controls.Add(this.recCheck);
            this.Controls.Add(this.eqCheck);
            this.Controls.Add(this.recTriangleLabel);
            this.Controls.Add(this.eqTriangleLabel);
            this.Controls.Add(this.thirdSideTB);
            this.Controls.Add(this.secondSideTB);
            this.Controls.Add(this.firstSideTB);
            this.Controls.Add(this.secondSideLabel);
            this.Controls.Add(this.thirdSideLabel);
            this.Controls.Add(this.firstSideLabel);
            this.Controls.Add(this.debugCheckBox);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.switchPB1);
            this.Controls.Add(this.switchPB0);
            this.Controls.Add(this.pointInsideLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Desk_FormClosed);
            this.Load += new System.EventHandler(this.Desk_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Desk_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchPB0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchPB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label firstSideLabel;
        private System.Windows.Forms.Label thirdSideLabel;
        private System.Windows.Forms.Label secondSideLabel;
        private System.Windows.Forms.TextBox firstSideTB;
        private System.Windows.Forms.TextBox secondSideTB;
        private System.Windows.Forms.TextBox thirdSideTB;
        private System.Windows.Forms.Label eqTriangleLabel;
        private System.Windows.Forms.Label recTriangleLabel;
        private System.Windows.Forms.PictureBox eqCheck;
        private System.Windows.Forms.PictureBox recCheck;
        private System.Windows.Forms.PictureBox pointCheck;
        private System.Windows.Forms.Label pointInsideLabel;
        private System.Windows.Forms.PictureBox switchPB0;
        private System.Windows.Forms.PictureBox switchPB1;
        private System.Windows.Forms.Label drawModeLabel;
        private System.Windows.Forms.Button calculateButton;


    }
}

