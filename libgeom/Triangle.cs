using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libgeom
{
    public class Triangle
    {
        private int m_a, m_b, m_c;
        private int m_ax, m_ay, m_bx, m_by, m_cx, m_cy;

        public Triangle(int a, int b, int c)
        {
            m_a = a;
            m_b = b;
            m_c = c;
        }

        public Triangle(int ax, int ay, int bx, int by, int cx, int cy)
        {
            m_ax = ax; m_ay = ay;
            m_bx = bx; m_by = by;
            m_cx = cx; m_cy = cy;
            m_a = (int) Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
            m_b = (int) Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
            m_c = (int) Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
        }

        public bool IsEquilateral()
        {
            return (m_a == m_b) && (m_b == m_c);
        }

        public bool IsRectangular()
        {
            return (Math.Pow(m_c, 2) == Math.Pow(m_a, 2) + Math.Pow(m_b, 2));
        }

        public bool PointInTriangle(int ptx, int pty)
        {
            bool b1, b2, b3;

            b1 = sign(ptx, pty, m_ax, m_ay, m_bx, m_by) < 0;
            b2 = sign(ptx, pty, m_bx, m_by, m_cx, m_cy) < 0;
            b3 = sign(ptx, pty, m_cx, m_cy, m_ax, m_ay) < 0;

            return ((b1 == b2) && (b2 == b3));
        }

        private int sign(int p1x, int p1y, int p2x, int p2y, int p3x, int p3y)
        {
            return (p1x - p3x) * (p2y - p3y) - (p2x - p3x) * (p1y - p3y);
        }
    }
}
