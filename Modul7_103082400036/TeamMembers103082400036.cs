using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_103082400036
{
    public class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TeamInfo
    {
        public List<TeamMember> members { get; set; }
    }

    public class TeamMembers103082400036
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103082400036.json");
            TeamInfo team = JsonSerializer.Deserialize<TeamInfo>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                // Format <nim> <firstname + lastname> (<age> <gender>)
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
