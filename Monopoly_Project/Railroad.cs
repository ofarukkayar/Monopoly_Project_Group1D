using System;

namespace Monopoly_Project
{
    class Railroad
    {
        //prop
        String name;
        int cost;
        int rent;
        int mortgageValue;
        bool owned;
        Player owner;
        bool mortgaged;
        //const
        public Railroad(String name)
        {
            this.name = name;
            cost = 200;
            rent = 25;
            mortgageValue = 100;
            owned = false;
            owner = null;
            mortgaged = false;
        }
        //mutators
        public String getName()
        {
            return name;
        }
        public int getCost()
        {
            return cost;
        }
        public int getRent()
        {
            int toret;
            if (owner != null)
            {
                toret = (owner.getRailroadCount() * rent);
            }
            else
            {
                toret = 25;
            }
            return toret;
        }
        public int mortgageRailroad()
        {
            owner.decrementRailroadCount();
            mortgaged = true;
            return mortgageValue;
        }
        public int buyBackRailroad()
        {
            int toret = mortgageValue / 10;
            mortgaged = false;
            owner.incrementRailroadCount();
            return toret + mortgageValue;
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
        public void setOwner(Player player)
        {
            this.owner = player;
            this.owned = true;
        }
        public int getMortgageValue()
        {
            return mortgageValue;
        }
    }
}
