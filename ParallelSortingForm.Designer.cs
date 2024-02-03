namespace SortingAlgorithms
{
    partial class ParallelSortingForm
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
            sortButton = new Button();
            container = new Panel();
            binFound = new Label();
            seqFound = new Label();
            genButton = new Button();
            errorLabel = new Label();
            closeButton = new Label();
            clearButton = new Button();
            label8 = new Label();
            binTime = new TextBox();
            label7 = new Label();
            seqTime = new TextBox();
            insertionTime = new Label();
            insTime = new TextBox();
            label5 = new Label();
            quickTime = new TextBox();
            label4 = new Label();
            bubbleTime = new TextBox();
            label3 = new Label();
            toSearchNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            arrayText = new TextBox();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.BackColor = Color.FromArgb(250, 163, 7);
            sortButton.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
            sortButton.FlatAppearance.BorderSize = 2;
            sortButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 8);
            sortButton.FlatStyle = FlatStyle.Flat;
            sortButton.Font = new Font("Roboto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sortButton.ForeColor = Color.FromArgb(12, 12, 12);
            sortButton.Location = new Point(446, 269);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(196, 37);
            sortButton.TabIndex = 3;
            sortButton.Text = "Sort →";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // container
            // 
            container.BackColor = Color.FromArgb(12, 12, 12);
            container.BackgroundImage = Properties.Resources.rayo1;
            container.BackgroundImageLayout = ImageLayout.Center;
            container.Controls.Add(binFound);
            container.Controls.Add(seqFound);
            container.Controls.Add(genButton);
            container.Controls.Add(errorLabel);
            container.Controls.Add(closeButton);
            container.Controls.Add(clearButton);
            container.Controls.Add(label8);
            container.Controls.Add(binTime);
            container.Controls.Add(label7);
            container.Controls.Add(seqTime);
            container.Controls.Add(insertionTime);
            container.Controls.Add(insTime);
            container.Controls.Add(label5);
            container.Controls.Add(quickTime);
            container.Controls.Add(label4);
            container.Controls.Add(bubbleTime);
            container.Controls.Add(label3);
            container.Controls.Add(toSearchNumber);
            container.Controls.Add(label2);
            container.Controls.Add(label1);
            container.Controls.Add(sortButton);
            container.Controls.Add(arrayText);
            container.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            container.ForeColor = Color.FromArgb(82, 183, 136);
            container.Location = new Point(-1, -1);
            container.Name = "container";
            container.Size = new Size(1081, 581);
            container.TabIndex = 0;
            // 
            // binFound
            // 
            binFound.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            binFound.ForeColor = Color.FromArgb(250, 163, 7);
            binFound.Location = new Point(916, 437);
            binFound.Name = "binFound";
            binFound.Size = new Size(110, 15);
            binFound.TabIndex = 21;
            binFound.Text = "Encontrado";
            binFound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // seqFound
            // 
            seqFound.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            seqFound.ForeColor = Color.FromArgb(250, 163, 7);
            seqFound.Location = new Point(701, 437);
            seqFound.Name = "seqFound";
            seqFound.Size = new Size(111, 15);
            seqFound.TabIndex = 20;
            seqFound.Text = "Encontrado";
            seqFound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genButton
            // 
            genButton.BackColor = Color.Transparent;
            genButton.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
            genButton.FlatAppearance.BorderSize = 0;
            genButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 12, 12);
            genButton.FlatStyle = FlatStyle.Flat;
            genButton.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            genButton.ForeColor = Color.FromArgb(250, 163, 7);
            genButton.Image = Properties.Resources.rayo1;
            genButton.Location = new Point(549, 507);
            genButton.Name = "genButton";
            genButton.Size = new Size(160, 37);
            genButton.TabIndex = 5;
            genButton.Text = "Generate Array …";
            genButton.UseMnemonic = false;
            genButton.UseVisualStyleBackColor = false;
            genButton.Click += genButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Dock = DockStyle.Bottom;
            errorLabel.Font = new Font("Roboto", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.FromArgb(208, 0, 0);
            errorLabel.Location = new Point(0, 547);
            errorLabel.Name = "errorLabel";
            errorLabel.Padding = new Padding(3);
            errorLabel.Size = new Size(1081, 34);
            errorLabel.TabIndex = 19;
            errorLabel.Text = "Manejo de errores";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Font = new Font("Roboto", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.FromArgb(250, 163, 7);
            closeButton.Location = new Point(1036, 10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(33, 35);
            closeButton.TabIndex = 18;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Transparent;
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 12, 12);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.FromArgb(250, 163, 7);
            clearButton.Image = Properties.Resources.rayo1;
            clearButton.Location = new Point(380, 507);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(160, 37);
            clearButton.TabIndex = 4;
            clearButton.Text = "← Reset";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(250, 163, 7);
            label8.Location = new Point(923, 391);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 16;
            label8.Text = "Binary Search";
            // 
            // binTime
            // 
            binTime.Anchor = AnchorStyles.None;
            binTime.BackColor = Color.FromArgb(12, 12, 12);
            binTime.BorderStyle = BorderStyle.None;
            binTime.Cursor = Cursors.IBeam;
            binTime.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            binTime.ForeColor = Color.FromArgb(255, 186, 8);
            binTime.Location = new Point(890, 409);
            binTime.Name = "binTime";
            binTime.PlaceholderText = "Time";
            binTime.ReadOnly = true;
            binTime.Size = new Size(160, 16);
            binTime.TabIndex = 15;
            binTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(250, 163, 7);
            label7.Location = new Point(701, 391);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 14;
            label7.Text = "Sequential Search";
            // 
            // seqTime
            // 
            seqTime.Anchor = AnchorStyles.None;
            seqTime.BackColor = Color.FromArgb(12, 12, 12);
            seqTime.BorderStyle = BorderStyle.None;
            seqTime.Cursor = Cursors.IBeam;
            seqTime.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            seqTime.ForeColor = Color.FromArgb(255, 186, 8);
            seqTime.Location = new Point(676, 409);
            seqTime.Name = "seqTime";
            seqTime.PlaceholderText = "Time";
            seqTime.ReadOnly = true;
            seqTime.Size = new Size(160, 16);
            seqTime.TabIndex = 13;
            seqTime.TextAlign = HorizontalAlignment.Center;
            // 
            // insertionTime
            // 
            insertionTime.AutoSize = true;
            insertionTime.BackColor = Color.Transparent;
            insertionTime.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            insertionTime.ForeColor = Color.FromArgb(250, 163, 7);
            insertionTime.Location = new Point(498, 391);
            insertionTime.Name = "insertionTime";
            insertionTime.Size = new Size(85, 15);
            insertionTime.TabIndex = 12;
            insertionTime.Text = "Insertion Sort";
            // 
            // insTime
            // 
            insTime.Anchor = AnchorStyles.None;
            insTime.BackColor = Color.FromArgb(12, 12, 12);
            insTime.BorderStyle = BorderStyle.None;
            insTime.Cursor = Cursors.IBeam;
            insTime.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            insTime.ForeColor = Color.FromArgb(255, 186, 8);
            insTime.Location = new Point(462, 409);
            insTime.Name = "insTime";
            insTime.PlaceholderText = "Time";
            insTime.ReadOnly = true;
            insTime.Size = new Size(160, 16);
            insTime.TabIndex = 11;
            insTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 163, 7);
            label5.Location = new Point(301, 391);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Quick Sort";
            // 
            // quickTime
            // 
            quickTime.Anchor = AnchorStyles.None;
            quickTime.BackColor = Color.FromArgb(12, 12, 12);
            quickTime.BorderStyle = BorderStyle.None;
            quickTime.Cursor = Cursors.IBeam;
            quickTime.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            quickTime.ForeColor = Color.FromArgb(255, 186, 8);
            quickTime.Location = new Point(254, 409);
            quickTime.Name = "quickTime";
            quickTime.PlaceholderText = "Time";
            quickTime.ReadOnly = true;
            quickTime.Size = new Size(160, 16);
            quickTime.TabIndex = 9;
            quickTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(250, 163, 7);
            label4.Location = new Point(78, 391);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Bubble Sort";
            // 
            // bubbleTime
            // 
            bubbleTime.Anchor = AnchorStyles.None;
            bubbleTime.BackColor = Color.FromArgb(12, 12, 12);
            bubbleTime.BorderStyle = BorderStyle.None;
            bubbleTime.Cursor = Cursors.IBeam;
            bubbleTime.Font = new Font("Roboto", 9.75F, FontStyle.Italic);
            bubbleTime.ForeColor = Color.FromArgb(255, 186, 8);
            bubbleTime.Location = new Point(36, 409);
            bubbleTime.Name = "bubbleTime";
            bubbleTime.PlaceholderText = "Time";
            bubbleTime.ReadOnly = true;
            bubbleTime.Size = new Size(160, 16);
            bubbleTime.TabIndex = 7;
            bubbleTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(250, 163, 7);
            label3.Location = new Point(646, 140);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 6;
            label3.Text = "Introduce a target number";
            // 
            // toSearchNumber
            // 
            toSearchNumber.Anchor = AnchorStyles.None;
            toSearchNumber.BackColor = Color.FromArgb(12, 12, 12);
            toSearchNumber.BorderStyle = BorderStyle.FixedSingle;
            toSearchNumber.Cursor = Cursors.IBeam;
            toSearchNumber.Font = new Font("Roboto", 12F, FontStyle.Italic);
            toSearchNumber.ForeColor = Color.FromArgb(255, 186, 8);
            toSearchNumber.Location = new Point(646, 158);
            toSearchNumber.Name = "toSearchNumber";
            toSearchNumber.PlaceholderText = "To Search";
            toSearchNumber.Size = new Size(244, 27);
            toSearchNumber.TabIndex = 2;
            toSearchNumber.TextChanged += toSearchNumber_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(250, 163, 7);
            label2.Location = new Point(193, 140);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Introduce the array";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(250, 163, 7);
            label1.Location = new Point(380, 57);
            label1.Name = "label1";
            label1.Size = new Size(329, 35);
            label1.TabIndex = 3;
            label1.Text = "Sorting Algorithms Race";
            // 
            // arrayText
            // 
            arrayText.Anchor = AnchorStyles.None;
            arrayText.BackColor = Color.FromArgb(12, 12, 12);
            arrayText.BorderStyle = BorderStyle.FixedSingle;
            arrayText.Cursor = Cursors.IBeam;
            arrayText.Font = new Font("Roboto", 12F, FontStyle.Italic);
            arrayText.ForeColor = Color.FromArgb(255, 186, 8);
            arrayText.Location = new Point(193, 158);
            arrayText.Name = "arrayText";
            arrayText.PlaceholderText = "Array";
            arrayText.Size = new Size(244, 27);
            arrayText.TabIndex = 1;
            // 
            // ParallelSortingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 580);
            Controls.Add(container);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParallelSortingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParallelSortingForm";
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel container;
        private TextBox arrayText;
        private Button sortButton;
        private Label label1;
        private TextBox toSearchNumber;
        private Label label2;
        private Label label3;
        private TextBox bubbleTime;
        private Label label4;
        private Label label8;
        private TextBox binTime;
        private Label label7;
        private TextBox seqTime;
        private Label insertionTime;
        private TextBox insTime;
        private Label label5;
        private TextBox quickTime;
        private Button clearButton;
        private Label closeButton;
        private Label errorLabel;
        private Button genButton;
        private Label binFound;
        private Label seqFound;
    }
}