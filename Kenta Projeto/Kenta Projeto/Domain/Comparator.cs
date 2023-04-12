using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenta_Projeto.Domain
{

    public class Comparator : IComparer<Item>
    {
        public int Compare(Item i, Item j)
        {
            var FilaPrioridades = new SortedSet<Item>(new Comparator());

            return 2;
            //Complemente….
        }
    }

    public class Item
    {
        public int id;
        public string nome;
        public int valor;
    }
}
