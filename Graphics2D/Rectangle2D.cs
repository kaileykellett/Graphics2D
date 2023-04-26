using System;
using System.Collections.Generic;
using System.Drawing;

namespace Graphics2D
{
    class Rectangle2D
    {
        #region Class Parameters
        List<Line2D> edges = new List<Line2D>();
        #endregion

        #region Class Constructors
        public Rectangle2D(Point2D p1, Point2D p2)
        {
            Point2D ul = new Point2D(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            Point2D ur = new Point2D(Math.Max(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            Point2D ll = new Point2D(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Point2D lr = new Point2D(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            edges.Add(new Line2D(ul, ur));
            edges.Add(new Line2D(ur, lr));
            edges.Add(new Line2D(lr, ll));
            edges.Add(new Line2D(ll, ul));
        }
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
        #endregion
    }
}
