// The program should be updated to...

// Create a way to store several team members.
// Collect several team members' information.
// Stop collecting team members when a blank name is entered.

// Display each team member's information.

List<GangMembers> gangMembers = new List<GangMembers>()
{
    
};



string greeting = "Plan Your Heist!";

Console.WriteLine(greeting);
Console.WriteLine();
AddATeamMember();


void AddATeamMember()
{
    string NameResponse ="abc";
   
    while(!string.IsNullOrEmpty(NameResponse))
    {
    Console.WriteLine("Please enter a team member name:");
    NameResponse = Console.ReadLine().Trim();
    if(string.IsNullOrEmpty(NameResponse))
    {
        break;
    }
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

//    Console.WriteLine($"You have entered {newGangMember.Name} with a Skill Level of: {newGangMember.SkillLevel} and a courage level of: {newGangMember.CourageFactor}");
    };
    // Display a message containing the number of members of the team.
    Console.WriteLine($"Gang memebers : {gangMembers.Count}");
    int i=1;
    foreach(GangMembers gm in gangMembers)
    {
        Console.WriteLine("Gang member details");
        Console.WriteLine($"{i}. Name : {gm.Name} Skill Level : {gm.SkillLevel} and Courage factor : {gm.CourageFactor}");
    }
    
}
