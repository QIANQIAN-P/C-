using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortPro.Models
{
    internal class Faker
    {
        public static List<string> GetPort()
        {
            return new List<string>()
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6"
            };
        }

        
    }
}
