using OpenIconPack;
namespace OpenIconExample
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            sizeInput = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            strokeInput = new NumericUpDown();
            groupBox3 = new GroupBox();
            opacityInput = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)sizeInput).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)strokeInput).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)opacityInput).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 169);
            button1.Name = "button1";
            button1.Size = new Size(216, 52);
            button1.TabIndex = 0;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sizeInput
            // 
            sizeInput.Location = new Point(6, 22);
            sizeInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            sizeInput.Name = "sizeInput";
            sizeInput.Size = new Size(103, 23);
            sizeInput.TabIndex = 1;
            sizeInput.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(351, 151);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sizeInput);
            groupBox1.Location = new Point(369, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(115, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(strokeInput);
            groupBox2.Location = new Point(369, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(115, 53);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stroke";
            // 
            // strokeInput
            // 
            strokeInput.Location = new Point(6, 22);
            strokeInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            strokeInput.Name = "strokeInput";
            strokeInput.Size = new Size(103, 23);
            strokeInput.TabIndex = 1;
            strokeInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(opacityInput);
            groupBox3.Location = new Point(369, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(115, 53);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opacity";
            // 
            // opacityInput
            // 
            opacityInput.Location = new Point(6, 22);
            opacityInput.Name = "opacityInput";
            opacityInput.Size = new Size(103, 23);
            opacityInput.TabIndex = 1;
            opacityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(107, 48);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(106, 22);
            addToolStripMenuItem.Text = "add";
            addToolStripMenuItem.Image = OpenIcon.Set(IconName.add);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(106, 22);
            deleteToolStripMenuItem.Text = "delete";
            deleteToolStripMenuItem.Image = OpenIcon.Set(IconName.delete);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 231);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sizeInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)strokeInput).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)opacityInput).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private NumericUpDown sizeInput;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown strokeInput;
        private GroupBox groupBox3;
        private NumericUpDown opacityInput;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
