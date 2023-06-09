using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11B2023.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        //public int ValorA { get; set; }

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }



        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultado;
        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultado2;
        public int Resultado2
        {
            get { return resultado2; }
            set
            {
                if (resultado2 != value)
                {
                    resultado2 = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultado3;
        public int Resultado3
        {
            get { return resultado3; }
            set
            {
                if (resultado3 != value)
                {
                    resultado3 = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultado4;
        public int Resultado4
        {
            get { return resultado4; }
            set
            {
                if (resultado4 != value)
                {
                    resultado4 = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }

        public ICommand Multiplicar { get; set; }
        public ICommand Division { get; set; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                Resultado = ValorA + ValorB;
            });


            Restar = new Command(() =>
            {
                Resultado2 = ValorA - ValorB;
            });
            Multiplicar = new Command(() =>
            {
                Resultado3 = ValorA * ValorB;
            });
            Division = new Command(() =>
            {
                Resultado4 = ValorA / ValorB;
            });
        }

    }
}
