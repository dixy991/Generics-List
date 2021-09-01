using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimaUredjaj.BusinessLayer
{
    public class Klima : UredjajBase
    {
        public enum KlimaStstusEnum { Iskljucena = 0, Hladi, Greje }

        public delegate void KlimaStatusDelegat(Klima obj, KlimaStatusEventArgs arg);
        public event KlimaStatusDelegat OnPromenaStstusaKlime;

        private int tGrejanjeOn = 16;
        private int tHladjenjeOn = 26;
        private KlimaStstusEnum status = KlimaStstusEnum.Iskljucena;

        public KlimaStstusEnum Status
        {
            get => status;
            private set
            {
                if (this.status != value)
                {
                    status = value;
                    if (OnPromenaStstusaKlime != null)
                        OnPromenaStstusaKlime(this, new KlimaStatusEventArgs(value));
                }
            }
        }

        public Klima()
        { }

        public Klima(int tGrejanjeOn, int tHladjenjeOn)
        {
            this.tGrejanjeOn = tGrejanjeOn;
            this.tHladjenjeOn = tHladjenjeOn;
        }

        public void PretplataNaPromenuTemperature(Prostorija obj, TemperaturaEventArgs args)
        {
            if (args.temperatura >= this.tHladjenjeOn)
            {
                if (this.Status != KlimaStstusEnum.Hladi)
                    this.Status = KlimaStstusEnum.Hladi;
            }
            else if (args.temperatura <= this.tGrejanjeOn)
            {
                if (this.Status != KlimaStstusEnum.Greje)
                    this.Status = KlimaStstusEnum.Greje;
            }
            else
            {
                if (this.Status != KlimaStstusEnum.Iskljucena)
                    this.Status = KlimaStstusEnum.Iskljucena;
            }
            //throw new Exception();
        }
    }

    public class KlimaStatusEventArgs : EventArgs
    {
        private Klima.KlimaStstusEnum klimaStstus;
        public Klima.KlimaStstusEnum KlimaStstus { get => klimaStstus; private set => klimaStstus = value; }

        public KlimaStatusEventArgs(Klima.KlimaStstusEnum klimaStstus)
        {
            this.klimaStstus = klimaStstus;
        }

    }

}
