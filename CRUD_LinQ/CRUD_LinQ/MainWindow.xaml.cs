using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD_LinQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LinQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();

            //InsertaEmpleados();

            //InsertaCargo();

            //InsertaEmpleadoCargo();

            //ActualizaEmpleado();

            EliminaEmpleado();

        }
        public void InsertaEmpresas()
        {
            //dataContext.ExecuteCommand("delete from Empresa");


            Empresa pildorasInformaticas = new Empresa();

            pildorasInformaticas.nombre = "Píldoras Informáticas";

            dataContext.Empresa.InsertOnSubmit(pildorasInformaticas);


            Empresa empresaGoogle = new Empresa();

            empresaGoogle.nombre = "Google";

            dataContext.Empresa.InsertOnSubmit(empresaGoogle);


            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertaEmpleados()
        {
            Empresa pildorasInformaticas = dataContext.Empresa.First(em => em.nombre.Equals("Píldoras Informáticas"));

            Empresa empresaGoogle = dataContext.Empresa.First(em => em.nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado { Nombre = "Charles", Apellido = "Pérez", EmpresaId = pildorasInformaticas.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Antonio", Apellido = "Fernandez", EmpresaId = pildorasInformaticas.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Fabricio", Apellido = "Sergi", EmpresaId = empresaGoogle.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Mayra", Apellido = "Taborga", EmpresaId = empresaGoogle.Id });

            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }


        public void InsertaCargo()
        {

            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Director/a" });

            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Administrativo/a" });

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Cargo;

        }

        public void InsertaEmpleadoCargo()
        {
            /*Empleado Charles = dataContext.Empleado.First(em => em.Nombre.Equals("Charles"));

            Empleado Mayra = dataContext.Empleado.First(em => em.Nombre.Equals("Mayra"));

            Empleado Charles = dataContext.Empleado.First(em => em.Nombre.Equals("Charles"));

            Empleado Fabricio = dataContext.Empleado.First(em => em.Nombre.Equals("Fabricio"));

            Cargo cDirector = dataContext.Cargo.First(c => c.NombreCargo.Equals("Director/a"));

            Cargo cAdministrativo = dataContext.Cargo.First(c => c.NombreCargo.Equals("Administrativo/a"));

            CargoEmpleado cargoCharles = new CargoEmpleado();

            cargoCharles.Empleado = Charles;

            cargoCharles.CargoId = cDirector.Id;*/

            List<CargoEmpleado> listaCargoEmpleado = new List<CargoEmpleado>();

            listaCargoEmpleado.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First(em => em.Nombre.Equals("Charles")),
                Cargo = dataContext.Cargo.First(c => c.NombreCargo.Equals("Director/a"))
            });

            listaCargoEmpleado.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First(em => em.Nombre.Equals("Mayra")),
                Cargo = dataContext.Cargo.First(c => c.NombreCargo.Equals("Administrativo/a"))
            });

            listaCargoEmpleado.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First(em => em.Nombre.Equals("Fabricio")),
                Cargo = dataContext.Cargo.First(c => c.NombreCargo.Equals("Administrativo/a"))
            });




            dataContext.CargoEmpleado.InsertAllOnSubmit(listaCargoEmpleado);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.CargoEmpleado;


        }

        public void ActualizaEmpleado()
        {
            Empleado Mayra = dataContext.Empleado.First(em => em.Nombre.Equals("Mayra"));

            Mayra.Nombre = "Mayra Taborga";

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }

        public void EliminaEmpleado()
        {
            Empleado Antonio = dataContext.Empleado.First(em => em.Nombre.Equals("Antonio"));

            dataContext.Empleado.DeleteOnSubmit(Antonio);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }
    }


}
