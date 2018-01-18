using System;
using System.Runtime.InteropServices;
//using DraftSight.Interop.dsAddin;
using DraftSight.Interop.dsAutomation;

namespace DSAPIMacros
{
    class DSMain
    {
        public void Run(DraftSight.Interop.dsAutomation.Application dsApp)
        {
            Document dsDoc = dsApp.GetActiveDocument();
            if (null == dsDoc)
            {
                return;
            }

            Model dsModel = dsDoc.GetModel();
            if (null == dsModel)
            {
                return;
            }

            SketchManager dsSketchManager;
            dsSketchManager = dsModel.GetSketchManager();
            if (null == dsSketchManager)
            {
                return;
            }

            object[] sheetsList = (object[])dsDoc.GetSheets();
            Sheet dsSheet = (Sheet)sheetsList[1];
            if (null == dsSheet)
            {
                 return;
            }

            ViewManager dsViewManager = dsDoc.GetViewManager();
            if (null == dsViewManager)
            {
                return;
            }

			//-----------------
            Spline spline1;
            {
                spline1 = dsSketchManager.InsertSpline(
                 new double[]{34.74545454545455,101.82727272727271,0.00000000000000,110.78181818181820,135.82727272727271,0.00000000000000,208.45454545454547,98.73636363636359,0.00000000000000,339.50909090909090,99.97272727272724,0.00000000000000}, 
                 false, 
                 0.00000000000000, 
                 0.00000000000000, 
                 0.00000000000000, 
                 0.00000000000000, 
                 0.00000000000000, 
                 0.00000000000000 );
            }

            Console.WriteLine("It works!");

			//-----------------
		}
	}
}
