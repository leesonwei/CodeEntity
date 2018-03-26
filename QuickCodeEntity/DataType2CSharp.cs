using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCodeEntity
{
    public class DataType2CSharp
    {
        public static string GetDataType(int typeno)
        {
            string result=string.Empty;
            switch(typeno)
            {
                case 1:
                    result = "string";
                    break;
                case 2:
                    result = "int";
                    break;
                case 12:
                    result = "DateTime";
                    break;
                default:
                    result = "string";
                    break;
            }
            return result;
        }
    }
}
