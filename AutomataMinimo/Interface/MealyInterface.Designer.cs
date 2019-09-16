namespace AutomataMinimo.Interface
{
    partial class MealyInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealyInterface));
            this.newMatrix = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAlphaOut = new System.Windows.Forms.Button();
            this.AddAlphaIn = new System.Windows.Forms.Button();
            this.AddState = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AlphaOutList = new System.Windows.Forms.ListView();
            this.StatesList = new System.Windows.Forms.ListView();
            this.AlphaInList = new System.Windows.Forms.ListView();
            this.Minimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.newMatrix)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // newMatrix
            // 
            this.newMatrix.AllowUserToAddRows = false;
            this.newMatrix.AllowUserToDeleteRows = false;
            this.newMatrix.AllowUserToResizeColumns = false;
            this.newMatrix.AllowUserToResizeRows = false;
            this.newMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.newMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.newMatrix.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.newMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newMatrix.GridColor = System.Drawing.SystemColors.Window;
            this.newMatrix.Location = new System.Drawing.Point(559, 234);
            this.newMatrix.Name = "newMatrix";
            this.newMatrix.Size = new System.Drawing.Size(217, 150);
            this.newMatrix.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.AlphaOutList);
            this.panel2.Controls.Add(this.StatesList);
            this.panel2.Controls.Add(this.AlphaInList);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 363);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(354, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Initial State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(259, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(150, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "States";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddAlphaOut);
            this.panel1.Controls.Add(this.AddAlphaIn);
            this.panel1.Controls.Add(this.AddState);
            this.panel1.Controls.Add(this.TextBox);
            this.panel1.Location = new System.Drawing.Point(60, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 178);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insert a character";
            // 
            // AddAlphaOut
            // 
            this.AddAlphaOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAlphaOut.Location = new System.Drawing.Point(218, 116);
            this.AddAlphaOut.Name = "AddAlphaOut";
            this.AddAlphaOut.Size = new System.Drawing.Size(122, 57);
            this.AddAlphaOut.TabIndex = 3;
            this.AddAlphaOut.Text = "Add to Output Alphabet";
            this.AddAlphaOut.UseVisualStyleBackColor = true;
            this.AddAlphaOut.Click += new System.EventHandler(this.AddAlphaOut_Click);
            // 
            // AddAlphaIn
            // 
            this.AddAlphaIn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAlphaIn.Location = new System.Drawing.Point(218, 65);
            this.AddAlphaIn.Name = "AddAlphaIn";
            this.AddAlphaIn.Size = new System.Drawing.Size(122, 45);
            this.AddAlphaIn.TabIndex = 2;
            this.AddAlphaIn.Text = "Add to Input Alphabet";
            this.AddAlphaIn.UseVisualStyleBackColor = true;
            this.AddAlphaIn.Click += new System.EventHandler(this.AddAlphaIn_Click);
            // 
            // AddState
            // 
            this.AddState.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddState.Location = new System.Drawing.Point(218, 6);
            this.AddState.Name = "AddState";
            this.AddState.Size = new System.Drawing.Size(122, 51);
            this.AddState.TabIndex = 1;
            this.AddState.Text = "Add to States";
            this.AddState.UseVisualStyleBackColor = true;
            this.AddState.Click += new System.EventHandler(this.AddState_Click);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(58, 74);
            this.TextBox.MaxLength = 1;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(50, 36);
            this.TextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 26);
            this.comboBox1.TabIndex = 8;
            // 
            // AlphaOutList
            // 
            this.AlphaOutList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlphaOutList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaOutList.HideSelection = false;
            this.AlphaOutList.Location = new System.Drawing.Point(262, 247);
            this.AlphaOutList.Name = "AlphaOutList";
            this.AlphaOutList.Size = new System.Drawing.Size(37, 97);
            this.AlphaOutList.TabIndex = 4;
            this.AlphaOutList.UseCompatibleStateImageBehavior = false;
            this.AlphaOutList.View = System.Windows.Forms.View.List;
            // 
            // StatesList
            // 
            this.StatesList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.StatesList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatesList.GridLines = true;
            this.StatesList.HideSelection = false;
            this.StatesList.Location = new System.Drawing.Point(56, 247);
            this.StatesList.Name = "StatesList";
            this.StatesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatesList.Size = new System.Drawing.Size(37, 97);
            this.StatesList.TabIndex = 2;
            this.StatesList.UseCompatibleStateImageBehavior = false;
            this.StatesList.View = System.Windows.Forms.View.List;
            // 
            // AlphaInList
            // 
            this.AlphaInList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlphaInList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaInList.HideSelection = false;
            this.AlphaInList.Location = new System.Drawing.Point(153, 247);
            this.AlphaInList.Name = "AlphaInList";
            this.AlphaInList.Size = new System.Drawing.Size(37, 97);
            this.AlphaInList.TabIndex = 3;
            this.AlphaInList.UseCompatibleStateImageBehavior = false;
            this.AlphaInList.View = System.Windows.Forms.View.List;
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(616, 390);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(95, 49);
            this.Minimize.TabIndex = 13;
            this.Minimize.Text = "Minimize Automaton";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(616, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert Matrix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matrix
            // 
            this.Matrix.AllowUserToAddRows = false;
            this.Matrix.AllowUserToDeleteRows = false;
            this.Matrix.AllowUserToResizeColumns = false;
            this.Matrix.AllowUserToResizeRows = false;
            this.Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Matrix.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.GridColor = System.Drawing.SystemColors.Window;
            this.Matrix.Location = new System.Drawing.Point(559, 21);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(217, 150);
            this.Matrix.TabIndex = 11;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(202, 393);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(95, 49);
            this.Back.TabIndex = 16;
            this.Back.Text = "Go Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(548, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 433);
            this.panel3.TabIndex = 17;
            // 
            // MealyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.newMatrix);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MealyInterface";
            this.Text = "Mealy Machine";
            ((System.ComponentModel.ISupportInitialize)(this.newMatrix)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView newMatrix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAlphaOut;
        private System.Windows.Forms.Button AddAlphaIn;
        private System.Windows.Forms.Button AddState;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView AlphaOutList;
        private System.Windows.Forms.ListView StatesList;
        private System.Windows.Forms.ListView AlphaInList;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Matrix;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel3;
    }
}