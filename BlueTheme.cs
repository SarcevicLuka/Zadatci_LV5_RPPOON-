using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_5__6__7
{
    class BlueTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public string GetHeader(int width)
        {
            return new string('.', width);
        }
        public string GetFooter(int width)
        {
            return new string('/', width);

        }
    }
}
