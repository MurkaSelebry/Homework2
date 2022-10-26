namespace Homework2
{
    partial class Coordinates
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
            this.Rectangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.Teal;
            this.Rectangle.Location = new System.Drawing.Point(210, 90);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(320, 240);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rectangle_MouseDown);
            this.Rectangle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rectangle_MouseMove);
            // 
            // Coordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rectangle);
            this.Name = "Coordinates";
            this.Text = "Coordinates";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Coordinates_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coordinates_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Rectangle;
    }
}