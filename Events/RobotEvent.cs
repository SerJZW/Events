namespace Events
{
    internal class RobotEvent
    {
        public delegate void RobotNotions();
        public event RobotNotions? Notion;
        private int GetDirection() => new Random().Next(3);
        public void DefineDirection()
        {
            switch (GetDirection())
            {
                case 0: Notion?.Invoke(); break;
                case 1: Console.WriteLine("Иду вверх"); break;
                case 2: Console.WriteLine("Иду влево"); break;
                case 3: Console.WriteLine("Иду вправо"); break;
            }
        }
        public void BackDirection()
        {
            using var sw = new StreamWriter("C:/Users/zemzh/OneDrive/Рабочий стол/Daybi.txt", true, System.Text.Encoding.Default);
            sw.WriteLine("Иду назад");
        }
    }
}
