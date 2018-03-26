using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuickCodeEntity
{
    public class CodeEntity
    {
        /// <summary>
        /// json 格式处理
        /// </summary>
        /// <param name="path"></param>
        /// <param name="_namespace"></param>
        /// <param name="des"></param>
        /// <param name="auth"></param>
        /// <param name="cloneable"></param>
        /// <param name="bindable"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public StringBuilder CodeJsonString(string json, string _namespace,
            string des, string auth, bool cloneable, bool bindable,
            string className)
        {
            StringBuilder cs = new StringBuilder();
            string line = "\r\n";

            HeadMethod(cs, auth, des, _namespace);

            //加入类名
            cs.Append("\tpublic class ").Append(className).Append(cloneable ? ":ICloneable" : "").Append(bindable ? ",INotifyPropertyChanged" : "").Append(line).Append("\t{");
            cs.Append(line).Append(line);

            //加入私有字段
            JObject jobj = JObject.Parse(json); 
            foreach (var element in jobj)
            {
                if (element.Key!=null)
                {
                    cs.Append("\t\t/// <summary>").Append(line);
                    cs.Append("\t\t/// ").Append(line);
                    cs.Append("\t\t/// <summary>").Append(line);
                    cs.Append("\t\tprivate ").Append("string").Append(" _").Append(element.Key.ToLower()).Append(";").Append(line).Append(line);
                }

            }

            ///加入公共方法
            foreach (var element in jobj)
            {
                if (element.Key != null)
                {
                    string name = element.Key.ToLower();
                    cs.Append("\t\tpublic ").Append("string")
                        .AppendFormat(" {0}{1}", name.Substring(0, 1).ToUpper(), name.Substring(1))
                        .Append(line)
                        .Append("\t\t{").Append(line)
                        .Append("\t\t\tget { return this._").Append(name).Append("; }")
                        .Append(line)
                        .Append("\t\t\tset {").Append(line).Append("\t\t\t\tthis._" + name)
                        .Append(" = value;").Append(line);
                        if (bindable)
                        {
                            cs.Append("\t\t\t\tOnPropertyChanged(").Append("\"")
                            .AppendFormat("{0}{1}", name.Substring(0, 1).ToUpper(), name.Substring(1)).Append("\");").Append(line);
                        }
                        cs.Append("\t\t\t}").Append(line)
                        .Append("\t\t}")
                        .Append(line).Append(line);
                }

            }

            if (cloneable)
            {
                CloneMethod(cs);
            }
            if (bindable)
            {
                BindMethod(cs);
            }

            //完成类结构
            cs.Append("\t}").Append(line);
            //完成命名空间结构
            cs.Append("}").Append(line);
            return cs;
        }
        /// <summary>
        /// oracle xml格式处理
        /// </summary>
        /// <param name="path"></param>
        /// <param name="_namespace"></param>
        /// <param name="des"></param>
        /// <param name="auth"></param>
        /// <param name="cloneable"></param>
        /// <param name="bindable"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public StringBuilder CodeOracleString(string path,string _namespace,
            string des,string auth,bool cloneable,bool bindable,
            out string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            StringBuilder cs = new StringBuilder();
            string line = "\r\n";
            XmlNodeList node_obj = doc.GetElementsByTagName("SCHEMA_OBJ");
            string className = node_obj[0].SelectSingleNode("NAME").InnerText;
            className = className.Substring(0, 1) + className.Substring(1).ToLower();
            filename = className;

            HeadMethod(cs,auth,des,_namespace);

            //加入类名
            cs.Append("\tpublic class ").Append(className).Append(cloneable? " : ICloneable" : "").Append(cloneable && bindable? " , INotifyPropertyChanged" : bindable? " : INotifyPropertyChanged" : "").Append(line).Append("\t{");
            cs.Append(line).Append(line);
            
            //加入私有字段
            XmlNodeList lists = doc.GetElementsByTagName("COL_LIST_ITEM");
            XmlNode node_name;
            XmlNode node_type;
            XmlNode node_null;
            XmlNode node_length;
            foreach (XmlElement element in lists)
            {
                node_name = element.SelectSingleNode("NAME");
                node_type = element.SelectSingleNode("TYPE_NUM");
                node_null = element.SelectSingleNode("NOT_NULL");
                node_length = element.SelectSingleNode("LENGTH");

                if (node_name != null)
                {
                    cs.Append("\t\t/// <summary>").Append(line);
                    cs.Append("\t\t/// 允许空值：").Append(node_null.InnerText == "2" ? "否" : "是").Append(line);
                    cs.Append("\t\t/// 数据长度：").Append(node_length.InnerText).Append(line);
                    cs.Append("\t\t/// <summary>").Append(line);
                    cs.Append("\t\tprivate ").Append(DataType2CSharp.GetDataType(Convert.ToInt32(node_type.InnerText))).Append(" _").Append(node_name.InnerText.ToLower()).Append(";").Append(line).Append(line);
                }

            }

            ///加入公共方法
            foreach (XmlElement element in lists)
            {
                node_name = element.SelectSingleNode("NAME");
                node_type = element.SelectSingleNode("TYPE_NUM");

                if (node_name != null)
                {
                    string name = node_name.InnerText.ToLower();
                    cs.Append("\t\tpublic ").Append(DataType2CSharp.GetDataType(Convert.ToInt32(node_type.InnerText)))
                        .AppendFormat(" {0}{1}", name.Substring(0, 1).ToUpper(), name.Substring(1))
                        .Append(line)
                        .Append("\t\t{").Append(line)
                        .Append("\t\t\tget { return this._").Append(node_name).Append("; }")
                        .Append(line)
                        .Append("\t\t\tset {").Append(line).Append("\t\t\t\tthis._" + node_name)
                        .Append(" = value;").Append(line);
                        if(bindable)
                        {
                            cs.Append("\t\t\t\tOnPropertyChanged(").Append("\"");
                            cs.AppendFormat("{0}{1}", name.Substring(0, 1).ToUpper(), name.Substring(1)).Append("\");").Append(line);
                        }
                        cs.Append("\t\t\t}").Append(line)
                        .Append("\t\t}")
                        .Append(line).Append(line);
                }

            }
            if(cloneable)
            {
                CloneMethod(cs);
            }
            if(bindable)
            {
                BindMethod(cs);
            }
            //完成类结构
            cs.Append("\t}").Append(line);
            //完成命名空间结构
            cs.Append("}").Append(line);
            return cs;
    }
        public StringBuilder CloneMethod(StringBuilder cs)
        {
            string line = "\r\n";
            //实现克隆接口
            cs.Append("\t\tpublic object Clone()").Append(line);
            cs.Append("\t\t{").Append(line);
            cs.Append("\t\t\treturn MemberwiseClone();").Append(line);
            cs.Append("\t\t}").Append(line);
            return cs;
        }
        public StringBuilder HeadMethod(StringBuilder cs,string auth,string des,string _namespace)
        {
            string line = "\r\n";
            //加入命名空间
            cs.Append("using System;").Append(line);
            cs.Append("using System.ComponentModel;").Append(line).Append(line);
            cs.Append("namespace ").Append(_namespace).Append(line).Append("{");
            cs.Append(line).Append(line);
            cs.Append("\t/// <summary>").Append(line);
            cs.Append("\t/// @author:").Append(auth).Append(line);
            cs.Append("\t/// @date:" + DateTime.Now.ToString("yyyy-MM-dd")).Append(line);
            cs.Append("\t/// @description:").Append(des).Append(line);
            cs.Append("\t/// @version:1.0.0").Append(line);
            cs.Append("\t/// <summary>").Append(line);
            return cs;
        }
        public StringBuilder BindMethod(StringBuilder cs)
        {
            string line = "\r\n";
            //实现数据绑定
            cs.Append("\t\tpublic event PropertyChangedEventHandler PropertyChanged;").Append(line);
            cs.Append("\t\tprotected void OnPropertyChanged(string PropertyName)").Append(line);
            cs.Append("\t\t{").Append(line);
            cs.Append("\t\t\tPropertyChangedEventHandler handler = PropertyChanged;").Append(line);
            cs.Append("\t\t\tif (handler != null)").Append(line);
            cs.Append("\t\t\t{").Append(line);
            cs.Append("\t\t\t\thandler(this, new PropertyChangedEventArgs(PropertyName));").Append(line);
            cs.Append("\t\t\t}").Append(line);
            cs.Append("\t\t}").Append(line);
            return cs;
        }
        public bool WriteFile(StringBuilder sb,string path,out string msg)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                byte[] data = System.Text.Encoding.Default.GetBytes(sb.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
                msg = string.Empty;
                return true;
            }
            catch(Exception e)
            {
                msg = e.Message;
                return false;
            }
        }
    }
}
