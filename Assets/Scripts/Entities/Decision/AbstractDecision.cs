using UnityEngine;

namespace Entities
{
    public abstract class AbstractDecision
    {

        private string _name;

        protected int _addedIncome;
        protected int _addedOutlay;
        protected int _addedPopularity;
        protected int _cost;

        public AbstractDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost)
        {
            _name = name;
            _addedIncome = addedIncome;
            _addedOutlay = addedOutlay;
            _addedPopularity = addedPopularity;
            _cost = cost;
        }
    }
}
