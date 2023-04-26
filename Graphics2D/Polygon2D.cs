using System;
using System.Collections.Generic;
using System.Drawing;

namespace Graphics2D
{
    class Polygon2D
    {
        #region Class Parameters
        List<Line2D> edges = new List<Line2D>();
        List<Point2D> pts = new List<Point2D>();
        #endregion

        #region Class Constructors
        /// <summary>
        /// Create an empty polygon
        /// </summary>
        public Polygon2D() { }
        #endregion

        #region Class Properties
        public List<Line2D> Edges { get { return edges; } }
        #endregion

        #region Class Methods
        public void Draw(Graphics gr)
        {
            foreach (Line2D edge in edges)
                edge.Draw(gr);
        }
        /// <summary>
        /// Add a point to the polygon
        /// </summary>
        /// <param name="pt"></param>
        public void AddPt(Point2D pt)
        {
            pts.Add(pt);
            if(pts.Count >= 3)
            {
                edges.Clear();
                for (int i = 0; i < pts.Count; i++)
                    edges.Add(new Line2D(pts[i], pts[(i + 1)%pts.Count]));
            }
        }
        #endregion
    }
}
