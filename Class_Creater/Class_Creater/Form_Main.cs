using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Class_Creater
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize();
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "Form_Main_Load", ex.ToString());
            }
        }

        private void Initialize()
        {
            try
            {
                #region Check Directory
                //  建立所需資料夾
                foreach (string folder in Class_Datas.List_Folder)
                {
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                }
                #endregion

                Init_cmb_ParamType();
                Init_dgv_Param();
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "Initialize", ex.ToString());
            }
        }

        private void btn_NewParam_Click(object sender, EventArgs e)
        {
            try
            {
                Parm_Type _new_pt = (Parm_Type)Enum.Parse(typeof(Parm_Type), cmb_ParamType.Text);
                string _new_pn = txt_ParamName.Text;

                if (string.IsNullOrEmpty(_new_pn))
                {
                    MessageBox.Show("請填入參數名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IEnumerable<Param> _exist_Param = List_Params.Where(p => p.ParamName.ToLower() == _new_pn.ToLower());
                if (_exist_Param.Any())
                {
                    MessageBox.Show("參數已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List_Params.Add(new Param() { ParamType = _new_pt, ParamName = _new_pn });

                txt_ParamName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "btn_NewParam_Click", ex.ToString());
            }
        }

        private void dgv_Param_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var ht = dgv_Param.HitTest(e.X, e.Y);

                    dgv_Param.ClearSelection();
                    dgv_Param.CurrentCell = null;
                    dgv_Param.Rows[ht.RowIndex].Selected = true;

                    if (ht.Type == DataGridViewHitTestType.Cell)
                    {
                        // This positions the menu at the mouse's location.
                        cms_dgv_Param.Show(MousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "dgv_Param_MouseDown", ex.ToString());
            }
        }

        private void tsmi_dgv_Param_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Param.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgv_Param.SelectedRows[0]; //  目前設定是單選狀態

                    Param _param = List_Params.FirstOrDefault(p => p.ParamType.ToString() == row.Cells["ParamType"].Value.ToString() && p.ParamName == row.Cells["ParamName"].Value.ToString());
                    if (_param != null)
                    {
                        List_Params.Remove(_param);
                        dgv_Param.CurrentCell = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "tsmi_dgv_Param_Delete_Click", ex.ToString());
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_Result.Clear();

                if (string.IsNullOrEmpty(txt_ClassName.Text))
                {
                    MessageBox.Show("請填入類別名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (List_Params.Count == 0)
                {
                    MessageBox.Show("請填入參數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string str_head = string.Format("public class {0} : INotifyPropertyChanged", txt_ClassName.Text) + "\n{\n";
                str_head = str_head + "     public event PropertyChangedEventHandler PropertyChanged;\n";
                str_head = str_head + "     private void NotifyPropertyChanged(string name)\n     {\n";
                str_head = str_head + "             if (PropertyChanged != null)\n";
                str_head = str_head + "                 PropertyChanged(this, new PropertyChangedEventArgs(name));\n     }\n\n";

                string str_body = string.Empty;
                foreach (Param p in List_Params)
                {
                    str_body = str_body + string.Format("     private {0} _{1} = default({2});\n", p.ParamType.ToString().ToLower(), p.ParamName, p.ParamType.ToString().ToLower());
                    str_body = str_body + string.Format("     public {0} {1}", p.ParamType.ToString().ToLower(), p.ParamName.ToUpper()) + "\n     {\n";
                    str_body = str_body + "          get { return _" + p.ParamName + "; }\n";
                    str_body = str_body + "          set \n          {\n";
                    str_body = str_body + string.Format("                    _{0} = value;\n", p.ParamName);
                    str_body = str_body + string.Format(@"                    this.NotifyPropertyChanged(""{0}"");", p.ParamName.ToUpper());
                    str_body = str_body + "              \n          }\n";
                    str_body = str_body + "     }\n\n";
                }

                str_body = str_body + "     public " + txt_ClassName.Text + "()\n     {\n";
                foreach (Param p in List_Params)
                {
                    str_body = str_body + "          _" + p.ParamName + " = default(" + p.ParamType.ToString().ToLower() + ");\n";
                }

                string str_end = "     }\n}\n";

                rtb_Result.Text = str_head + str_body + str_end;
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "btn_Convert_Click", ex.ToString());
            }
        }

        //==================================================================================================================

        /// <summary>
        /// 初始化cmb_PramType項目
        /// </summary>
        private void Init_cmb_ParamType()
        {
            try
            {
                IEnumerable<Parm_Type> list_type = Enum.GetValues(typeof(Parm_Type)).Cast<Parm_Type>();

                cmb_ParamType.Items.Clear();
                foreach(Parm_Type t in list_type)
                {
                    cmb_ParamType.Items.Add(t.ToString());
                }

                if (cmb_ParamType.Items.Count > 0)
                {
                    cmb_ParamType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "Init_cmb_ParamType", ex.ToString());
            }
        }

        BindingList<Param> List_Params = new BindingList<Param>();
        /// <summary>
        /// 初始化dgv_Param
        /// </summary>
        private void Init_dgv_Param()
        {
            try
            {
                dgv_Param.VirtualMode = true;
                dgv_Param.DoubleBuffered(true);
                dgv_Param.AllowUserToResizeRows = false;
                dgv_Param.AllowUserToAddRows = false;
                dgv_Param.AllowUserToOrderColumns = false;
                dgv_Param.AutoGenerateColumns = true;
                dgv_Param.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_Param.ScrollBars = ScrollBars.Both;
                dgv_Param.MultiSelect = false;
                dgv_Param.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_Param.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgv_Param.Font = new System.Drawing.Font("新細明體", 8.5F, GraphicsUnit.Point);
                dgv_Param.DefaultCellStyle.SelectionBackColor = Color.White;
                dgv_Param.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv_Param.RowHeadersVisible = false;
                dgv_Param.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                BindingSource bs = new BindingSource();
                bs.DataSource = List_Params;
                dgv_Param.DataSource = bs;
            }
            catch (Exception ex)
            {
                Class_Log.Write_Log(Log_Type.Error, "Init_dgv_Param", ex.ToString());
            }
        }

    }
}