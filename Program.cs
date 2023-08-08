using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_end_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string choice;

            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players 6: Exit");

                int menuChoice = int.Parse(Console.ReadLine());


                switch (menuChoice)
                {
                    case 1:

                        Console.Write("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        team.Add(new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge });
                        Console.WriteLine("Player is added Successfully");
                        break;
                    case 2:

                        Console.Write("Enter Player Id to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        team.Remove(removeId);
                        break;
                    case 3:

                        Console.Write("Enter Player Id : ");
                        int getId = Convert.ToInt32(Console.ReadLine());
                        Player getPlayerById = team.GetPlayerById(getId);
                        if (getPlayerById != null)
                        {
                            Console.WriteLine($"Player {getPlayerById.PlayerName} is {getPlayerById.PlayerAge} years old.");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 4:

                        Console.Write("Enter Player Name : ");
                        string getName = Console.ReadLine();
                        Player getPlayerByName = team.GetPlayerByName(getName);
                        if (getPlayerByName != null)
                        {
                            Console.WriteLine($"Player {getPlayerByName.PlayerName} is {getPlayerByName.PlayerAge} years old.");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 5:

                        List<Player> allPlayers = team.GetAllPlayers();
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Player Id: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                        }
                        break;
                    case 6:

                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.Write("Do you want to continue (yes/no)?: ");
                choice = Console.ReadLine();
            }
            while (choice.ToLower() == "yes");

        }
    }
}
