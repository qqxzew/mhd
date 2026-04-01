namespace mdz;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        Stops = new System.Windows.Forms.ComboBox();
        Line = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label3 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // Stops
        // 
        Stops.FormattingEnabled = true;
        Stops.Location = new System.Drawing.Point(80, 93);
        Stops.Name = "Stops";
        Stops.Size = new System.Drawing.Size(313, 28);
        Stops.TabIndex = 0;
        // 
        // Line
        // 
        Line.FormattingEnabled = true;
        Line.Location = new System.Drawing.Point(80, 142);
        Line.Name = "Line";
        Line.Size = new System.Drawing.Size(313, 28);
        Line.TabIndex = 1;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(12, 186);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(400, 252);
        dataGridView1.TabIndex = 2;
       
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 93);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(62, 28);
        label1.TabIndex = 3;
        label1.Text = "Zadání:";
       
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 142);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(72, 24);
        label2.TabIndex = 4;
        label2.Text = "linka:";
       
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.InitialImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage"));
        pictureBox1.Location = new System.Drawing.Point(418, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(370, 426);
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(110, -2);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(233, 92);
        label3.TabIndex = 6;
        label3.Text = "mdž";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label3);
        Controls.Add(pictureBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dataGridView1);
        Controls.Add(Line);
        Controls.Add(Stops);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.ComboBox Stops;
    private System.Windows.Forms.ComboBox Line;

    #endregion
}