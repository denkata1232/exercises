namespace robot_movement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try input -> L20R10LL20R10R30*/
            string command = Console.ReadLine();
            RobotMove(command);
        }
        static void RobotMove(string command)
        {
            int x = 0;
            int y = 0;
            int direction = 1;
            string num = null;
            int addedDis = 0;
            for(int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'R')
                {
                    if(direction == 1)
                    {
                        direction = 4;
                    }
                    else
                    {
                        direction--;
                    }
                }
                else if (command[i] == 'L')
                {
                    if(direction == 4)
                    {
                        direction = 1;
                    }
                    else
                    {
                        direction++;
                    }
                }
                else if(char.IsDigit(command[i]))
                {
                    while (char.IsDigit(command[i]))
                    {
                        num += command[i];
                        i++;
                        if (i >= command.Length)
                        {
                            break;
                        }
                    }
                    addedDis = int.Parse(num);
                    num = null;
                    i--;
                }
                if(direction == 1)
                {
                    x += addedDis;
                    addedDis = 0;
                }
                else if (direction == 2)
                {
                    y += addedDis;
                    addedDis = 0;
                }
                else if (direction == 3)
                {
                    x -= addedDis;
                    addedDis = 0;
                }
                else if (direction == 4)
                {
                    y -= addedDis;
                    addedDis = 0;
                }
            }
            double dist = Math.Sqrt(x * x + y * y);
            Console.WriteLine($"Position: (x:{x}, y:{y}), Distance = {dist:f2} m");
        }
    }
}