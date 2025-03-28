namespace LinkedList.Perpustakaan
{
    public class BukuNode
    {
        public Buku Data { get; set; }
        public BukuNode Next { get; set; }

        public BukuNode(Buku data)
        {
            Data = data;
            Next = null;
        }
    }
}