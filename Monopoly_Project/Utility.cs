using System;

namespace Monopoly_Project
{
    class Utility
    {
        String name;
        int cost;
        bool owned;
        Player owner;
        bool mortgaged;
        int mortgageValue;
        public Utility(String name)
        {
            this.name = name;
            cost = 150;
            mortgageValue = 75;

        }
        public String getName()
        {
            return name;
        }
        public int getCost()
        {
            return cost;
        }
        public int getRentModifier()
        {
            int toret;
            if (owner != null)
            {
                if (owner.getUtilityCount() == 1)
                {
                    return 4;
                }
                else if (owner.getUtilityCount() == 2)
                {
                    return 10;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                toret = 0;
            }
            return toret;
        }
        public int mortgageUtility()
        {
            owner.decrementUtilityCount();
            mortgaged = true;
            return mortgageValue;
        }
        public int buyBackUtility()
        {
            mortgaged = false;
            owner.incrementUtilityCount();
            int toret = mortgageValue / 10;
            return mortgageValue + toret;
        }
        public bool isMortgaged()
        {
            return mortgaged;
        }
        public bool isOwned()
        {
            return owned;
        }
        public Player getOwner()
        {
            return owner;
        }
        public int getMortgageValue()
        {
            return mortgageValue;
        }
        public void setOwner(Player player)
        {
            this.owner = player;
            this.owned = true;
        }
    }
}
