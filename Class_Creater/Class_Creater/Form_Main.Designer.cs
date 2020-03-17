namespace Class_Creater
{
    partial class Form_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Param = new System.Windows.Forms.DataGridView();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_NewParam = new System.Windows.Forms.Button();
            this.cmb_ParamType = new System.Windows.Forms.ComboBox();
            this.txt_ParamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.cms_dgv_Param = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_dgv_Param_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Param)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cms_dgv_Param.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_Param);
            this.groupBox1.Controls.Add(this.btn_Convert);
            this.groupBox1.Controls.Add(this.btn_NewParam);
            this.groupBox1.Controls.Add(this.cmb_ParamType);
            this.groupBox1.Controls.Add(this.txt_ParamName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ClassName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轉換內容";
            // 
            // dgv_Param
            // 
            this.dgv_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Param.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Param.Location = new System.Drawing.Point(20, 169);
            this.dgv_Param.Name = "dgv_Param";
            this.dgv_Param.RowTemplate.Height = 24;
            this.dgv_Param.Size = new System.Drawing.Size(207, 246);
            this.dgv_Param.TabIndex = 10;
            this.dgv_Param.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Param_MouseDown);
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Convert.Location = new System.Drawing.Point(152, 421);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 9;
            this.btn_Convert.Text = "轉換";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_NewParam
            // 
            this.btn_NewParam.Location = new System.Drawing.Point(152, 140);
            this.btn_NewParam.Name = "btn_NewParam";
            this.btn_NewParam.Size = new System.Drawing.Size(75, 23);
            this.btn_NewParam.TabIndex = 8;
            this.btn_NewParam.Text = "新增參數";
            this.btn_NewParam.UseVisualStyleBackColor = true;
            this.btn_NewParam.Click += new System.EventHandler(this.btn_NewParam_Click);
            // 
            // cmb_ParamType
            // 
            this.cmb_ParamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ParamType.FormattingEnabled = true;
            this.cmb_ParamType.Location = new System.Drawing.Point(80, 85);
            this.cmb_ParamType.Name = "cmb_ParamType";
            this.cmb_ParamType.Size = new System.Drawing.Size(147, 20);
            this.cmb_ParamType.TabIndex = 7;
            // 
            // txt_ParamName
            // 
            this.txt_ParamName.Location = new System.Drawing.Point(80, 112);
            this.txt_ParamName.Name = "txt_ParamName";
            this.txt_ParamName.Size = new System.Drawing.Size(147, 22);
            this.txt_ParamName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "參數名稱:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "參數型態:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "參數:";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Location = new System.Drawing.Point(80, 21);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(147, 22);
            this.txt_ClassName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "類別名稱:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtb_Result);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轉換結果";
            // 
            // rtb_Result
            // 
            this.rtb_Result.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Result.Location = new System.Drawing.Point(3, 18);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.ReadOnly = true;
            this.rtb_Result.Size = new System.Drawing.Size(757, 435);
            this.rtb_Result.TabIndex = 0;
            this.rtb_Result.Text = "";
            // 
            // cms_dgv_Param
            // 
            this.cms_dgv_Param.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_dgv_Param_Delete});
            this.cms_dgv_Param.Name = "cms_dgv_Param";
            this.cms_dgv_Param.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmi_dgv_Param_Delete
            // 
            this.tsmi_dgv_Param_Delete.Name = "tsmi_dgv_Param_Delete";
            this.tsmi_dgv_Param_Delete.Size = new System.Drawing.Size(100, 22);
            this.tsmi_dgv_Param_Delete.Text = "刪除";
            this.tsmi_dgv_Param_Delete.Click += new System.EventHandler(this.tsmi_dgv_Param_Delete_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Param)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.cms_dgv_Param.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ParamType;
        private System.Windows.Forms.TextBox txt_ParamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NewParam;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.RichTextBox rtb_Result;
        private System.Windows.Forms.DataGridView dgv_Param;
        private System.Windows.Forms.ContextMenuStrip cms_dgv_Param;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dgv_Param_Delete;
    }
}

