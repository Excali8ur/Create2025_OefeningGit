using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    public class ADTStapel
    {
        private int[] stapel = new int[20];
        private int index = -1;

        public string Push(int waarde)
        {
            if (index < stapel.Length -1)
            {
                index++;
                stapel[index] = waarde;
                return $"Waarde {waarde} toegevoegd op index {index}.";
            }
            return $"Stapel is vol, {waarde} niet toegevoegd.";
        }

        public string Pop()
        {
            if (index >= 0)
            {
                int waarde = stapel[index];
                index--;
                return $"Waarde {waarde} verwijderd van de stapel.";
            }
            return "Stapel is leeg.";
        }

        public string ToonStapel()
        {
            if (index < 0)
            {
                return "Stapel is leeg.";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inhoud van de stapel:");
            for (int i = 0; i <= index; i++)
            {
                sb.AppendLine($"Index {i}: {stapel[i]}");
            }
            return sb.ToString();
        }
    }
}
