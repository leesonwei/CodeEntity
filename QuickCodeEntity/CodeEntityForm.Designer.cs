namespace QuickCodeEntity
{
    partial class CodeEntityForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txte_path = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_path = new DevExpress.XtraEditors.SimpleButton();
            this.txte_savepath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txte_namespace = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txte_classname = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_generate = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_quit = new DevExpress.XtraEditors.SimpleButton();
            this.ce_cloneable = new DevExpress.XtraEditors.CheckEdit();
            this.ce_databindable = new DevExpress.XtraEditors.CheckEdit();
            this.保存路径 = new DevExpress.XtraEditors.LabelControl();
            this.ce_usetablename = new DevExpress.XtraEditors.CheckEdit();
            this.sbtn_savepath = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.rg_basetype = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txte_auth = new DevExpress.XtraEditors.TextEdit();
            this.txte_des = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.me_json = new DevExpress.XtraEditors.MemoEdit();
            this.txte_status = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txte_path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_savepath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_namespace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_classname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_cloneable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_databindable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_usetablename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_basetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_auth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_des.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.me_json.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "文件位置";
            // 
            // txte_path
            // 
            this.txte_path.EditValue = "C:\\Users\\Administrator\\AppData\\Local\\Temp\\plstemp.xml";
            this.txte_path.Enabled = false;
            this.txte_path.Location = new System.Drawing.Point(102, 91);
            this.txte_path.Name = "txte_path";
            this.txte_path.Size = new System.Drawing.Size(370, 24);
            this.txte_path.TabIndex = 1;
            // 
            // sbtn_path
            // 
            this.sbtn_path.Location = new System.Drawing.Point(478, 88);
            this.sbtn_path.Name = "sbtn_path";
            this.sbtn_path.Size = new System.Drawing.Size(75, 30);
            this.sbtn_path.TabIndex = 2;
            this.sbtn_path.Text = "浏览";
            this.sbtn_path.Click += new System.EventHandler(this.sbtn_path_Click);
            // 
            // txte_savepath
            // 
            this.txte_savepath.EditValue = "E:\\Entity";
            this.txte_savepath.Enabled = false;
            this.txte_savepath.Location = new System.Drawing.Point(102, 179);
            this.txte_savepath.Name = "txte_savepath";
            this.txte_savepath.Size = new System.Drawing.Size(370, 24);
            this.txte_savepath.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 226);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "命名空间";
            // 
            // txte_namespace
            // 
            this.txte_namespace.EditValue = "XFA6.";
            this.txte_namespace.Location = new System.Drawing.Point(102, 223);
            this.txte_namespace.Name = "txte_namespace";
            this.txte_namespace.Size = new System.Drawing.Size(275, 24);
            this.txte_namespace.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(61, 273);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "类名";
            // 
            // txte_classname
            // 
            this.txte_classname.Location = new System.Drawing.Point(102, 270);
            this.txte_classname.Name = "txte_classname";
            this.txte_classname.Size = new System.Drawing.Size(127, 24);
            this.txte_classname.TabIndex = 3;
            // 
            // sbtn_generate
            // 
            this.sbtn_generate.Location = new System.Drawing.Point(102, 365);
            this.sbtn_generate.Name = "sbtn_generate";
            this.sbtn_generate.Size = new System.Drawing.Size(75, 30);
            this.sbtn_generate.TabIndex = 2;
            this.sbtn_generate.Text = "生成";
            this.sbtn_generate.Click += new System.EventHandler(this.sbtn_generate_Click);
            // 
            // sbtn_quit
            // 
            this.sbtn_quit.Location = new System.Drawing.Point(478, 365);
            this.sbtn_quit.Name = "sbtn_quit";
            this.sbtn_quit.Size = new System.Drawing.Size(75, 30);
            this.sbtn_quit.TabIndex = 2;
            this.sbtn_quit.Text = "退出";
            this.sbtn_quit.Click += new System.EventHandler(this.sbtn_quit_Click);
            // 
            // ce_cloneable
            // 
            this.ce_cloneable.Location = new System.Drawing.Point(102, 319);
            this.ce_cloneable.Name = "ce_cloneable";
            this.ce_cloneable.Properties.Caption = "支持克隆";
            this.ce_cloneable.Size = new System.Drawing.Size(100, 22);
            this.ce_cloneable.TabIndex = 4;
            // 
            // ce_databindable
            // 
            this.ce_databindable.Location = new System.Drawing.Point(235, 319);
            this.ce_databindable.Name = "ce_databindable";
            this.ce_databindable.Properties.Caption = "支持数据绑定";
            this.ce_databindable.Size = new System.Drawing.Size(133, 22);
            this.ce_databindable.TabIndex = 4;
            // 
            // 保存路径
            // 
            this.保存路径.Location = new System.Drawing.Point(31, 182);
            this.保存路径.Name = "保存路径";
            this.保存路径.Size = new System.Drawing.Size(60, 18);
            this.保存路径.TabIndex = 0;
            this.保存路径.Text = "保存路径";
            // 
            // ce_usetablename
            // 
            this.ce_usetablename.Location = new System.Drawing.Point(235, 271);
            this.ce_usetablename.Name = "ce_usetablename";
            this.ce_usetablename.Properties.Caption = "使用表名称做类名";
            this.ce_usetablename.Size = new System.Drawing.Size(142, 22);
            this.ce_usetablename.TabIndex = 4;
            this.ce_usetablename.CheckedChanged += new System.EventHandler(this.ce_usetablename_CheckedChanged);
            // 
            // sbtn_savepath
            // 
            this.sbtn_savepath.Location = new System.Drawing.Point(478, 176);
            this.sbtn_savepath.Name = "sbtn_savepath";
            this.sbtn_savepath.Size = new System.Drawing.Size(75, 30);
            this.sbtn_savepath.TabIndex = 2;
            this.sbtn_savepath.Text = "浏览";
            this.sbtn_savepath.Click += new System.EventHandler(this.sbtn_savepath_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(254, 419);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "version：1.0.0";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(114, 419);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(115, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "author：weilizong";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(376, 419);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(118, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "date：2018-03-16";
            // 
            // rg_basetype
            // 
            this.rg_basetype.EditValue = 2;
            this.rg_basetype.Location = new System.Drawing.Point(102, 137);
            this.rg_basetype.Name = "rg_basetype";
            this.rg_basetype.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "MYSQL"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "ORACLE"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "JSON")});
            this.rg_basetype.Size = new System.Drawing.Size(370, 25);
            this.rg_basetype.TabIndex = 7;
            this.rg_basetype.SelectedIndexChanged += new System.EventHandler(this.rg_basetype_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 137);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 18);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "数据库类型";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "作者";
            // 
            // txte_auth
            // 
            this.txte_auth.EditValue = "weilizong";
            this.txte_auth.Location = new System.Drawing.Point(102, 41);
            this.txte_auth.Name = "txte_auth";
            this.txte_auth.Properties.NullValuePrompt = "作者";
            this.txte_auth.Size = new System.Drawing.Size(206, 24);
            this.txte_auth.TabIndex = 0;
            // 
            // txte_des
            // 
            this.txte_des.Location = new System.Drawing.Point(347, 40);
            this.txte_des.Name = "txte_des";
            this.txte_des.Properties.NullValuePrompt = "类功能描述";
            this.txte_des.Size = new System.Drawing.Size(206, 24);
            this.txte_des.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(594, 14);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "JSON";
            // 
            // me_json
            // 
            this.me_json.Location = new System.Drawing.Point(594, 38);
            this.me_json.Name = "me_json";
            this.me_json.Size = new System.Drawing.Size(369, 399);
            this.me_json.TabIndex = 3;
            // 
            // txte_status
            // 
            this.txte_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txte_status.Location = new System.Drawing.Point(0, 456);
            this.txte_status.Name = "txte_status";
            this.txte_status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txte_status.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.txte_status.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.txte_status.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txte_status.Properties.Appearance.Options.UseBackColor = true;
            this.txte_status.Properties.Appearance.Options.UseBorderColor = true;
            this.txte_status.Properties.Appearance.Options.UseForeColor = true;
            this.txte_status.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txte_status.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txte_status.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txte_status.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txte_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txte_status.Size = new System.Drawing.Size(975, 22);
            this.txte_status.TabIndex = 8;
            // 
            // CodeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 478);
            this.Controls.Add(this.txte_status);
            this.Controls.Add(this.rg_basetype);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.ce_usetablename);
            this.Controls.Add(this.ce_databindable);
            this.Controls.Add(this.ce_cloneable);
            this.Controls.Add(this.txte_classname);
            this.Controls.Add(this.txte_namespace);
            this.Controls.Add(this.txte_savepath);
            this.Controls.Add(this.sbtn_quit);
            this.Controls.Add(this.sbtn_generate);
            this.Controls.Add(this.sbtn_savepath);
            this.Controls.Add(this.sbtn_path);
            this.Controls.Add(this.txte_des);
            this.Controls.Add(this.txte_auth);
            this.Controls.Add(this.txte_path);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.保存路径);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.me_json);
            this.Name = "CodeEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动生成实体类";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txte_path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_savepath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_namespace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_classname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_cloneable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_databindable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_usetablename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_basetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_auth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_des.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me_json.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txte_path;
        private DevExpress.XtraEditors.SimpleButton sbtn_path;
        private DevExpress.XtraEditors.TextEdit txte_savepath;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txte_namespace;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txte_classname;
        private DevExpress.XtraEditors.SimpleButton sbtn_generate;
        private DevExpress.XtraEditors.SimpleButton sbtn_quit;
        private DevExpress.XtraEditors.CheckEdit ce_cloneable;
        private DevExpress.XtraEditors.CheckEdit ce_databindable;
        private DevExpress.XtraEditors.LabelControl 保存路径;
        private DevExpress.XtraEditors.CheckEdit ce_usetablename;
        private DevExpress.XtraEditors.SimpleButton sbtn_savepath;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.RadioGroup rg_basetype;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txte_auth;
        private DevExpress.XtraEditors.TextEdit txte_des;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit me_json;
        private DevExpress.XtraEditors.TextEdit txte_status;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

