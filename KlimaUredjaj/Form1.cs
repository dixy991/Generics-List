using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlimaUredjaj.BusinessLayer;

namespace KlimaUredjaj
{
    public partial class Form1 : Form
    {
        Prostorija prostorija = new Prostorija();

        public Form1()
        {
            InitializeComponent();

            Klima klima1 = new Klima();
            Klima klima2 = new Klima(10, 30);

            klima1.OnPromenaStstusaKlime += this.pretplataIndikator1;
            klima2.OnPromenaStstusaKlime += this.pretplataIndikator2;

            prostorija.add(klima1);
            prostorija.add(klima2);

            prostorija.OnPromenaTemperature += this.pretplataFormeNaPromenuTemperature;
        }

        private void pretplataIndikator1(Klima obj, KlimaStatusEventArgs arg)
        {
            Klima.KlimaStstusEnum status = arg.KlimaStstus;
            if (status == Klima.KlimaStstusEnum.Greje)
                this.panelIndikator1.BackColor = Color.Red;
            else if (status == Klima.KlimaStstusEnum.Hladi)
                this.panelIndikator1.BackColor = Color.Blue;
            else
                this.panelIndikator1.BackColor = Color.White;
        }
        private void pretplataIndikator2(Klima obj, KlimaStatusEventArgs arg)
        {
            Klima.KlimaStstusEnum status = arg.KlimaStstus;
            if (status == Klima.KlimaStstusEnum.Greje)
                this.panelIndikator2.BackColor = Color.Yellow;
            else if (status == Klima.KlimaStstusEnum.Hladi)
                this.panelIndikator2.BackColor = Color.Green;
            else
                this.panelIndikator2.BackColor = Color.White;
        }

        public void pretplataFormeNaPromenuTemperature(Prostorija obj, TemperaturaEventArgs args)
        {
            this.textBoxTemperaturaIndikator.Text = args.temperatura.ToString();
        }

        private void panelTermometar_MouseMove_1(object sender, MouseEventArgs e)
        {
            int vertikalnaPozicija = e.Y;
            int tmp = this.panelTermometar.Height - vertikalnaPozicija;
            int temperatura = tmp / 8;
            try
            {
                this.prostorija.Temperatura = temperatura;
            }
            catch (AggregateException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
    }
}
