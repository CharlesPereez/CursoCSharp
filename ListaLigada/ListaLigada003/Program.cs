
using ListaLigada003;

CListaLigada miLista = new CListaLigada();

miLista.Adicionar(3);
miLista.Adicionar(4);
miLista.Adicionar(5);
miLista.Adicionar(6);
miLista.Adicionar(7);
miLista.Adicionar(8);

miLista.Transversa();


Console.WriteLine(miLista.BuscarAnterior(8));
//Console.WriteLine(miLista.BuscarIndice(6));
//Console.WriteLine(miLista.EstaVacio());

//miLista.VaciarLista();

//miLista.Transversa();
//Console.WriteLine(miLista.EstaVacio());

//CNodo encontrado = miLista.Buscar(5);
//Console.WriteLine(encontrado);
