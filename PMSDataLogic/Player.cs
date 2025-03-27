using System;


namespace PMSDataLogic
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Player(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
    }
}
