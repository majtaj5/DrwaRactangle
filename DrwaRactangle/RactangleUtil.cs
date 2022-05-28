using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

namespace DrwaRactangle
{
    class RactangleUtil
    {
        public void DrowRactangle(double wigth, double height,Point3d insPt)
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                try
                {
                    doc.LockDocument();
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace],OpenMode.ForWrite) as BlockTableRecord;

                    //Convertthe insertionPoint to point2d
                    Point2d insPt2d = new Point2d(insPt.X,insPt.Y);

                    //Derive the upperleft corner based on the Insention Ponit
                    Point2d ulPt = new Point2d(insPt.X, insPt.Y + height);

                    //Derive the upper right corner based on the upper left corner
                    Point2d urPt = new Point2d(ulPt.X + wigth, ulPt.Y);

                    //Derive the lower right corner based on the insertion point

                    Point2d lrPt = new Point2d(insPt.X + wigth, insPt.Y);

                    //Draw the LWPolyline using the newly derived verticles
                    Polyline pl = new Polyline();
                    pl.AddVertexAt(0, insPt2d, 0, 0, 0);
                    pl.AddVertexAt(1, ulPt, 0, 0, 0);
                    pl.AddVertexAt(2, urPt, 0, 0, 0);
                    pl.AddVertexAt(3, lrPt, 0, 0, 0);
                    pl.Closed = true;

                    btr.AppendEntity(pl);
                    trans.AddNewlyCreatedDBObject(pl, true);
                    trans.Commit();

                    ed.WriteMessage("Rantangle is drawn successfully!");

                }
                catch (System.Exception ex )
                {

                    ed.WriteMessage("Error encountered: " + ex.Message);
                    trans.Abort();
                }
            }

        }
    }
}
