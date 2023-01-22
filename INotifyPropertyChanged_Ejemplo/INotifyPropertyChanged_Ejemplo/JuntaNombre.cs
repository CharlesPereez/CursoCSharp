using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_Ejemplo
{
    public class JuntaNombre : INotifyPropertyChanged
    {




        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("nombre_completo");
            }

            
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; 
                OnPropertyChanged("nombre_completo");
            }
        }
        public string Nombre_completo
        {
            get
            {
                nombre_completo = Nombre + " " + Apellido;
                return nombre_completo;
            }
            set {  }
        }
    }
}
