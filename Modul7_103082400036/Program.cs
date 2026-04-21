using System;


namespace Modul7_103082400044
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400044 dataMhs = new DataMahasiswa103082400044();
            dataMhs.ReadJSON();

            Console.WriteLine();

            TeamMembers103082400044 team = new TeamMembers103082400044();
            team.ReadJSON();

            Console.WriteLine();

            GlossaryItem103082400044 gloss = new GlossaryItem103082400044();
            gloss.ReadJSON();
        }
    }
}