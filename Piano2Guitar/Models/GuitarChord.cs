namespace Piano2Guitar.Models
{
    public class GuitarChord
    {
        //strings : 1 - 6
        public int[] Notes = new int[6];
        public int Id = 0;

        public GuitarChord()
        {
            for (int i = 0; i < 6; i++)
            {
                Notes[i] = -1;
            }
        }

        public GuitarChord(Tuple<int, int> position)
        {
            for (int i = 0; i < 6; i++)
            {
                Notes[i] = -1;
            }
            AddNote(position);
        }

        public void AddNote(Tuple<int,int> position)
        {
            Notes[position.Item1 - 1] = position.Item2;
        }

        public void DeleteNote(Tuple<int, int> position)
        {
            Notes[position.Item1 - 1] = -1;
        }

        public void DeleteNote(int _string)
        {
            Notes[_string - 1] = -1;
        }
    }
}
