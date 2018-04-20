namespace DBProject
{
    partial class AssignPatrolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignPatrolForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PatrolscomboBox1 = new System.Windows.Forms.ComboBox();
            this.MoveNextbutton1 = new System.Windows.Forms.Button();
            this.MappictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedP1pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedP2pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RedP3pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MappictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP1pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP2pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP3pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Patrol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "All patrols in the specified Location and shift: ";
            // 
            // PatrolscomboBox1
            // 
            this.PatrolscomboBox1.FormattingEnabled = true;
            this.PatrolscomboBox1.Location = new System.Drawing.Point(295, 129);
            this.PatrolscomboBox1.Name = "PatrolscomboBox1";
            this.PatrolscomboBox1.Size = new System.Drawing.Size(121, 21);
            this.PatrolscomboBox1.TabIndex = 2;
            this.PatrolscomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MoveNextbutton1
            // 
            this.MoveNextbutton1.Location = new System.Drawing.Point(341, 329);
            this.MoveNextbutton1.Name = "MoveNextbutton1";
            this.MoveNextbutton1.Size = new System.Drawing.Size(145, 23);
            this.MoveNextbutton1.TabIndex = 3;
            this.MoveNextbutton1.Text = "Go To Track Patrol";
            this.MoveNextbutton1.UseVisualStyleBackColor = true;
            this.MoveNextbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MappictureBox1
            // 
            this.MappictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("MappictureBox1.Image")));
            this.MappictureBox1.Location = new System.Drawing.Point(534, 24);
            this.MappictureBox1.Name = "MappictureBox1";
            this.MappictureBox1.Size = new System.Drawing.Size(443, 384);
            this.MappictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MappictureBox1.TabIndex = 4;
            this.MappictureBox1.TabStop = false;
            // 
            // RedP1pictureBox1
            // 
            this.RedP1pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("RedP1pictureBox1.Image")));
            this.RedP1pictureBox1.Location = new System.Drawing.Point(701, 129);
            this.RedP1pictureBox1.Name = "RedP1pictureBox1";
            this.RedP1pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.RedP1pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedP1pictureBox1.TabIndex = 5;
            this.RedP1pictureBox1.TabStop = false;
            this.RedP1pictureBox1.Visible = false;
            // 
            // RedP2pictureBox2
            // 
            this.RedP2pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("RedP2pictureBox2.Image")));
            this.RedP2pictureBox2.Location = new System.Drawing.Point(787, 173);
            this.RedP2pictureBox2.Name = "RedP2pictureBox2";
            this.RedP2pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.RedP2pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedP2pictureBox2.TabIndex = 6;
            this.RedP2pictureBox2.TabStop = false;
            this.RedP2pictureBox2.Visible = false;
            // 
            // RedP3pictureBox3
            // 
            this.RedP3pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("RedP3pictureBox3.Image")));
            this.RedP3pictureBox3.Location = new System.Drawing.Point(749, 261);
            this.RedP3pictureBox3.Name = "RedP3pictureBox3";
            this.RedP3pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.RedP3pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedP3pictureBox3.TabIndex = 7;
            this.RedP3pictureBox3.TabStop = false;
            this.RedP3pictureBox3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Assign and Show Location in Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // AssignPatrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RedP3pictureBox3);
            this.Controls.Add(this.RedP2pictureBox2);
            this.Controls.Add(this.RedP1pictureBox1);
            this.Controls.Add(this.MappictureBox1);
            this.Controls.Add(this.MoveNextbutton1);
            this.Controls.Add(this.PatrolscomboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignPatrolForm";
            this.Text = "AssignPatrolForm";
            this.Load += new System.EventHandler(this.AssignPatrolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MappictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP1pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP2pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedP3pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PatrolscomboBox1;
        private System.Windows.Forms.Button MoveNextbutton1;
        private System.Windows.Forms.PictureBox MappictureBox1;
        private System.Windows.Forms.PictureBox RedP1pictureBox1;
        private System.Windows.Forms.PictureBox RedP2pictureBox2;
        private System.Windows.Forms.PictureBox RedP3pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}