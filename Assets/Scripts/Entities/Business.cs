using UnityEngine;

namespace Entities
{
    public class Business
    {

        private string _name;

        private int _income;
        private int _outlay;
        private int _popularity;
        private int _startBalance;

        public Business(string name, int income, int outlay, int popularity, int startBalance)
        {
            _name = name;
            _income = income;
            _outlay = outlay;
            _popularity = popularity;
            _startBalance = startBalance;
        }

    }
}