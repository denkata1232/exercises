namespace immune_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VirusAttack();
        }
        static void VirusAttack()
        {
            double immuneSystemHealth = double.Parse(Console.ReadLine());
            double originalHealyh = immuneSystemHealth;
            string virusName = Console.ReadLine();
            bool alive = true;
            List<string> viruses = new List<string>();
            while (immuneSystemHealth > 0 && virusName != "end")
            {
                int virusPower = 0;
                for (int i = 0; i < virusName.Length; i++)
                {
                    virusPower += virusName[i];
                }
                virusPower /= 3;
                immuneSystemHealth = Health(virusName, immuneSystemHealth, viruses);
                if (immuneSystemHealth <= 0) { alive = false; break; }
                int timeForDefeat = HelpForTimeSpan(virusName);
                TimeSpan ts = TimeSpan.FromSeconds(timeForDefeat);
                Console.WriteLine($"{virusName}: {virusPower} => {ts}");
                Console.WriteLine($"remaining health: {immuneSystemHealth}");
                if (immuneSystemHealth + immuneSystemHealth * 0.2 > originalHealyh)
                {
                    immuneSystemHealth = originalHealyh;
                }
                else
                {
                    immuneSystemHealth += immuneSystemHealth * 0.2;
                }
                viruses.Add(virusName);
                viruses.Distinct();
                virusName = Console.ReadLine();
            }
            if (alive)
            {
                Console.WriteLine($"Final Health: {immuneSystemHealth:f0}");
            }
            else
            {
                Console.WriteLine("Immune System defeated");
            }
        }
        static double Health(string virusName, double immuneSystemHealth, List<string> viruses)
        {
            int virusPower = 0;
            for (int i = 0; i < virusName.Length; i++)
            {
                virusPower += virusName[i];
            }
            virusPower /= 3;
            if (viruses.Contains(virusName))
            {
                immuneSystemHealth = Math.Round(immuneSystemHealth - ((virusPower * virusName.Length)/3));
            }
            else
            {
                immuneSystemHealth = Math.Round(immuneSystemHealth - (virusPower * virusName.Length));
            }
            return immuneSystemHealth;
        }
        static int HelpForTimeSpan(string virusName)
        {
            int virusPower = 0;
            for (int i = 0; i < virusName.Length; i++)
            {
                virusPower += virusName[i];
            }
            virusPower /= 3;
            int timeForDefeat = virusPower * virusName.Length;
            return timeForDefeat;
        }
    }
}