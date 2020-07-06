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
using Bunifu.Framework.UI;

namespace sistemacompra.vista.frmNuevos
{
    public partial class frmNuevoProvedor : frmNuevo
    {
        public int? id_Prov;
        Provider oProvider = null;       
        public frmNuevoProvedor(int? id_Prov=null)
        {
            InitializeComponent();
            this.id_Prov = id_Prov;
            if (id_Prov!=null)
            {
                cargardatos();
            }
        }
        private void cargardatos()
        {
            using (purchasesEntities db = new purchasesEntities())
            {
                oProvider = db.Provider.Find(id_Prov);
                txtNomProv.Text = oProvider.name_prov;
                txtCountry.Text = oProvider.country_prov;
                txtSwift.Text = oProvider.swift_prov;


            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (purchasesEntities db=new purchasesEntities())
            {
                if (id_Prov==null)

                oProvider = new Provider();
                oProvider.name_prov = txtNomProv.Text;
                oProvider.country_prov = txtCountry.Text;
                oProvider.swift_prov = txtSwift.Text;
                if(id_Prov==null)
                     db.Provider.Add(oProvider);
                else
                {
                    db.Entry(oProvider).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();
            }
        }

        private void frmNuevoProvedor_Load(object sender, EventArgs e)
        {

        }
    }
}
