using System.Text;

namespace ParosTomb
{

    class ParosTomb
    {
        //propertik
        private int[] Tomb { get; set; }
        public int Length
        {
            get
            {
                return this.Tomb.Length;
            }
        }

        //konstruktor
        public ParosTomb(int meret)
        {
            Tomb = new int[meret];
        }


        public int this[int szam]
        {
            get
            {
                return this.Tomb[szam];
            }
            set
            {
                if (value % 2 == 0)
                {
                    this.Tomb[szam] = value;
                }
                else
                {
                    throw new System.Exception("Ez a szám páratlan!!!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<");
            for (int i = 0; i < this.Tomb.Length - 1; i++)
            {
                sb.Append($"{this[i]},");
            }

            sb.Append($"{this[this.Tomb.Length-1]}> ");


            return sb.ToString();
        }


    }
}

