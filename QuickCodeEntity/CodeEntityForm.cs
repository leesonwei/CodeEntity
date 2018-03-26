using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickCodeEntity
{
    public partial class CodeEntityForm : Form
    {
        public string msg;
        public DataTable dt = new DataTable();
        public CodeEntityForm()
        {
            InitializeComponent();
        }

        private void ce_usetablename_CheckedChanged(object sender, EventArgs e)
        {
            this.txte_classname.Enabled = !ce_usetablename.Checked;
        }

        private void sbtn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ce_cloneable.Checked = true;
            this.ce_databindable.Checked = true;
            dt.Columns.Add("msg", typeof(string));
            this.bindingSource1.DataSource = dt;
            this.txte_status.DataBindings.Add("Text",bindingSource1,"msg");
        }

        private void sbtn_path_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.txte_path.Text = openFileDialog1.FileName;
            }
        }

        private void sbtn_savepath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txte_savepath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void sbtn_generate_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            this.txte_status.Text = "正在生成实体类...";
            if (!varible_data(out msg))
            {
                row["msg"] = msg;
                this.txte_status.Text = msg;
                return;
            }
            row["msg"] = msg;
            this.txte_status.Text = msg;
            this.Enabled = false;
            CodeEntity coder = new CodeEntity();
            string filename= this.txte_classname.Text;
            StringBuilder sb;
            if(rg_basetype.SelectedIndex==2)
            {
                sb = coder.CodeJsonString(this.me_json.Text, this.txte_namespace.Text,
                this.txte_des.Text, this.txte_auth.Text, this.ce_cloneable.Checked, this.ce_databindable.Checked,
                this.txte_classname.Text);
            }
            else
            {
                sb = coder.CodeOracleString(this.txte_path.Text, this.txte_namespace.Text,
                this.txte_des.Text, this.txte_auth.Text, this.ce_cloneable.Checked, this.ce_databindable.Checked,
                out filename);
            }
            if(coder.WriteFile(sb, string.Format(@"{0}\{1}.cs", this.txte_savepath.Text, filename),out msg))
            {
                msg = string.Format("实体类{0}生成成功...", filename);
            }
            else
            {
                msg = string.Format("实体类{0}生成失败...原因:{1}", filename,msg);
            }
            row["msg"] = msg;
            this.txte_status.Text = msg;
            this.Enabled = true;
            this.txte_path.Focus();
        }
        private bool varible_data(out string msg)
        {
            msg = "正在验证数据...";
            if (rg_basetype.SelectedIndex != 2 && string.IsNullOrEmpty(this.txte_path.Text.Trim()))
            {
                this.txte_path.Focus();
                msg = "未选择xml文件";
                return false;
            }
            if (rg_basetype.SelectedIndex != 2 && string.IsNullOrEmpty(this.txte_savepath.Text.Trim()))
            {
                this.txte_savepath.Focus();
                msg = "未选择实体类文件保存路径";
                return false;
            }
            if (rg_basetype.SelectedIndex == 2 && string.IsNullOrEmpty(this.me_json.Text.Trim()))
            {
                this.me_json.Focus();
                msg = "未输入json文件";
                return false;
            }
            if (string.IsNullOrEmpty(this.txte_namespace.Text.Trim()))
            {
                this.txte_namespace.Focus();
                msg = "未输入命名空间";
                return false;
            }
            if (!this.ce_usetablename.Checked && string.IsNullOrEmpty(this.txte_classname.Text.Trim()))
            {
                this.txte_classname.Focus();
                msg = "未输入类名";
                return false;
            }
            msg = "验证通过...";
            return true;
        }

        private void rg_basetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            me_json.Enabled = rg_basetype.SelectedIndex == 2 ? true : false;
            ce_usetablename.Checked = rg_basetype.SelectedIndex == 2 ? false : true;
            sbtn_path.Enabled = rg_basetype.SelectedIndex == 2 ? false : true;
        }
    }
}
