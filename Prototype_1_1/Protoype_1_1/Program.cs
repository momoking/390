using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1_1;
using Prototype1_1.UI;
using Prototype1_1.Presenters;
using Microsoft.VisualBasic.ApplicationServices;
using Prototype1_1.UI.Forms;

namespace Prototype1_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new SplashScreenApp().Run(args);
            
        }
    }

   public class SplashScreenApp : WindowsFormsApplicationBase
   {
       protected override void OnCreateSplashScreen()
       {
           this.SplashScreen = new Splash();
           this.SplashScreen.ShowInTaskbar = false;
           this.SplashScreen.Cursor = Cursors.AppStarting;
       }

         protected override void OnCreateMainForm()
         {

             this.MainForm = MainPresenter.getInstance().View;
         }
   }
}
    

