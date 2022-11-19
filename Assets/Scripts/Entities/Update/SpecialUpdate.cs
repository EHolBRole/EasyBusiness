using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public class SpecialUpdate : AbstractUpdate
    {

        public SpecialUpdate(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost)
        {

        }
    }
}
