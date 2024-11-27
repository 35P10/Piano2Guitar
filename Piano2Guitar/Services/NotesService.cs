using Piano2Guitar.Models;

namespace Piano2Guitar.Services
{
    public static class NotesService
    {
        public static Dictionary<int, Note> ListOfNotes = new Dictionary<int, Note>
        {
            // Octava 2
            {21, new Note("C", 2, 21)},
            {22, new Note("C#", 2, 22, true)},
            {23, new Note("D", 2, 23)},
            {24, new Note("D#", 2, 24, true)},
            {25, new Note("E", 2, 25, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,0)
            })},
            {26, new Note("F", 2, 26, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,1)
            })},
            {27, new Note("F#", 2, 27, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,2)
            }, true)},
            {28, new Note("G", 2, 28, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,3)
            })},
            {29, new Note("G#", 2, 29, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,4)
            }, true)},
            {210, new Note("A", 2, 210, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,5),
                new Tuple<int,int>(5,0)
            })},
            {221, new Note("A#", 2, 221, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,6),
                new Tuple<int,int>(5,1)
            }, true)},
            {222, new Note("B", 2, 222, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,7),
                new Tuple<int,int>(5,2)
            })},
            // Octava 3
            {31, new Note("C", 3, 31, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,8),
                new Tuple<int,int>(5,3)
            })},
            {32, new Note("C#", 3, 32, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,9),
                new Tuple<int,int>(5,4)
            })},
            {33, new Note("D", 3, 33, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,10),
                new Tuple<int,int>(5,5),
                new Tuple<int,int>(4,0)
            })},
/*
            { 14, new Note("F#", 3, 14, 6, 14) },
            { 15, new Note("G", 3, 15, 5, 10) },
            { 16, new Note("G#", 3, 16, 5, 11) },
            { 17, new Note("A", 3, 17, 5, 0) },
            { 18, new Note("A#", 3, 18, 5, 1) },
            { 19, new Note("B", 3, 19, 4, 2) },
            { 20, new Note("C", 3, 20, 4, 3) },
            { 21, new Note("C#", 3, 21, 5, 4) },
            { 22, new Note("D", 3, 22, 5, 5) },
            { 23, new Note("D#", 3, 23, 5, 6) },
            { 24, new Note("E", 3, 24, 5, 7) },

            // Octava 4
            { 25, new Note("F", 4, 25, 4, 1) },
            { 26, new Note("F#", 4, 26, 4, 2) },
            { 27, new Note("G", 4, 27, 3, 3) },
            { 28, new Note("G#", 4, 28, 3, 4) },
            { 29, new Note("A", 4, 29, 3, 5) },
            { 30, new Note("A#", 4, 30, 3, 6) },
            { 31, new Note("B", 4, 31, 3, 7) },
            { 32, new Note("C", 4, 32, 3, 8) },
            { 33, new Note("C#", 4, 33, 3, 9) },
            { 34, new Note("D", 4, 34, 3, 10) },
            { 35, new Note("D#", 4, 35, 3, 11) },
            { 36, new Note("E", 4, 36, 3, 12) },

            // Octava 5
            { 37, new Note("F", 5, 37, 2, 1) },
            { 38, new Note("F#", 5, 38, 2, 2) },
            { 39, new Note("G", 5, 39, 2, 3) },
            { 40, new Note("G#", 5, 40, 2, 4) },
            { 41, new Note("A", 5, 41, 2, 5) },
            { 42, new Note("A#", 5, 42, 2, 6) },
            { 43, new Note("B", 5, 43, 2, 7) },
            { 44, new Note("C", 5, 44, 2, 8) },
            { 45, new Note("C#", 5, 45, 2, 9) },
            { 46, new Note("D", 5, 46, 2, 10) },
            { 47, new Note("D#", 5, 47, 2, 11) },
            { 48, new Note("E", 5, 48, 2, 12) },

            // Octava 6
            { 49, new Note("F", 6, 49, 1, 1) },
            { 50, new Note("F#", 6, 50, 1, 2) },
            { 51, new Note("G", 6, 51, 1, 3) },
            { 52, new Note("G#", 6, 52, 1, 4) },
            { 53, new Note("A", 6, 53, 1, 5) },
            { 54, new Note("A#", 6, 54, 1, 6) },
            { 55, new Note("B", 6, 55, 1, 7) },
            { 56, new Note("C", 6, 56, 1, 8) },
            { 57, new Note("C#", 6, 57, 1, 9) },
            { 58, new Note("D", 6, 58, 1, 10) },
            { 59, new Note("D#", 6, 59, 1, 11) },
            { 60, new Note("E", 6, 60, 1, 12) }
*/
        };
    }
}
