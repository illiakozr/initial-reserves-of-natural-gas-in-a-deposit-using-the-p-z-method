namespace Exercise1._1
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slopeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interceptBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.initialGasBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.N2textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CO2textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.C3H8textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.C2H6textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CH4textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DownloadGroupBox = new System.Windows.Forms.GroupBox();
            this.ImportDataButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.TempGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureBox1 = new System.Windows.Forms.TextBox();
            this.KelvinRadioButton = new System.Windows.Forms.RadioButton();
            this.CelsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.FahrRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DownloadGroupBox.SuspendLayout();
            this.TempGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(373, 44);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(537, 470);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(953, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Build Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(953, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear Graph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(357, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 503);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "graph field";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(953, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slope : ";
            // 
            // slopeBox
            // 
            this.slopeBox.BackColor = System.Drawing.Color.White;
            this.slopeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slopeBox.Location = new System.Drawing.Point(1026, 193);
            this.slopeBox.Name = "slopeBox";
            this.slopeBox.ReadOnly = true;
            this.slopeBox.Size = new System.Drawing.Size(73, 26);
            this.slopeBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(949, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Intercept : ";
            // 
            // interceptBox
            // 
            this.interceptBox.BackColor = System.Drawing.Color.White;
            this.interceptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interceptBox.Location = new System.Drawing.Point(1026, 157);
            this.interceptBox.Name = "interceptBox";
            this.interceptBox.ReadOnly = true;
            this.interceptBox.Size = new System.Drawing.Size(73, 26);
            this.interceptBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(953, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "initial gas in place :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1051, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "[mln Nm3]";
            // 
            // initialGasBox
            // 
            this.initialGasBox.BackColor = System.Drawing.Color.White;
            this.initialGasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialGasBox.Location = new System.Drawing.Point(953, 282);
            this.initialGasBox.Name = "initialGasBox";
            this.initialGasBox.ReadOnly = true;
            this.initialGasBox.Size = new System.Drawing.Size(92, 26);
            this.initialGasBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.DownloadGroupBox);
            this.panel1.Controls.Add(this.TempGroupBox);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 695);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.N2textBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CO2textBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.C3H8textBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.C2H6textBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CH4textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(10, 590);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "composition of natural gas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "%";
            // 
            // N2textBox
            // 
            this.N2textBox.Location = new System.Drawing.Point(165, 68);
            this.N2textBox.Name = "N2textBox";
            this.N2textBox.Size = new System.Drawing.Size(34, 23);
            this.N2textBox.TabIndex = 13;
            this.N2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            this.N2textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CH4textBox_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(127, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "N2 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "%";
            // 
            // CO2textBox
            // 
            this.CO2textBox.Location = new System.Drawing.Point(47, 68);
            this.CO2textBox.Name = "CO2textBox";
            this.CO2textBox.Size = new System.Drawing.Size(34, 23);
            this.CO2textBox.TabIndex = 10;
            this.CO2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            this.CO2textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CH4textBox_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "CO2 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "%";
            // 
            // C3H8textBox
            // 
            this.C3H8textBox.Location = new System.Drawing.Point(281, 25);
            this.C3H8textBox.Name = "C3H8textBox";
            this.C3H8textBox.Size = new System.Drawing.Size(34, 23);
            this.C3H8textBox.TabIndex = 7;
            this.C3H8textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            this.C3H8textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CH4textBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "C3H8 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "%";
            // 
            // C2H6textBox
            // 
            this.C2H6textBox.Location = new System.Drawing.Point(164, 25);
            this.C2H6textBox.Name = "C2H6textBox";
            this.C2H6textBox.Size = new System.Drawing.Size(34, 23);
            this.C2H6textBox.TabIndex = 4;
            this.C2H6textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            this.C2H6textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CH4textBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "C2H6 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "%";
            // 
            // CH4textBox
            // 
            this.CH4textBox.Location = new System.Drawing.Point(47, 25);
            this.CH4textBox.Name = "CH4textBox";
            this.CH4textBox.Size = new System.Drawing.Size(34, 23);
            this.CH4textBox.TabIndex = 1;
            this.CH4textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            this.CH4textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CH4textBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "CH4 : ";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(10, 545);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 27);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pressure,
            this.Production});
            this.dataGridView1.Location = new System.Drawing.Point(10, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 261);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // DownloadGroupBox
            // 
            this.DownloadGroupBox.Controls.Add(this.ImportDataButton);
            this.DownloadGroupBox.Controls.Add(this.FilePathTextBox);
            this.DownloadGroupBox.Controls.Add(this.OpenFileButton);
            this.DownloadGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadGroupBox.Location = new System.Drawing.Point(10, 112);
            this.DownloadGroupBox.Name = "DownloadGroupBox";
            this.DownloadGroupBox.Size = new System.Drawing.Size(247, 147);
            this.DownloadGroupBox.TabIndex = 1;
            this.DownloadGroupBox.TabStop = false;
            this.DownloadGroupBox.Text = "Import File";
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.Enabled = false;
            this.ImportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportDataButton.Location = new System.Drawing.Point(67, 111);
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.Size = new System.Drawing.Size(104, 30);
            this.ImportDataButton.TabIndex = 5;
            this.ImportDataButton.Text = "Import Data";
            this.ImportDataButton.UseVisualStyleBackColor = true;
            this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(6, 77);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(235, 23);
            this.FilePathTextBox.TabIndex = 4;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(6, 40);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(88, 30);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // TempGroupBox
            // 
            this.TempGroupBox.Controls.Add(this.temperatureBox1);
            this.TempGroupBox.Controls.Add(this.KelvinRadioButton);
            this.TempGroupBox.Controls.Add(this.CelsiusRadioButton);
            this.TempGroupBox.Controls.Add(this.FahrRadioButton);
            this.TempGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempGroupBox.Location = new System.Drawing.Point(10, 18);
            this.TempGroupBox.Name = "TempGroupBox";
            this.TempGroupBox.Size = new System.Drawing.Size(247, 79);
            this.TempGroupBox.TabIndex = 0;
            this.TempGroupBox.TabStop = false;
            this.TempGroupBox.Text = "Temperature reservoir";
            // 
            // temperatureBox1
            // 
            this.temperatureBox1.Location = new System.Drawing.Point(26, 49);
            this.temperatureBox1.Name = "temperatureBox1";
            this.temperatureBox1.Size = new System.Drawing.Size(97, 23);
            this.temperatureBox1.TabIndex = 3;
            this.temperatureBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temperatureBox1_KeyPress);
            // 
            // KelvinRadioButton
            // 
            this.KelvinRadioButton.AutoSize = true;
            this.KelvinRadioButton.Checked = true;
            this.KelvinRadioButton.Location = new System.Drawing.Point(164, 23);
            this.KelvinRadioButton.Name = "KelvinRadioButton";
            this.KelvinRadioButton.Size = new System.Drawing.Size(64, 21);
            this.KelvinRadioButton.TabIndex = 2;
            this.KelvinRadioButton.TabStop = true;
            this.KelvinRadioButton.Text = "Kelvin";
            this.KelvinRadioButton.UseVisualStyleBackColor = true;
            // 
            // CelsiusRadioButton
            // 
            this.CelsiusRadioButton.AutoSize = true;
            this.CelsiusRadioButton.Location = new System.Drawing.Point(87, 22);
            this.CelsiusRadioButton.Name = "CelsiusRadioButton";
            this.CelsiusRadioButton.Size = new System.Drawing.Size(71, 21);
            this.CelsiusRadioButton.TabIndex = 1;
            this.CelsiusRadioButton.Text = "Celsius";
            this.CelsiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // FahrRadioButton
            // 
            this.FahrRadioButton.AutoSize = true;
            this.FahrRadioButton.Location = new System.Drawing.Point(26, 22);
            this.FahrRadioButton.Name = "FahrRadioButton";
            this.FahrRadioButton.Size = new System.Drawing.Size(55, 21);
            this.FahrRadioButton.TabIndex = 0;
            this.FahrRadioButton.Text = "Fahr";
            this.FahrRadioButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Pressure [Pa]";
            this.Pressure.Name = "Pressure";
            this.Pressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Production
            // 
            this.Production.HeaderText = "Gas Production [mln Nm3]";
            this.Production.Name = "Production";
            this.Production.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.initialGasBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interceptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slopeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Determination of initial capacity of gas into reservoir";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DownloadGroupBox.ResumeLayout(false);
            this.DownloadGroupBox.PerformLayout();
            this.TempGroupBox.ResumeLayout(false);
            this.TempGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slopeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interceptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialGasBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox TempGroupBox;
        private System.Windows.Forms.RadioButton CelsiusRadioButton;
        private System.Windows.Forms.RadioButton FahrRadioButton;
        private System.Windows.Forms.RadioButton KelvinRadioButton;
        private System.Windows.Forms.TextBox temperatureBox1;
        private System.Windows.Forms.GroupBox DownloadGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ImportDataButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox N2textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CO2textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox C3H8textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox C2H6textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CH4textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Production;
    }
}

