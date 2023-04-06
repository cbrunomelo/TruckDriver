using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckDriver.WindowsFormsApp.Controls
{
    public class BitmapFactory
    {
        public static Bitmap GetBitmap(string image)
        {   
            Bitmap bitmap;
            switch (image) 
            {
                case ("user-login2.png"):
                    bitmap = new Bitmap(Properties.Resources.user_login2);
                    break;
                case ("user-login.png"):
                    bitmap = new Bitmap(Properties.Resources.user_login);
                    break;
                case ("padlock.png"):
                    bitmap = new Bitmap(Properties.Resources.padlock);
                    break;
                case ("padlock2.png"):
                    bitmap = new Bitmap(Properties.Resources.padlock2);
                    break;


                default:
                    throw new Exception();

            }

            return bitmap;
        }
    }
}
