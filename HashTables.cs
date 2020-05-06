namespace Exempel
{
    public class HashTables
    {
        private int[] m = new int[40]; //Längden på vår array
        public int GetHash(string C) {
            int h = 0;
            for(int i = 0; i < C.Length - 1; i++) {
                h = (h * C[i] + C[i]) % m.Length;
            }
            return h;
        }
        public int GetHashS(string C) {
            int h = 0;
            for(int i = 0; i < C.Length - 1; i++)
            {
                h += C[i] % m.Length;
            }
            return h;
        }        
    }
}