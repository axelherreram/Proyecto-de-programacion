using Grupo2_FrondEnd.Entidades;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo2_FrondEnd
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            Inicio();
        }
        public void Inicio() {
            ClassFacturas objFac = new ClassFacturas();
            string res = objFac.allFacturas(objFac);
            List<ClassFacturas> lst = JsonConvert.DeserializeObject<List<ClassFacturas>>(res);
            dgvTodo.DataSource = lst;

        }

    }
}
