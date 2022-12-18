using UnityEngine;
using System;

namespace Entities
{
    // Add fabrics
    public abstract class AbstractDecision
    {
        public AbstractDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, 
            int cost, Business.BusinessTier decisionTier, int level = 0, int maxLevel = 5)
        {
            Name = name;
            AddedIncome = addedIncome;
            AddedOutlay = addedOutlay;
            AddedPopularity = addedPopularity;
            Cost = cost;
            DecisionTier = decisionTier;
            Level = level;
            MaxLevel = maxLevel;
        }
        public Business.BusinessTier DecisionTier { get; private set; }

        public string Name { get; private set; }
        
        public int AddedIncome { get; protected set; }
        
        public int AddedOutlay { get; protected set; }
        
        public int AddedPopularity { get; protected set; }
        
        public virtual int Cost { get; protected set; }
        
        public int Level { get; protected set; }

        public int MaxLevel { get; protected set; }


        public virtual void ApplyDecision(Business business)
        {
            if(this.Level == -1) return;
            
            business.ChangeIncome(AddedIncome);
            business.ChangeOutlay(AddedOutlay);
            business.ChangePopularity(AddedPopularity);
            this.Level++;
            Debug.Log("All parameter changes of the decision was applied!");
        } 

    }
}
