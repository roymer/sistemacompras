using sistemacompra.vista.frmNuevos;
using sistemacompra.vista.frmPadres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemacompra.modelo;

namespace sistemacompra.vista.frmSecundarios
{
    public partial class frmGestionarProvedores : frmGestionar
    {
        public frmGestionarProvedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoProvedor fm = new frmNuevoProvedor();
            fm.ShowDialog();
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id_Prov = GetId();
            if (id_Prov!=null)
            {
                frmNuevoProvedor fm = new frmNuevoProvedor(id_Prov);
                fm.ShowDialog();
                refrescar();
            }
        }

        private void frmGestionarProvedores_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        #region HELPER
        private void refrescar()
        {
            using (purchasesEntities db = new purchasesEntities())
            {
                var lst = from d in db.Provider select d;
                bunifuCustomDataGrid1.DataSource = lst.ToList();
            }
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            int? id_Prov = GetId();
            if (id_Prov != null)
            {
                using (purchasesEntities db=new purchasesEntities())
                {
                    Provider oProvide = db.Provider.Find(id_Prov);
                    db.Provider.Remove(oProvide);

                    db.SaveChanges();
                }



                    //frmNuevoProvedor fm = new frmNuevoProvedor(id_Prov);
                    //fm.ShowDialog();
                refrescar();
            }
        }
    }
}
