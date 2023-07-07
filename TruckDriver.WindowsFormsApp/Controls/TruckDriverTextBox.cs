using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controls
{
    public class TruckDriverTextBox : TextBox
    {

        private bool _NotAllowNumbers { get; set; } = false;

        private bool _NotAllowLetters { get; set; }=false;

        private bool _NotAllowWhiteSpace { get; set; } = false;

        private int _MaxNumberAllowed { get; set; } = 0;

        public void NotAllowNumbers() => _NotAllowNumbers = true;            
        
        public void NotAllowLetters() => _NotAllowLetters = true;            
        
        public void NotAllowWhiteSpace() => _NotAllowWhiteSpace = true;

        
        

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);


            NotAllowDigit(char.IsDigit(e.KeyChar), _NotAllowNumbers, e);
            NotAllowDigit(char.IsLetter(e.KeyChar), _NotAllowLetters, e);
            NotAllowDigit(e.KeyChar == ' ', _NotAllowWhiteSpace, e);


            
        }

        private void NotAllowDigit(bool cond1, bool cond2, KeyPressEventArgs e)
        { 
            if(cond1 && cond2)
                e.Handled = true;
        }

        private bool VerifyMaxNumber() 
        {
            return false;
        }
    }
}
