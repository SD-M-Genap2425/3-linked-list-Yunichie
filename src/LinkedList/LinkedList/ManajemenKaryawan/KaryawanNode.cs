namespace LinkedList.ManajemenKaryawan
{
    public class KaryawanNode
    {
        public Karyawan Karyawan;
        public KaryawanNode Next, Prev;

        public KaryawanNode(Karyawan data)
        {
            Karyawan = data;
            Next = null;
            Prev = null;
        }
    }
}