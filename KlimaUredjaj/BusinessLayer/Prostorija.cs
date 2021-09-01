using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimaUredjaj.BusinessLayer
{
    public class Prostorija : UredjajBase
    {

        public delegate void PromenaTemeratureDelegat(Prostorija obj, TemperaturaEventArgs args);

        //private List<Klima> klime = new List<Klima>();
        private List<object> pretplatnici = new List<object>();

        public event PromenaTemeratureDelegat OnPromenaTemperature = delegate (Prostorija obj, TemperaturaEventArgs args) { };

        private int temperatura = 20;

        //public List<Klima> Klime { get => klime; set => klime = value; }
        public void add(Klima obj)
        {
            this.pretplatnici.Add(obj);
            this.OnPromenaTemperature += obj.PretplataNaPromenuTemperature;
        }


        public int Temperatura
        {
            get => temperatura;
            set
            {
                if (this.temperatura != value)
                {
                    this.temperatura = value;

                    //if (this.OnPromenaTemperature != null)
                    //    this.OnPromenaTemperature(this, new TemperaturaEvetArgs(value));

                    //if (this.OnPromenaTemperature != null)
                    //{
                    TemperaturaEventArgs objTemEventArgs = new TemperaturaEventArgs(value);
                    List<Exception> listaIzuzetaka = new List<Exception>();
                    Delegate[] nizDelegata = OnPromenaTemperature.GetInvocationList();
                    //object[] parametri = new object[1];
                    //parametri[0] = objTemEventArgs;
                    foreach (Delegate delegat in nizDelegata)
                    {
                        try
                        {
                            //delegat.Method.Invoke(this, parametri);
                            delegat.DynamicInvoke(this, objTemEventArgs);
                        }
                        catch (Exception e)
                        {
                            listaIzuzetaka.Add(e);
                        }
                    }
                    if (listaIzuzetaka.Count > 0)
                        throw new AggregateException(listaIzuzetaka);
                    //}
                }
            }
        }
    }

    public class TemperaturaEventArgs : EventArgs
    {
        public readonly int temperatura;
        public TemperaturaEventArgs(int temperatura)
        {
            this.temperatura = temperatura;
        }
    }
}
