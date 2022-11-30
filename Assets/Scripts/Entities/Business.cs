using UnityEngine;
using System.Collections.Generic;

namespace Entities
{
    public class Business
    {
        private List<AbstractDecision> _avaiableDecisionsList = new List<AbstractDecision>();

        public List<Business> nextTierBusinessList = new List<Business>(); // Restruct All System with Business and it's Tiers. Need to make better Architecture
        // Maybe it's good decision to use Abstract Fabric pattern here. Need to think of it.

        public Business(string name, int income, int outlay, int popularity, 
            int startBalance, Sprite businessSprite, BusinessTier tier, List<Business> businesses) 
        {
            Name = name;
            Income = income;
            Outlay = outlay;
            Popularity = popularity;
            StartBalance = startBalance;
            BusinessSprite = businessSprite;
            Tier = tier;
            nextTierBusinessList.AddRange(businesses);
        }

        public string Name { get; private set; }

        public int Income { get; private set; }
        
        public int Outlay { get; private set; }
        
        public int Popularity { get; private set; }
        
        public int StartBalance { get; private set; }
        
        public BusinessTier Tier { get; private set; }
        
        public Sprite BusinessSprite { get; private set; }

        public string ShowAllAvaiableDecisions()
        {
            string allDecisionsString = "";

            foreach (var decision in _avaiableDecisionsList)
            {
                allDecisionsString += decision.ToString() + "\n";
            }

            return allDecisionsString;
        }

        public void AddDecisionToAvaiableDecisionsList(AbstractDecision decision)
        {
            _avaiableDecisionsList.Add(decision);
            Debug.Log($"Added New Decision to {Name} Business list");
        }

        public void ChangeIncome(int income)
        {
            Income += income;
            Debug.Log($"Income of Business: {Name} has changed");
        }

        public void ChangeOutlay(int outlay)
        {
            Outlay += outlay;
            Debug.Log($"Outlay of Business: {Name} has changed");

        }
        
        public void ChangePopularity(int popularity)
        {
            Popularity += popularity;
            Debug.Log($"Popularity of Business: {Name} has changed");
        }

        public int ProceedNetworth() => Income - Outlay;
        
        public override string ToString()
        {
            return $"Your business name: {Name} \n" +
                $"Your income: {Income} \n" +
                $"Your outlay: {Outlay} \n" +
                $"Your popularity: {Popularity} \n";
        }

        public enum BusinessTier
        {
            BaseTier,
            FirstTier,
            SecondTier,
            ThirdTier
        }
    }
}