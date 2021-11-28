
namespace BaoCaoATBMTT.Forms
{
    partial class MaHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnMaHoa = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdFileInput = new System.Windows.Forms.RadioButton();
            this.rdNhapInput = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePathInput = new System.Windows.Forms.RichTextBox();
            this.btnChoosenFile = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBanMaBit = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKeyBit = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtInput);
            this.panel4.Controls.Add(this.btnMaHoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(326, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 132);
            this.panel4.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(606, 87);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaHoa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaHoa.ForeColor = System.Drawing.Color.Black;
            this.btnMaHoa.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.btnMaHoa.IconColor = System.Drawing.Color.Black;
            this.btnMaHoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaHoa.IconSize = 25;
            this.btnMaHoa.Location = new System.Drawing.Point(506, 93);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(100, 34);
            this.btnMaHoa.TabIndex = 3;
            this.btnMaHoa.Text = "Mã hoá";
            this.btnMaHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 132);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtKey, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 31);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKey
            // 
            this.txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey.Location = new System.Drawing.Point(71, 4);
            this.txtKey.Multiline = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(248, 23);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.47923F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.52077F));
            this.tableLayoutPanel2.Controls.Add(this.rdFileInput, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdNhapInput, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 27);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rdFileInput
            // 
            this.rdFileInput.AutoSize = true;
            this.rdFileInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdFileInput.Location = new System.Drawing.Point(3, 3);
            this.rdFileInput.Name = "rdFileInput";
            this.rdFileInput.Size = new System.Drawing.Size(157, 21);
            this.rdFileInput.TabIndex = 0;
            this.rdFileInput.TabStop = true;
            this.rdFileInput.Text = "Input file";
            this.rdFileInput.UseVisualStyleBackColor = true;
            this.rdFileInput.CheckedChanged += new System.EventHandler(this.rdFileInput_CheckedChanged);
            // 
            // rdNhapInput
            // 
            this.rdNhapInput.AutoSize = true;
            this.rdNhapInput.Checked = true;
            this.rdNhapInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdNhapInput.Location = new System.Drawing.Point(166, 3);
            this.rdNhapInput.Name = "rdNhapInput";
            this.rdNhapInput.Size = new System.Drawing.Size(154, 21);
            this.rdNhapInput.TabIndex = 1;
            this.rdNhapInput.TabStop = true;
            this.rdNhapInput.Text = "Nhập Input";
            this.rdNhapInput.UseVisualStyleBackColor = true;
            this.rdNhapInput.CheckedChanged += new System.EventHandler(this.rdNhapInput_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePathInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChoosenFile, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "File input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilePathInput
            // 
            this.txtFilePathInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePathInput.Location = new System.Drawing.Point(77, 4);
            this.txtFilePathInput.Multiline = false;
            this.txtFilePathInput.Name = "txtFilePathInput";
            this.txtFilePathInput.ReadOnly = true;
            this.txtFilePathInput.Size = new System.Drawing.Size(155, 22);
            this.txtFilePathInput.TabIndex = 1;
            this.txtFilePathInput.Text = "";
            this.txtFilePathInput.TextChanged += new System.EventHandler(this.txtFilePathInput_TextChanged);
            // 
            // btnChoosenFile
            // 
            this.btnChoosenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnChoosenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChoosenFile.Enabled = false;
            this.btnChoosenFile.FlatAppearance.BorderSize = 0;
            this.btnChoosenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosenFile.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnChoosenFile.IconColor = System.Drawing.Color.PaleVioletRed;
            this.btnChoosenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChoosenFile.Location = new System.Drawing.Point(239, 4);
            this.btnChoosenFile.Name = "btnChoosenFile";
            this.btnChoosenFile.Size = new System.Drawing.Size(80, 22);
            this.btnChoosenFile.TabIndex = 2;
            this.btnChoosenFile.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBanMaBit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(451, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 166);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bản mã bit";
            // 
            // txtBanMaBit
            // 
            this.txtBanMaBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBanMaBit.Location = new System.Drawing.Point(3, 19);
            this.txtBanMaBit.Name = "txtBanMaBit";
            this.txtBanMaBit.ReadOnly = true;
            this.txtBanMaBit.Size = new System.Drawing.Size(478, 144);
            this.txtBanMaBit.TabIndex = 1;
            this.txtBanMaBit.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKeyBit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 166);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dãy khoá";
            // 
            // txtKeyBit
            // 
            this.txtKeyBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyBit.Location = new System.Drawing.Point(3, 19);
            this.txtKeyBit.Name = "txtKeyBit";
            this.txtKeyBit.ReadOnly = true;
            this.txtKeyBit.Size = new System.Drawing.Size(445, 144);
            this.txtKeyBit.TabIndex = 0;
            this.txtKeyBit.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOutput.Location = new System.Drawing.Point(3, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(929, 200);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 551);
            this.panel2.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.txtOutput);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(0, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(935, 231);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(929, 9);
            this.progressBar1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 166);
            this.panel3.TabIndex = 4;
            // 
            // MaHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(935, 551);
            this.Controls.Add(this.panel2);
            this.Name = "MaHoa";
            this.Text = "MaHoa";
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFilePathInput;
        private FontAwesome.Sharp.IconButton btnChoosenFile;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rdFileInput;
        private System.Windows.Forms.RadioButton rdNhapInput;
        private FontAwesome.Sharp.IconButton btnMaHoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtBanMaBit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtKeyBit;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}