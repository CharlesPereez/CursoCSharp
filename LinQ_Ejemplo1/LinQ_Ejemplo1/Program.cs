using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            //ce.GetCEO();
            //ce.GetSalario();
            //ce.GetEmpleadosOrdenados();
                Console.WriteLine("Ingrese el id de la empresa");
            try
            {

                int idEmpresa = int.Parse(Console.ReadLine());

                ce.GetEmpleadosEmpresas(idEmpresa);
            }
            catch (Exception)
            {

                Console.WriteLine("Solo se admiten números");
                
            }

        }
    }

    class ControlEmpresasEmpleados
    {

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa() { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa() { Id = 2, Nombre = "Pildoras Informaticas" });
            listaEmpleados.Add(new Empleado() { Id = 1, Nombre = "Charles Pérez", Cargo = "CEO", Salario = 5300, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado() { Id = 2, Nombre = "Marta Sanchez", Cargo = "CEO", Salario = 6000, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado() { Id = 3, Nombre = "Maria Jimenez", Cargo = "Co-CEO", Salario = 2600, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado() { Id = 4, Nombre = "Fabricio Sergi", Cargo = "Co-CEO", Salario = 3100, EmpresaId = 2 });
        }

        public void GetCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach(Empleado empleado1 in ceos)
            {
                empleado1.getDatosEmplado();
            }
        }

        public void GetSalario()
        {
            IEnumerable<Empleado> salario = from empleado in listaEmpleados where empleado.Salario >= 3000 select empleado;

            foreach (Empleado empleado1 in salario)
            {
                empleado1.getDatosEmplado();
            }
        }

        public void GetEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmplado();
            }
        }

        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public void GetEmpleadosEmpresas(int id)
        {
            IEnumerable<Empleado> empleadosPil = from empleado in listaEmpleados join empresa in listaEmpresas
                                                 on empleado.EmpresaId equals empresa.Id where empresa.Id==id
                                                 select empleado;

            foreach (Empleado empleado1 in empleadosPil)
            {
                empleado1.getDatosEmplado();
            }
        }


    }
    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        //clave foranea
        public int EmpresaId { get; set; }

        public void getDatosEmplado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2} con salario {3} y" +
                " perteneciente a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }

}
