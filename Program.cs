List<GangMembers> gangMembers = new List<GangMembers>()
{
    
};



string greeting = "Plan Your Heist!";

Console.WriteLine(greeting);
Console.WriteLine();
AddATeamMember();


void AddATeamMember()
{
    Console.WriteLine("Please enter a team member name:");
    string NameResponse = Console.ReadLine().Trim();

    Console.WriteLine("Please enter team members skill level:");
    int SkillLevelResponse = int.Parse(Console.ReadLine().Trim());

    Console.WriteLine(@"Please enter team members courage factor.
                
            Please enter a decimal between 0.0 and 2.0:");
    decimal CourageFactorResponse = decimal.Parse(Console.ReadLine().Trim());

    GangMembers newGangMember = new GangMembers()
    {
        Name = NameResponse,
        SkillLevel = SkillLevelResponse,
        CourageFactor = CourageFactorResponse
    };

    gangMembers.Add(newGangMember);

   Console.WriteLine($"You have entered {newGangMember.Name} with a Skill Level of: {newGangMember.SkillLevel} and a courage level of: {newGangMember.CourageFactor}");
}
