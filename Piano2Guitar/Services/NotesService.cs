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
            }, true)},
            {33, new Note("D", 3, 33, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,10),
                new Tuple<int,int>(5,5),
                new Tuple<int,int>(4,0)
            })},
            {34, new Note("D#", 3, 34, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,11),
                new Tuple<int,int>(5,6),
                new Tuple<int,int>(4,1)
            }, true)},
            {35, new Note("E", 3, 35, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,12),
                new Tuple<int,int>(5,7),
                new Tuple<int,int>(4,2)
            })},
            {36, new Note("F", 3, 36, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,13),
                new Tuple<int,int>(5,8),
                new Tuple<int,int>(4,3)
            })},
            {37, new Note("F#", 3, 37, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,14),
                new Tuple<int,int>(5,9),
                new Tuple<int,int>(4,4)
            }, true)},
            {38, new Note("G", 3, 38, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,15),
                new Tuple<int,int>(5,10),
                new Tuple<int,int>(4,5),
                new Tuple<int,int>(3,0)
            })},
            {39, new Note("G#", 3, 39, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,16),
                new Tuple<int,int>(5,11),
                new Tuple<int,int>(4,6),
                new Tuple<int,int>(3,1)
            }, true)},
            {310, new Note("A", 3, 310, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,17),
                new Tuple<int,int>(5,12),
                new Tuple<int,int>(4,7),
                new Tuple<int,int>(3,2)
            })},
            {311, new Note("A#", 3, 311, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,18),
                new Tuple<int,int>(5,13),
                new Tuple<int,int>(4,8),
                new Tuple<int,int>(3,3)
            }, true)},
            {312, new Note("B", 3, 312, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,19),
                new Tuple<int,int>(5,14),
                new Tuple<int,int>(4,9),
                new Tuple<int,int>(3,4),
                new Tuple<int,int>(2,0)
            })},
            // Octava 4
            {41, new Note("C", 4, 41, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,20),
                new Tuple<int,int>(5,15),
                new Tuple<int,int>(4,10),
                new Tuple<int,int>(3,5),
                new Tuple<int,int>(2,1)
            })},
            {42, new Note("C#", 4, 42, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,21),
                new Tuple<int,int>(5,16),
                new Tuple<int,int>(4,11),
                new Tuple<int,int>(3,6),
                new Tuple<int,int>(2,2)
            }, true)},
            {43, new Note("D", 4, 43, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,22),
                new Tuple<int,int>(5,17),
                new Tuple<int,int>(4,12),
                new Tuple<int,int>(3,7),
                new Tuple<int,int>(2,3)
            })},
            {44, new Note("D#", 4, 44, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,23),
                new Tuple<int,int>(5,18),
                new Tuple<int,int>(4,13),
                new Tuple<int,int>(3,8),
                new Tuple<int,int>(2,4)
            }, true)},
            {45, new Note("E", 4, 45, new List<Tuple<int,int>>{
                new Tuple<int,int>(6,24),
                new Tuple<int,int>(5,19),
                new Tuple<int,int>(4,14),
                new Tuple<int,int>(3,9),
                new Tuple<int,int>(2,5),
                new Tuple<int,int>(1,0)
            })},
            {46, new Note("F", 4, 46, new List<Tuple<int,int>>{
                new Tuple<int,int>(5,20),
                new Tuple<int,int>(4,15),
                new Tuple<int,int>(3,10),
                new Tuple<int,int>(2,6),
                new Tuple<int,int>(1,1)
            })},
            {47, new Note("F#", 4, 47, new List<Tuple<int,int>>{
                new Tuple<int,int>(5,21),
                new Tuple<int,int>(4,16),
                new Tuple<int,int>(3,11),
                new Tuple<int,int>(2,7),
                new Tuple<int,int>(1,2)
            }, true)},
            {48, new Note("G", 4, 48, new List<Tuple<int,int>>{
                new Tuple<int,int>(5,22),
                new Tuple<int,int>(4,17),
                new Tuple<int,int>(3,12),
                new Tuple<int,int>(2,8),
                new Tuple<int,int>(1,3)
            })},
            {49, new Note("G#", 4, 49, new List<Tuple<int,int>>{
                new Tuple<int,int>(5,23),
                new Tuple<int,int>(4,18),
                new Tuple<int,int>(3,13),
                new Tuple<int,int>(2,9),
                new Tuple<int,int>(1,4)
            }, true)},
            {410, new Note("A", 4, 410, new List<Tuple<int,int>>{
                new Tuple<int,int>(5,24),
                new Tuple<int,int>(4,19),
                new Tuple<int,int>(3,14),
                new Tuple<int,int>(2,10),
                new Tuple<int,int>(1,5)
            })},
            {411, new Note("A#", 4, 411, new List<Tuple<int,int>>{
                new Tuple<int,int>(4,20),
                new Tuple<int,int>(3,15),
                new Tuple<int,int>(2,11),
                new Tuple<int,int>(1,6)
            })},
            {412, new Note("B", 4, 412, new List<Tuple<int,int>>{
                new Tuple<int,int>(4,21),
                new Tuple<int,int>(3,16),
                new Tuple<int,int>(2,12),
                new Tuple<int,int>(1,7)
            })},
            // Octava 5
            {51, new Note("C", 5, 51, new List<Tuple<int,int>>{
                new Tuple<int,int>(4,22),
                new Tuple<int,int>(3,17),
                new Tuple<int,int>(2,13),
                new Tuple<int,int>(1,8)
            })},
            {52, new Note("C#", 5, 52, new List<Tuple<int,int>>{
                new Tuple<int,int>(4,23),
                new Tuple<int,int>(3,18),
                new Tuple<int,int>(2,14),
                new Tuple<int,int>(1,9)
            }, true)},
            {53, new Note("D", 5, 53, new List<Tuple<int,int>>{
                new Tuple<int,int>(4,24),
                new Tuple<int,int>(3,19),
                new Tuple<int,int>(2,15),
                new Tuple<int,int>(1,10)
            })},
            {54, new Note("D#", 5, 54, new List<Tuple<int,int>>{
                new Tuple<int,int>(3,20),
                new Tuple<int,int>(2,16),
                new Tuple<int,int>(1,11)
            }, true)},
            {55, new Note("E", 5, 55, new List<Tuple<int,int>>{
                new Tuple<int,int>(3,21),
                new Tuple<int,int>(2,17),
                new Tuple<int,int>(1,12)
            })},
            {56, new Note("F", 5, 56, new List<Tuple<int,int>>{
                new Tuple<int,int>(3,22),
                new Tuple<int,int>(2,18),
                new Tuple<int,int>(1,13)
            })},
            {57, new Note("F#", 5, 57, new List<Tuple<int,int>>{
                new Tuple<int,int>(3,23),
                new Tuple<int,int>(2,19),
                new Tuple<int,int>(1,14)
            }, true)},
            {58, new Note("G", 5, 48, new List<Tuple<int,int>>{
                new Tuple<int,int>(3,24),
                new Tuple<int,int>(2,20),
                new Tuple<int,int>(1,15)
            })},
            {59, new Note("G#", 5, 59, new List<Tuple<int,int>>{
                new Tuple<int,int>(2,21),
                new Tuple<int,int>(1,16)
            }, true)},
            {510, new Note("A", 5, 510, new List<Tuple<int,int>>{
                new Tuple<int,int>(2,22),
                new Tuple<int,int>(1,17)
            })},
            {511, new Note("A#", 5, 511, new List<Tuple<int,int>>{
                new Tuple<int,int>(2,23),
                new Tuple<int,int>(1,18)
            }, true)},
            {512, new Note("B", 5, 512, new List<Tuple<int,int>>{
                new Tuple<int,int>(2,24),
                new Tuple<int,int>(1,19)
            })},
            // Octava 6
            {61, new Note("C", 6, 61, new List<Tuple<int,int>>{
                new Tuple<int,int>(1,20)
            })},
            {62, new Note("C#", 6, 62, new List<Tuple<int,int>>{
                new Tuple<int,int>(1,21)
            }, true)},
            {63, new Note("D", 6, 63, new List<Tuple<int,int>>{
                new Tuple<int,int>(1,22)
            })},
            {64, new Note("D#", 6, 64, new List<Tuple<int,int>>{
                new Tuple<int,int>(1,23)
            }, true)},
            {65, new Note("E", 6, 65, new List<Tuple<int,int>>{
                new Tuple<int,int>(1,24)
            })},
            {66, new Note("F", 6, 66)},
            {67, new Note("F#", 6, 67, true)},
            {68, new Note("G", 6, 68)},
            {69, new Note("G#", 6, 69, true)},
            {610, new Note("A", 6, 610)},
            {611, new Note("A#", 6, 611, true)},
            {612, new Note("B", 6, 612)},
        };
    }
}
