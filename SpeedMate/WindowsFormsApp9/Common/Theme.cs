using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9.Common
{
    class Theme
    {
        public static void initTheme(Form form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form as MaterialForm);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo800,
                Primary.Indigo800,
                Primary.LightBlue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }
    }
}
