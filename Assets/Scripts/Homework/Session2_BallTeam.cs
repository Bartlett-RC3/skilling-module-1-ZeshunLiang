using System;
namespace BallTeam
{
    class dog
    {
        //VARIABLES 
        string name;
        string role;
        int power;

        //CONSTRUCTOR
        public dog(string _name, string  _role, int _power)
        {
            name = _name;
            role = _role;
            power = _power;
        }

        //BEHAVIOURS(functions)
        public string Getname()
        {
            return name;
        }

        public string Getrole()
        {
            return role;
        }

        public int Getpower()
        {
            return power;
        }

        public void Running()
        {
            //Action here
        }
        public void Shooting()
        {
            //Actions here
        }

    }
}
