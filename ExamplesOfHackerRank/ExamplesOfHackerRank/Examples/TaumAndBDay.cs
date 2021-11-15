namespace ExamplesOfHackerRank.Examples
{
    public class TaumAndBDay
    {
        public long taumBday(int b, int w, int bc, int wc, int z)
        {
            int realBc = 0;
            int realWc = 0;

            if(bc + z < wc){
                realBc = bc;
                realWc = bc +z;
            }
            else if(wc + z < bc){
                realBc = wc + z;
                realWc = wc;
            }
            else{
                realBc = bc;
                realWc = wc;
            }

            return (b * (long)realBc) + (w * (long)realWc);
        }
    }
}