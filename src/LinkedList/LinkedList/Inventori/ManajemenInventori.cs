using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LinkedList.Inventori
{
    public class ManajemenInventori
    {
        public LinkedList<Item> itemlist;

        public ManajemenInventori()
        {
            itemlist = new LinkedList<Item>();
        }

        public void TambahItem(Item item)
        {
            itemlist.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            foreach (Item i in itemlist)
            {
                if (i.Nama == nama)
                {
                    itemlist.Remove(i);
                    return true;
                }
            }
            return false;
        }

        public string TampilkanInventori()
        {
            StringBuilder inv = new StringBuilder();
            foreach (Item i in itemlist)
            {
                inv.AppendLine($"{i.Nama}; {i.Kuantitas}");
            }
            return inv.ToString().TrimEnd();
        }
    }
}