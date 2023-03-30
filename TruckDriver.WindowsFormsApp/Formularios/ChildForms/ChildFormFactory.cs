using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.Formularios.Cadastros;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    abstract class ChildFormFactory
    {
        private const string PathNameSpace = "TruckDriver.WindowsFormsApp.Formularios.ChildForms.";
        public static ChildBase GetChildForm(Type type) 
        {
            switch (type.ToString())
            {
                case PathNameSpace + "frm_caminhao": return new frm_caminhao();
                case PathNameSpace+ "frm_Motoristas": return new frm_Motoristas();
                case PathNameSpace + "frm_Pedidos": return new frm_Pedidos();
                case PathNameSpace + "frm_Configuracao": return new frm_Configuracao();
                default: return null;
            }
        }
    }
}
