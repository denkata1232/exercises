namespace hand_of_cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = CardGame();
            PrintDictionary(dictionary);
        }
        static Dictionary<string, int> CardGame()
        {
            List<string> cardsNumbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<char> cardsTypes = new List<char> { 'C', 'D', 'H', 'S' };
            Dictionary<string, int> playersPoints = new Dictionary<string, int>();
            List<string> playersCards = new List<string>();
            string input = Console.ReadLine();
            List<string> commands = new List<string>();
            string player = null;
            int i = 0;
            while (input != "JOKER")
            {
                commands.Add(input);
                input = Console.ReadLine();
            }
            commands.Sort();
            commands.Add("JOKER");
            int count = 0;
            input = commands[count];
            while(input != "JOKER")
            {
                if (player != null)
                if(input.Substring(0, player.Length+1) == player + ":")
                {
                    i = player.Length;
                    goto next;
                }
                playersCards.Clear();
                i = 0;
                player = null;
                next:
                int points = 0;
                for (; i < input.Length; i++)
                {
                    if (input[i] == ':')
                    {
                        break;
                    }
                    else
                    {
                        player += input[i];
                    }
                }
                for (; i < input.Length; i++)
                {
                    string num = null;
                    if (char.IsDigit(input[i]) && char.IsDigit(input[i+1]))
                    {
                        num += input[i].ToString() + input[i + 1].ToString();
                    }
                    if (cardsNumbers.Contains(input[i].ToString()) || cardsNumbers.Contains(num))
                    {
                        string card = null;
                        if (num != null && num.Length > 1)
                        {
                            card = input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString();
                            if (!playersCards.Contains(card))
                            {
                                int number = cardsNumbers.IndexOf(num.ToString()) + 1;
                                int multiplayer = cardsTypes.IndexOf(input[i + 2]) + 1;
                                points += number * multiplayer;
                                playersCards.Add(card);
                            }
                        }
                        else
                        {
                            card = input[i].ToString() + input[i + 1].ToString();
                            if (!playersCards.Contains(card))
                            {
                                int number = cardsNumbers.IndexOf(input[i].ToString()) + 1;
                                int multiplayer = cardsTypes.IndexOf(input[i + 1]) + 1;
                                points += number * multiplayer;
                                playersCards.Add(card);
                            }
                        }
                    }
                }
                if (playersPoints.ContainsKey(player))
                {
                    playersPoints[player] += points;
                }
                else
                {
                    playersPoints.Add(player, points);
                }
                count++;
                input = commands[count];
            }
            return playersPoints;
        }
        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach(var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        static void TestInput()
        {
            /*Pesho: 2C, 4H, 9H, AS, QS
Slav: 3H, 10S, JC, KD, 5S, 10S
Peshoslav: QH, QC, QS, QD
Slav: 6H, 7S, KC, KD, 5S, 10C
Peshoslav: QH, QC, JS, JD, JC
Pesho: JD, JD, JD, JD, JD, JD
JOKER*/
        }
    }
}