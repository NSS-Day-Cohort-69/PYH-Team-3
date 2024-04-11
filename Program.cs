List<GangMembers> gangMembers = new List<GangMembers>() { };

string greeting = "Plan Your Heist!";

Console.WriteLine(greeting);
Console.WriteLine();
AddATeamMember();

void AddATeamMember()
{
    Console.WriteLine("How Difficult will this bank be? (1-Infinity and Beyond)");
    int bankPresetDifficulty = int.Parse(Console.ReadLine().Trim()); // At the beginning of the program, prompt the user to enter the difficulty level of the bank.

    Random random = new Random();

    string NameResponse = "abc";

    while (!string.IsNullOrEmpty(NameResponse))
    {
        Console.WriteLine("Please enter a team member name:");
        NameResponse = Console.ReadLine().Trim();
        if (string.IsNullOrEmpty(NameResponse))
        {
            break;
        }
        Console.WriteLine("Please enter team members skill level:");
        int SkillLevelResponse = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine(
            "\nPlease enter team members courage factor.\nPlease enter a decimal between 0.0 and 2.0:"
        );
        decimal CourageFactorResponse = decimal.Parse(Console.ReadLine().Trim());

        GangMembers newGangMember = new GangMembers()
        {
            Name = NameResponse,
            SkillLevel = SkillLevelResponse,
            CourageFactor = CourageFactorResponse
        };

        gangMembers.Add(newGangMember);

        //    Console.WriteLine($"You have entered {newGangMember.Name} with a Skill Level of: {newGangMember.SkillLevel} and a courage level of: {newGangMember.CourageFactor}");
    }
    ;
    Console.WriteLine($"Gang memebers : {gangMembers.Count}"); // Display a message containing the number of members of the team.
    int SkillLevelTotal = 0; // Sum the skill levels of the team. Save that number.
    foreach (GangMembers gangmember in gangMembers)
    {
        SkillLevelTotal += gangmember.SkillLevel;
    }

    Console.WriteLine($"SkillSum: {SkillLevelTotal}");
    Console.WriteLine("Enter desired trial runs: ");
    int trialRuns = int.Parse(Console.ReadLine().Trim());
    int failedAttempt = 0;
    int completedAttempt = 0;

    while (trialRuns > 0)
    {
        int luckValue = random.Next(-10, 11);
        int banksDifficulty = bankPresetDifficulty; // Store a value for the bank's difficulty level. Set this value to 100.
        // Setting Bankdifficulty to Preset to avoid, 1. 110, 2. 120.

        banksDifficulty += luckValue;
        Console.WriteLine($"Bank Difficulty level: {banksDifficulty}");

        if (SkillLevelTotal >= banksDifficulty) // Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
        {
            Console.WriteLine("Success! You lived a life of crime.");
            completedAttempt++;
        }
        else
        {
            Console.WriteLine("Agh.. Jail time.");
            failedAttempt++;
        }
        trialRuns--;
    }

    // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
    Console.WriteLine(
        @$"
    Successful Runs: {completedAttempt}
    Failed Runs: {failedAttempt}"
    );
}

// int i = 1;
// foreach (GangMembers gm in gangMembers) // Stop displaying each team member's information.
// {
//     Console.WriteLine("Gang member details");
//     Console.WriteLine(
//         $"{i}. Name : {gm.Name} Skill Level : {gm.SkillLevel} and Courage factor : {gm.CourageFactor}"
//     );
// }
