using System;


namespace Modul7_103082400036
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400036 dataMhs = new DataMahasiswa103082400036();
            dataMhs.ReadJSON();

            Console.WriteLine();

            TeamMembers103082400036 team = new TeamMembers103082400036();
            team.ReadJSON();

            Console.WriteLine();

            GlossaryItem103082400036 gloss = new GlossaryItem103082400036();
            gloss.ReadJSON();
        }
    }
}