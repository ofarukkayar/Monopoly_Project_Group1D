using System;
using System.Collections.Generic;

namespace Monopoly_Project
{
    public class Player
    {
        int id;
        int houseCount;
        int hotelCount;
        public int money;
        int pos;
        int railroadCount;
        int utilityCount;
        bool jailed;
        int lastDice;
        int jailCounter;
        int getoutofjail;
        bool veto;
        public int[] colorArray;
        public List<string> assets;
        public Player(int id)
        {
            this.veto = true;
            this.colorArray = new int[8];
            for (int i = 0; i < 8; i++)
            {
                colorArray[i] = 0;
            }
            this.houseCount = 0;
            this.hotelCount = 0;
            this.getoutofjail = 0;
            this.jailCounter = 0;
            this.jailed = false;
            this.utilityCount = 0;
            this.railroadCount = 0;
            this.id = id;
            this.money = 1500;
            assets = new List<string>();
            pos = 0;
            lastDice = 0;
        }
        //move
        public void move(int moveAmount)
        {
            int prevpos = pos;
            pos += moveAmount;
            pos = pos % 40;
            if (prevpos > pos)
            {
                this.money += 200;
            }
            //sq effect?
            lastDice = moveAmount;
        }
        public void move(int d1, int d2)
        {
            lastDice = d1 + d2;
            int prevpos = pos;
            pos += lastDice;
            pos = pos % 40;
            if (prevpos > pos)
            {
                this.money += 200;
                this.veto = true;
            }
            //sq effect?
        }

        //buy

        //pay

        //mutators
        public int getColorCount(int i)
        {
            return colorArray[i];
        }
        public void getColorCounts()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Player " + id + " has " + colorArray[i] + " " + i + " properties");
            }
        }
        public bool getVeto()
        {
            return veto;
        }
        public void setVeto(bool veto)
        {
            this.veto = veto;
        }
        public int getId()
        {
            return id;
        }
        public int getHouseCount()
        {
            return houseCount;
        }
        public void setHouseCount(int houseCount)
        {
            this.houseCount = houseCount;
        }
        public int getHotelCount()
        {
            return hotelCount;
        }
        public void setHotelCount(int hotelCount)
        {
            this.hotelCount = hotelCount;
        }
        public int getJailCards()
        {
            return getoutofjail;
        }
        public void setJailCards(int k)
        {
            this.getoutofjail = k;
        }
        public int getMoney()
        {
            return money;
        }
        public int getJailCounter()
        {
            return jailCounter;
        }
        public void setJailCounter(int jailCounter)
        {
            this.jailCounter = jailCounter;
        }
        public int getPosition()
        {
            return pos;
        }
        public void setPosition(int p)
        {
            pos = p;
        }
        public int getRailroadCount()
        {
            return railroadCount;
        }
        public void decrementRailroadCount()
        {
            railroadCount--;
        }
        public void incrementRailroadCount()
        {
            railroadCount++;
        }
        public void setRailroadCount(int railroadCount)
        {
            this.railroadCount = railroadCount;
        }
        public int getUtilityCount()
        {
            return utilityCount;
        }
        public void decrementUtilityCount()
        {
            utilityCount--;
        }
        public void incrementUtilityCount()
        {
            utilityCount++;
        }
        public void setUtilityCount(int utilityCount)
        {
            this.utilityCount = utilityCount;
        }
        public bool isJailed()
        {
            return jailed;
        }
        public void setJailed(bool jailed)
        {
            this.jailed = jailed;
        }
        public int getLastDice()
        {
            return lastDice;
        }
        public void addAsset(string s)
        {
            assets.Add(s);
        }
        public void removeAsset(string s)
        {
            assets.Remove(s);
        }
        public void displayAssets()
        {
            for (int i = 0; i < assets.Count; i++)
            {
                Console.WriteLine("Player " + id + " has: " + assets[i]);
            }
        }
    }
}
