using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ThemeManager
    {
        public static string GetThemeColor(string theme)
        {
            if (theme == "Light")
            {
                return "#DCE6EC";
            }
            else if (theme == "Dark")
            {
                return "#26364C";
            }
            else if (theme=="color2") 
            {
                return "#9BB1BE";
            }
            else if (theme=="color3") 
            {
                return "#4F6C81";
            }
            else
            {
                return "#DCE6EC";
            }
        }
    }
}
