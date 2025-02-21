using Microsoft.VisualBasic;

Console.Clear();
/*
Console.WriteLine(@"-----------------------------------------------------------------------------------------------
|                                Welcome to the game of sticks!                               |
| The rules are simple: players will take turns choosing at least 1 and no more than 3 of the |
|   remaining sticks until the sticks are gone. The player that takes the last stick loses.   |
-----------------------------------------------------------------------------------------------"); // Step One
*/
int numSticks = 20; // Step Two
int currentPlayer = 1; // Step Three

while (numSticks >0)
{
    Console.WriteLine(@"
-----------------------------------------------------------------------------------------------
|                                Welcome to the game of sticks!                               |
| The rules are simple: players will take turns choosing at least 1 and no more than 3 of the |
|   remaining sticks until the sticks are gone. The player that takes the last stick loses.   |
-----------------------------------------------------------------------------------------------"); // Step One moved because it looked neat
    // Visual representation of how many sticks are left
    Console.Write("                              Sticks left: ");
    for (int i = 0; i < numSticks; i ++)
    {
        Console.Write("|");
    }
    Console.Write("\n");

    // Prompt player to pick up sticks
    int maxSticks = 3;  // Step Four
    if (numSticks < maxSticks) // Step Five
        maxSticks = numSticks; 
    Console.Write($"Player {currentPlayer}: Pick a number between 1 and {maxSticks} "); // Step Six
    int selectedSticks = Convert.ToInt32(Console.ReadLine());
    while (true)
    {
        if (selectedSticks > maxSticks || selectedSticks < 0) // Step Seven
        {
            Console.Write("That is not a valid number, pick again: ");
            selectedSticks = Convert.ToInt32(Console.ReadLine());
        }
        else
        break;
    };
    // Switch Players and adjust remaining sticks 
    numSticks -= selectedSticks; // Step Eight
    if (currentPlayer == 1) // Step Nine
        currentPlayer = 2;
    else
        currentPlayer = 1;
    if (numSticks == 0)
    {
        Console.Write($"Player {currentPlayer} wins!");
        break;
    }
    else
        Console.Clear();
}