using System;

namespace Monopoly_Project
{
    public enum PropertyColor
    {
        green,
        red,
        orange,
        yellow,
        pink,
        brown,
        darkBlue,
        lightBlue
    }
    class Property
    {
        //prop
        String name;
        PropertyColor propertyColor;
        int[] rent;// = new int[6];
        int cost;
        bool owned;
        bool mortgaged;
        Player owner;
        int houseCost;
        int mortgageValue;
        int houseCount;
        int hotelCount;
        int mortgageAmount;
        public const int colorCount = 7;
        //const
        public Property(String name, PropertyColor propertyColor, int[] rent, int cost, int houseCost, int mortgageValue)
        {
            this.hotelCount = 0;
            this.propertyColor = propertyColor;
            this.mortgaged = false;
            this.houseCount = 0;
            this.name = name;
            this.cost = cost;
            this.houseCost = houseCost;
            this.mortgageValue = mortgageValue;
            this.mortgageAmount = mortgageValue;
            this.rent = new int[6]; // 6 is the number of rent types, it is constant and always will be
            for (int i = 0; i < 6; i++)
            {
                this.rent[i] = rent[i];
            }
            this.owner = null;
        }
        //mutators
        public String getName()
        {
            return name;
        }
        public PropertyColor getPropertyColor()
        {
            return propertyColor;
        }
        public int getPropertyColorInt()
        {
            switch (propertyColor)
            {
                case (PropertyColor.brown):
                    return 0;
                case (PropertyColor.lightBlue):
                    return 1;
                case (PropertyColor.pink):
                    return 2;
                case (PropertyColor.orange):
                    return 3;
                case (PropertyColor.red):
                    return 4;
                case (PropertyColor.yellow):
                    return 5;
                case (PropertyColor.green):
                    return 6;
                case (PropertyColor.darkBlue):
                    return 7;
                default:
                    //error
                    return 0;
            }
        }
        public int getHotelCount()
        {
            return hotelCount;
        }
        public void setHotelCount(int htc)
        {
            this.hotelCount = htc;
        }
        public int[] getRentArray()
        {
            return rent;
        }
        public bool isMortgaged()
        {
            return mortgaged;
        }
        public void setMortgaged(bool b)
        {
            mortgaged = b;
        }
        public int getRent(int hc)
        {
            return rent[hc]; //hc means houseCount
        }
        public int getRent()
        {
            if (hotelCount == 1)
                return rent[rent.Length - 1];
            else
                return rent[houseCount];
        }
        public int getHouseCount()
        {
            return houseCount;
        }
        public void incerementHouseCount()
        {
            this.houseCount++;
            mortgageAmount = mortgageValue + (houseCount * houseCost);
        }
        public void setHouseCount(int houseCount)
        {
            this.houseCount = houseCount;
            mortgageAmount = mortgageValue + (houseCount * houseCost);

        }
        public int getMortgageValue()
        {
            return mortgageValue;
        }
        public int getMortgageAmount()
        {
            return mortgageAmount;
        }
        public int getHouseCost()
        {
            return houseCost;
        }
        public int getHotelCost()
        {
            return houseCost;
        }
        public int getCost()
        {
            return cost;
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
            owned = true;
        }
        public int mortgageProperty()
        {
            mortgaged = true;
            int toRet = mortgageValue + (houseCount * houseCost);
            houseCount = 0;
            return toRet;
        }
        public int buyBackProperty()
        {
            int toret = mortgageValue / 10;
            mortgaged = false;
            return toret + mortgageValue;
        }
    }
}
