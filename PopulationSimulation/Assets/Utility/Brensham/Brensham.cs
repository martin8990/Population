using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Utility
{
    public static class Brensham
    {
        public static void Connect(Vector2Int p1, Vector2Int p2, Action<Vector2Int> Connect)
        {
            int dx = p2.x - p1.x;
            int dy = p2.y - p1.y;
            int xDir = Math.Sign(dx);
            int yDir = Math.Sign(dy);

            if (dy == 0 && dx == 0)
            {
                Connect(p1);
            }
            else if (Math.Abs(dy) <= Math.Abs(dx))
            {
                float adydx = Mathf.Abs((float)dy / dx);
                for (int x = 0; x <= Math.Abs(dx); x++)
                {
                    Connect(new Vector2Int(p1.x + x * xDir, p1.y + (int) (yDir * (adydx * x))));    
                }
            }
            else
            {
                float adxdy = Mathf.Abs((float)dx / dy);
                for (int y = 0; y <= Math.Abs(dy); y++)
                {
                    Connect(new Vector2Int(p1.x + (int)(xDir * (adxdy * y)),p1.y + y * yDir));
                }
            }


        }
    }
   
}
