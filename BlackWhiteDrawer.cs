using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_challenge
{
    class BlackWhiteDrawer : BaseDrawer
    {
        public override Bitmap generate()
        {
            Bitmap bitmap = new Bitmap(500, 500);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = (Math.Abs(i-j)<20) ? Color.White : Color.Black;
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }
    }
}
