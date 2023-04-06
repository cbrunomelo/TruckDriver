using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckDriver.WindowsFormsApp.Controls
{
    public class TruckDriverPanelLogin : Panel
    {
        private string Image_On_click;
        private string default_image;
        private Color DefaultColorClick = Color.FromArgb(78, 184, 206);
        private Color DefaultColorLeave = Color.FromArgb(255, 255, 255);

        private TruckDriverLoginTextBox textbox;
        private PictureBox pictureBox;
        private Panel panel;


        public TruckDriverPanelLogin LoadConfControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TruckDriverLoginTextBox))
                { 
                  ((TruckDriverLoginTextBox)ctrl).SetPanel(this);
          
                }

                else if (ctrl.GetType() == typeof(PictureBox))
                {
                    pictureBox = (PictureBox)ctrl;
                }

                else if(ctrl.GetType() == typeof(Panel))
                {
                    panel = (Panel)ctrl;    
                }
            }

            return this;


        }

        public TruckDriverPanelLogin SetIDefaultmage(string imageName)
        {
            this.default_image = imageName;
            return this;
        }

        public TruckDriverPanelLogin SetImageOnClick(string imageName)
        {
            this.Image_On_click = imageName;
            return this;
        }


        public void Onclick()
        {
            pictureBox.Image = BitmapFactory.GetBitmap(Image_On_click);
            panel.BackColor = DefaultColorClick;
        }

        public void OnLeave()
        {
            pictureBox.Image = BitmapFactory.GetBitmap(default_image);
            panel.BackColor = DefaultColorLeave;
        }


    }
}
