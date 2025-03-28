using System.Diagnostics.Tracing;
using System.Text;

namespace LinkedList.ManajemenKaryawan
{
    public class DaftarKaryawan
    {
        public KaryawanNode Head { get; set; }
        public KaryawanNode Tail { get; set; }

        public DaftarKaryawan()
        {
            Head = null;
            Tail = null;
        }

        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode newNode = new KaryawanNode(karyawan);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                Head = newNode;
            }
        }

        public bool HapusKaryawan(string nk)
        {
            KaryawanNode curr = Head;

            while (curr != null)
            {
                if (curr.Karyawan.NomorKaryawan == nk)
                {
                    if (curr.Prev == null)
                    {
                        Head = curr.Next;
                        if (Head != null)
                            Head.Prev = null;
                        else
                            Tail = null;
                    }
                    else if (curr.Next == null)
                    {
                        Tail = curr.Prev;
                        Tail.Next = null;
                    }
                    else
                    {
                        curr.Prev.Next = curr.Next;
                        curr.Next.Prev = curr.Prev;
                    }
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> hasilPencarian = new List<Karyawan>();
            KaryawanNode node = Head;

            while (node != null)
            {
                if (node.Karyawan.Nama.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    node.Karyawan.Posisi.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasilPencarian.Add(node.Karyawan);
                }
                node = node.Next;
            }

            return hasilPencarian.ToArray();
        }


        public string TampilkanDaftar()
        {
            KaryawanNode node = Head;
            StringBuilder kryw = new StringBuilder();

            while (node != null)
            {
                kryw.AppendLine($"{node.Karyawan.NomorKaryawan}; {node.Karyawan.Nama}; {node.Karyawan.Posisi}");
                node = node.Next;
            }
            return kryw.ToString().TrimEnd();
        }
    }
}