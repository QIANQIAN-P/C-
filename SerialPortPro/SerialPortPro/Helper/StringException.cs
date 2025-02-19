using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortPro.Helper
{
    //加个时间戳
    public static class StringException
    {
        public static bool checkEditRecLog = true;
        public static string FormatStringLog(this string msg)//有this和没this的差别
        {
            // 启用了日志模式显示，会在前方追加日期
            if (checkEditRecLog)
            {
                return "[" + DateTime.Now + "]" + Environment.NewLine + msg + Environment.NewLine;
            }
            return msg + Environment.NewLine;
        }

    }
}
