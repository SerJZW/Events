using Events;

class Programm
{
    static void Main(string[] args)
    {
        RobotEvent robot = new RobotEvent();
        robot.Notion += robot.BackDirection;
        for (int i = 0; i < 10; i++)
        {
            robot.DefineDirection();
        }

    }
}