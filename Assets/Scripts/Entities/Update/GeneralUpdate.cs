using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public class GeneralUpdate : AbstractUpdate
    {

        public GeneralUpdate(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost)
        {
            
        }
    }
}