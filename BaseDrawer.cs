using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_challenge
{
    class BaseDrawer
    {
        public virtual Bitmap generate()
        {
            Bitmap bitmap = new Bitmap(500,500);
            for(int i=0; i<bitmap.Width; i++)
            {
                for (int j=0; j < bitmap.Height; j++)
                {
                    Color color = (i%2==0 && j%2==0) ? Color.Red : Color.Purple;
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }
    }
}
