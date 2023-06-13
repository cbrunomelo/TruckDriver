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

        private static Dictionary<string, Func<ChildBase>> _childs = new Dictionary<string, Func<ChildBase>>()
        {
            {PathNameSpace + "frm_caminhao", () => new  frm_caminhao()},
            { PathNameSpace+ "frm_Motoristas",() => new frm_Motoristas()},
            { PathNameSpace + "frm_Pedidos", () => new frm_Pedidos()},
            { PathNameSpace + "frm_Configuracao", () => new frm_Configuracao()}

        };

        public static ChildBase GetChildForm(Type type) => _childs[type.ToString()]();


        
    }
}
