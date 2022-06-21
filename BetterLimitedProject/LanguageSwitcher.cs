using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedProject
{
    class LanguageSwitcher
    {
        public static bool isEng { get; set; } = true;

        public static void switchLang()
        {
            isEng = !isEng;
        }
        public static void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            foreach (Form frm in Application.OpenForms)
            {
                localizeForm(frm);
            }
        }

        public static void localizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());
            manager.ApplyResources(frm, "$this");
            applyResources(manager, frm.Controls);
        }

        public static void applyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                applyResources(manager, ctl.Controls);
            }
        }
    }
}
