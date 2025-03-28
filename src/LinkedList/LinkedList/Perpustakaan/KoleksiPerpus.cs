using System;
using System.Text;

namespace LinkedList.Perpustakaan
{
    public class KoleksiPerpustakaan
    {
        public BukuNode Head { get; set; }

        public KoleksiPerpustakaan()
        {
            Head = null;
        }

        public void TambahBuku(Buku buku)
        {
            BukuNode node = new BukuNode(buku);

            if (Head == null) Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public bool HapusBuku(string judul)
        {
            if (Head == null) return false;

            if (Head.Data.Judul == judul)
            {
                Head = Head.Next;
                return true;
            }

            BukuNode curr = Head;
            while (curr.Next != null)
            {
                if (curr.Next.Data.Judul == judul)
                {
                    curr.Next = curr.Next.Next;
                    return true;
                }
                curr = curr.Next;
            }

            return false;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasilPencarian = new List<Buku>();

            BukuNode node = Head;
            while (node != null)
            {
                if (node.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasilPencarian.Add(node.Data);
                }
                node = node.Next;
            }

            return hasilPencarian.ToArray();
        }

        public string TampilkanKoleksi()
        {
            BukuNode node = Head;
            StringBuilder bk = new StringBuilder();

            while (node != null)
            {
                bk.AppendLine($"\"{node.Data.Judul}\"; {node.Data.Penulis}; {node.Data.Tahun}");
                node = node.Next;
            }
            return bk.ToString().TrimEnd();
        }
    }
}
