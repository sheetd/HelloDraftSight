using System;

namespace Macro
{
    static class Program
    {
        /// <summary>
       /// The main entry point for the application.
        /// </summary>
       [STAThread]
       static void Main()
       {
           DraftSight.Interop.dsAutomation.Application dsApp = null;
           object application = null;

           try
           {
                application = System.Runtime.InteropServices.Marshal.GetActiveObject("DraftSight.Application");
           }
           catch (Exception)
           {
               //application not running
               return;
           }

           if (null != application)
           {
                dsApp = application as DraftSight.Interop.dsAutomation.Application;
            }

           if (null != dsApp)
           {
               DSAPIMacros.DSMain MacroObj = new DSAPIMacros.DSMain();
               MacroObj.Run(dsApp);
           }
       }
   }
}
