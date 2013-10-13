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
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.debugCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugCheckBox.Location = new System.Drawing.Point(21, 543);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(98, 19);
            this.debugCheckBox.TabIndex = 4;
            this.debugCheckBox.Text = "Debug Mode";
            this.debugCheckBox.UseVisualStyleBackColor = false;
            this.debugCheckBox.Visible = false;
            this.debugCheckBox.Click += new System.EventHandler(this.debugCheckBox_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(834, 556);
            this.canvas.TabIndex = 5;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // firstSideLabel
            // 
            this.firstSideLabel.AutoSize = true;
            this.firstSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.firstSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.firstSideLabel.Location = new System.Drawing.Point(894, 63);
            this.firstSideLabel.Name = "firstSideLabel";
            this.firstSideLabel.Size = new System.Drawing.Size(110, 55);
            this.firstSideLabel.TabIndex = 6;
            this.firstSideLabel.Text = "A  =";
            // 
            // thirdSideLabel
            // 
            this.thirdSideLabel.AutoSize = true;
            this.thirdSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.thirdSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.thirdSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.thirdSideLabel.Location = new System.Drawing.Point(894, 193);
            this.thirdSideLabel.Name = "thirdSideLabel";
            this.thirdSideLabel.Size = new System.Drawing.Size(113, 55);
            this.thirdSideLabel.TabIndex = 7;
            this.thirdSideLabel.Text = "C  =";
            this.thirdSideLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondSideLabel
            // 
            this.secondSideLabel.AutoSize = true;
            this.secondSideLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondSideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.secondSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSideLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.secondSideLabel.Location = new System.Drawing.Point(894, 128);
            this.secondSideLabel.Name = "secondSideLabel";
            this.secondSideLabel.Size = new System.Drawing.Size(110, 55);
            this.secondSideLabel.TabIndex = 8;
            this.secondSideLabel.Text = "B  =";
            // 
            // firstSideTB
            // 
            this.firstSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.firstSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstSideTB.Enabled = false;
            this.firstSideTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSideTB.Location = new System.Drawing.Point(1010, 74);
            this.firstSideTB.MaxLength = 8;
            this.firstSideTB.Name = "firstSideTB";
            this.firstSideTB.Size = new System.Drawing.Size(154, 31);
            this.firstSideTB.TabIndex = 9;
            this.firstSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // secondSideTB
            // 
            this.secondSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.secondSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondSideTB.Enabled = false;
            this.secondSideTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSideTB.Location = new System.Drawing.Point(1010, 138);
            this.secondSideTB.MaxLength = 8;
            this.secondSideTB.Name = "secondSideTB";
            this.secondSideTB.Size = new System.Drawing.Size(154, 31);
            this.secondSideTB.TabIndex = 10;
            this.secondSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // thirdSideTB
            // 
            this.thirdSideTB.BackColor = System.Drawing.SystemColors.Menu;
            this.thirdSideTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdSideTB.Enabled = false;
            this.thirdSideTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdSideTB.Location = new System.Drawing.Point(1010, 204);
            this.thirdSideTB.MaxLength = 8;
            this.thirdSideTB.Name = "thirdSideTB";
            this.thirdSideTB.Size = new System.Drawing.Size(154, 31);
            this.thirdSideTB.TabIndex = 11;
            this.thirdSideTB.TextChanged += new System.EventHandler(this.anySideTB_TextChanged);
            // 
            // eqTriangleLabel
            // 
            this.eqTriangleLabel.AutoSize = true;
            this.eqTriangleLabel.BackColor = System.Drawing.Color.Transparent;
            this.eqTriangleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.eqTriangleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eqTriangleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eqTriangleLabel.Location = new System.Drawing.Point(900, 328);
            this.eqTriangleLabel.Name = "eqTriangleLabel";
            this.eqTriangleLabel.Size = new System.Drawing.Size(162, 24);
            this.eqTriangleLabel.TabIndex = 12;
            this.eqTriangleLabel.Text = "equilateral triangle";
            // 
            // recTriangleLabel
            // 
            this.recTriangleLabel.AutoSize = true;
            this.recTriangleLabel.BackColor = System.Drawing.Color.Transparent;
            this.recTriangleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.recTriangleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recTriangleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recTriangleLabel.Location = new System.Drawing.Point(900, 382);
            this.recTriangleLabel.Name = "recTriangleLabel";
            this.recTriangleLabel.Size = new System.Drawing.Size(170, 24);
            this.recTriangleLabel.TabIndex = 13;
            this.recTriangleLabel.Text = "rectangular triangle";
            // 
            // eqCheck
            // 
            this.eqCheck.BackColor = System.Drawing.Color.Transparent;
            this.eqCheck.Image = ((System.Drawing.Image)(resources.GetObject("eqCheck.Image")));
            this.eqCheck.Location = new System.Drawing.Point(1102, 328);
            this.eqCheck.Name = "eqCheck";
            this.eqCheck.Size = new System.Drawing.Size(31, 29);
            this.eqCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eqCheck.TabIndex = 14;
            this.eqCheck.TabStop = false;
            this.eqCheck.Visible = false;
            // 
            // recCheck
            // 
            this.recCheck.BackColor = System.Drawing.Color.Transparent;
            this.recCheck.Image = ((System.Drawing.Image)(resources.GetObject("recCheck.Image")));
            this.recCheck.Location = new System.Drawing.Point(1102, 377);
            this.recCheck.Name = "recCheck";
            this.recCheck.Size = new System.Drawing.Size(31, 29);
            this.recCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recCheck.TabIndex = 15;
            this.recCheck.TabStop = false;
            this.recCheck.Visible = false;
            // 
            // pointCheck
            // 
            this.pointCheck.BackColor = System.Drawing.Color.Transparent;
            this.pointCheck.Image = ((System.Drawing.Image)(resources.GetObject("pointCheck.Image")));
            this.pointCheck.Location = new System.Drawing.Point(1102, 425);
            this.pointCheck.Name = "pointCheck";
            this.pointCheck.Size = new System.Drawing.Size(31, 29);
            this.pointCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointCheck.TabIndex = 17;
            this.pointCheck.TabStop = false;
            this.pointCheck.Visible = false;
            // 
            // pointInsideLabel
            // 
            this.pointInsideLabel.AutoSize = true;
            this.pointInsideLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointInsideLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.pointInsideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointInsideLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointInsideLabel.Location = new System.Drawing.Point(900, 430);
            this.pointInsideLabel.Name = "pointInsideLabel";
            this.pointInsideLabel.Size = new System.Drawing.Size(106, 24);
            this.pointInsideLabel.TabIndex = 16;
            this.pointInsideLabel.Text = "point inside";
            // 
            // switchPB0
            // 
            this.switchPB0.BackColor = System.Drawing.Color.Transparent;
            this.switchPB0.Image = global::GeometryForm.Properties.Resources._0;
            this.switchPB0.Location = new System.Drawing.Point(965, 488);
            this.switchPB0.Name = "switchPB0";
            this.switchPB0.Size = new System.Drawing.Size(102, 44);
            this.switchPB0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchPB0.TabIndex = 18;
            this.switchPB0.TabStop = false;
            this.switchPB0.Visible = false;
            this.switchPB0.Click += new System.EventHandler(this.switchPB_Click);
            // 
            // switchPB1
            // 
            this.switchPB1.BackColor = System.Drawing.Color.Transparent;
            this.switchPB1.Image = global::GeometryForm.Properties.Resources._1;
            this.switchPB1.Location = new System.Drawing.Point(965, 488);
            this.switchPB1.Name = "switchPB1";
            this.switchPB1.Size = new System.Drawing.Size(102, 44);
            this.switchPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchPB1.TabIndex = 19;
            this.switchPB1.TabStop = false;
            this.switchPB1.Click += new System.EventHandler(this.switchPB_Click);
            // 
            // drawModeLabel
            // 
            this.drawModeLabel.AutoSize = true;
            this.drawModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawModeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawModeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.drawModeLabel.Location = new System.Drawing.Point(947, 533);
            this.drawModeLabel.Name = "drawModeLabel";
            this.drawModeLabel.Size = new System.Drawing.Size(134, 29);
            this.drawModeLabel.TabIndex = 20;
            this.drawModeLabel.Text = "draw mode";
            this.drawModeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(895, 423);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(259, 42);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeometryForm.Properties.Resources.picture10051;
            this.ClientSize = new System.Drawing.Size(1183, 580);
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
            this.Text = "Triangle Geometry";
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

