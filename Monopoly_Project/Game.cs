using System;
using System.Collections.Generic;

namespace Monopoly_Project
{

    public class Game
    {


        //prop
        public int currPlayer;
        public Player[] parr;
        GameSquare[] sqarr;
        int taxMoney;
        List<int> chanceCards;
        List<int> communityCards;
        int availableHouse;
        //const
        public Game()
        {
            availableHouse = 32;
            chanceCards = new List<int>();
            communityCards = new List<int>();
            taxMoney = 0;
            currPlayer = 0;
            parr = new Player[4];
            sqarr = new GameSquare[40];
            for (int i = 0; i < 4; i++)
            {
                parr[i] = new Player(i);
            }
            for (int i = 0; i < 16; i++)
            {
                chanceCards.Add(i);
            }
            for (int i = 0; i < 17; i++)
            {
                communityCards.Add(i);
            }

            shuffleCards(chanceCards, false);

            shuffleCards(communityCards, false);



            sqarr[0] = new GameSquare(0, SqType.start, null, null, null);
            sqarr[1] = new GameSquare(1, SqType.property, new Property("gdynia", PropertyColor.brown, new int[] { 2, 10, 30, 90, 160, 250 }, 60, 50, 30), null, null);
            sqarr[2] = new GameSquare(2, SqType.community, null, null, null);
            sqarr[3] = new GameSquare(3, SqType.property, new Property("taipei", PropertyColor.brown, new int[] { 4, 20, 60, 180, 320, 450 }, 60, 50, 30), null, null);
            sqarr[4] = new GameSquare(4, SqType.tax, null, null, null);
            sqarr[5] = new GameSquare(5, SqType.railroad, null, new Railroad("grandCentral"), null);
            sqarr[6] = new GameSquare(6, SqType.property, new Property("tokyo", PropertyColor.lightBlue, new int[] { 6, 30, 90, 270, 400, 550 }, 100, 50, 50), null, null);
            sqarr[7] = new GameSquare(7, SqType.chance, null, null, null);
            sqarr[8] = new GameSquare(8, SqType.property, new Property("barcelona", PropertyColor.lightBlue, new int[] { 6, 30, 90, 270, 400, 550 }, 100, 50, 50), null, null);
            sqarr[9] = new GameSquare(9, SqType.property, new Property("athens", PropertyColor.lightBlue, new int[] { 8, 40, 100, 300, 450, 600 }, 120, 50, 60), null, null);
            sqarr[10] = new GameSquare(10, SqType.jail, null, null, null);
            sqarr[11] = new GameSquare(11, SqType.property, new Property("istanbul", PropertyColor.pink, new int[] { 10, 50, 150, 450, 625, 750 }, 140, 100, 70), null, null);
            sqarr[12] = new GameSquare(12, SqType.utility, null, null, new Utility("electricCompany"));
            sqarr[13] = new GameSquare(13, SqType.property, new Property("kyiv", PropertyColor.pink, new int[] { 10, 50, 150, 450, 625, 750 }, 140, 100, 70), null, null);
            sqarr[14] = new GameSquare(14, SqType.property, new Property("toronto", PropertyColor.pink, new int[] { 12, 60, 180, 500, 700, 900 }, 160, 100, 80), null, null);
            sqarr[15] = new GameSquare(15, SqType.railroad, null, new Railroad("pooleHarbour"), null);
            sqarr[16] = new GameSquare(16, SqType.property, new Property("rome", PropertyColor.orange, new int[] { 14, 70, 200, 550, 700, 900 }, 180, 100, 90), null, null);
            sqarr[17] = new GameSquare(17, SqType.community, null, null, null);
            sqarr[18] = new GameSquare(18, SqType.property, new Property("shanghai", PropertyColor.orange, new int[] { 14, 70, 200, 550, 700, 900 }, 180, 100, 90), null, null);
            sqarr[19] = new GameSquare(19, SqType.property, new Property("vancouver", PropertyColor.orange, new int[] { 16, 60, 220, 600, 800, 1000 }, 200, 100, 100), null, null);
            sqarr[20] = new GameSquare(20, SqType.parking, null, null, null);
            sqarr[21] = new GameSquare(21, SqType.property, new Property("sydney", PropertyColor.red, new int[] { 18, 90, 250, 700, 875, 1050 }, 220, 150, 110), null, null);
            sqarr[22] = new GameSquare(22, SqType.chance, null, null, null);
            sqarr[23] = new GameSquare(23, SqType.property, new Property("newYork", PropertyColor.red, new int[] { 18, 90, 250, 700, 875, 1050 }, 220, 150, 120), null, null);
            sqarr[24] = new GameSquare(24, SqType.property, new Property("london", PropertyColor.red, new int[] { 20, 100, 300, 750, 925, 1100 }, 240, 150, 120), null, null);
            sqarr[25] = new GameSquare(25, SqType.railroad, null, new Railroad("englishHarbour"), null);
            sqarr[26] = new GameSquare(26, SqType.property, new Property("beijing", PropertyColor.yellow, new int[] { 22, 110, 330, 800, 975, 1150 }, 260, 150, 130), null, null);
            sqarr[27] = new GameSquare(27, SqType.property, new Property("hongKong", PropertyColor.yellow, new int[] { 22, 110, 330, 800, 975, 1150 }, 260, 150, 130), null, null);
            sqarr[28] = new GameSquare(28, SqType.utility, null, null, new Utility("waterWorks"));
            sqarr[29] = new GameSquare(29, SqType.property, new Property("jerusalem", PropertyColor.yellow, new int[] { 24, 120, 360, 850, 1025, 1200 }, 280, 150, 140), null, null);
            sqarr[30] = new GameSquare(30, SqType.gotojail, null, null, null);
            sqarr[31] = new GameSquare(31, SqType.property, new Property("paris", PropertyColor.green, new int[] { 26, 130, 390, 900, 1100, 1275 }, 300, 200, 150), null, null);
            sqarr[32] = new GameSquare(32, SqType.property, new Property("belgrade", PropertyColor.green, new int[] { 26, 130, 390, 900, 1100, 1275 }, 300, 200, 150), null, null);
            sqarr[33] = new GameSquare(33, SqType.community, null, null, null);
            sqarr[34] = new GameSquare(34, SqType.property, new Property("capeTown", PropertyColor.green, new int[] { 28, 150, 450, 1000, 1200, 1400 }, 320, 200, 160), null, null);
            sqarr[35] = new GameSquare(35, SqType.railroad, null, new Railroad("heathrowAirport"), null);
            sqarr[36] = new GameSquare(36, SqType.chance, null, null, null);
            sqarr[37] = new GameSquare(37, SqType.property, new Property("riga", PropertyColor.darkBlue, new int[] { 35, 175, 500, 1100, 1300, 1500 }, 350, 200, 175), null, null);
            sqarr[38] = new GameSquare(38, SqType.tax, null, null, null);
            sqarr[39] = new GameSquare(39, SqType.property, new Property("montreal", PropertyColor.darkBlue, new int[] { 50, 200, 600, 1400, 1700, 2000 }, 400, 200, 200), null, null);

        }
        //methods
        public int getRentOnProperty(int pos)
        {
            return sqarr[pos].getPropertyOnSquare().getRent();
        }
        public int getPlayerNameOnProperty(int pos)
        {
            return sqarr[pos].getPropertyOnSquare().getOwner().getId();
        }
        public void payRent(int pos)
        {
            SqType t = sqarr[pos].getType();
            switch (t)
            {
                case SqType.property:
                    payPropertyRent();
                    break;
                case SqType.utility:
                    payUtilityRent();
                    break;
                case SqType.railroad:
                    payRailroadRent();
                    break;
                default:
                    //error
                    break;
            }
        }
        public bool isOwned(int pos)
        {
            return sqarr[pos].getPropertyOnSquare().isOwned();
        }
        public void payRent()
        {
            SqType t = sqarr[parr[currPlayer].getPosition()].getType();
            switch (t)
            {
                case SqType.property:
                    payPropertyRent();
                    break;
                case SqType.utility:
                    payUtilityRent();
                    break;
                case SqType.railroad:
                    payRailroadRent();
                    break;
                default:
                    //error
                    break;
            }

        }
        public void shuffleCards(List<int> list, bool b)
        {
            if (b)
            {
                Random rng = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    int value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }

        }
        public bool getVeto(int id)
        {
            return parr[id].getVeto();
        }
        public void setVeto(int id, bool veto)
        {
            parr[id].setVeto(veto);
        }
        public void mortgage(string[] arr, int playerID)
        {
            int inc = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < 40; i++)
                {
                    SqType t = sqarr[i].getType();
                    switch (t)
                    {
                        case SqType.property:
                            if (arr[j] == sqarr[i].getPropertyOnSquare().getName())
                            {
                                if (sqarr[i].getPropertyOnSquare().getOwner().getId() == playerID)
                                {
                                    int hsc = sqarr[i].getPropertyOnSquare().getHouseCount();
                                    int htc = sqarr[i].getPropertyOnSquare().getHotelCount();
                                    parr[playerID].setHouseCount(parr[playerID].getHouseCount() - hsc);
                                    parr[playerID].setHotelCount(parr[playerID].getHotelCount() - htc);
                                    inc += sqarr[i].getPropertyOnSquare().mortgageProperty();
                                    availableHouse += sqarr[i].getPropertyOnSquare().getHouseCount();
                                }
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.utility:
                            if (arr[j] == sqarr[i].getUtilityOnSquare().getName())
                            {
                                if (sqarr[i].getUtilityOnSquare().getOwner().getId() == playerID)
                                    inc += sqarr[i].getUtilityOnSquare().mortgageUtility();
                            }
                            break;
                        case SqType.railroad:
                            if (arr[j] == sqarr[i].getRailroadOnSquare().getName())
                            {
                                if (sqarr[i].getRailroadOnSquare().getOwner().getId() == playerID)
                                    inc += sqarr[i].getRailroadOnSquare().mortgageRailroad();
                            }
                            break;
                        default:
                            //error
                            break;
                    }
                }
            }
            parr[playerID].money += inc;
        }
        public void payTax()
        {
            if (parr[currPlayer].getPosition() == 4)
            {
                parr[currPlayer].money -= 200;
                taxMoney += 200;
            }
            else if (parr[currPlayer].getPosition() == 38)
            {
                parr[currPlayer].money -= 100;
                taxMoney += 100;
            }
        }
        public void freeParking()
        {
            parr[currPlayer].money += taxMoney;
            taxMoney = 0;
        }
        public void removeMortgage(string[] arr, int playerID)
        {
            int inc = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < 40; i++)
                {
                    SqType t = sqarr[i].getType();
                    switch (t)
                    {
                        case SqType.property:
                            if (arr[j] == sqarr[i].getPropertyOnSquare().getName())
                            {
                                if (sqarr[i].getPropertyOnSquare().getOwner().getId() == playerID)
                                    inc += sqarr[i].getPropertyOnSquare().buyBackProperty();
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.utility:
                            if (arr[j] == sqarr[i].getUtilityOnSquare().getName())
                            {
                                if (sqarr[i].getUtilityOnSquare().getOwner().getId() == playerID)
                                    inc += sqarr[i].getUtilityOnSquare().buyBackUtility();
                            }
                            break;
                        case SqType.railroad:
                            if (arr[j] == sqarr[i].getRailroadOnSquare().getName())
                            {
                                if (sqarr[i].getRailroadOnSquare().getOwner().getId() == playerID)
                                    inc += sqarr[i].getRailroadOnSquare().buyBackRailroad();
                            }
                            break;
                        default:
                            //error
                            break;
                    }
                }
            }
            parr[playerID].money -= inc;
        }
        // jail methods
        //needed -> goToJail(), payGetOutOfJail, cardGetOutOfJail(), rollGetOutOfJail()
        public void goToJail()
        {
            parr[currPlayer].setJailed(true);
            teleport(10, false);
            parr[currPlayer].setJailCounter(0);
        }
        public void payGetOutOfJail()
        {
            parr[currPlayer].setJailed(false);
            parr[currPlayer].money -= 50;
            taxMoney += 50;
            parr[currPlayer].setJailCounter(0);
        }
        public void rollGetOutOjJail(int d1, int d2)
        {
            //change if you need to put a canRoll property in the player class
            //if not stays the same
            //talk!
            if (parr[currPlayer].getJailCounter() < 3)
            {
                if (d1 == d2)
                {
                    parr[currPlayer].setJailed(false);
                    parr[currPlayer].setJailCounter(0);
                }
                else
                {
                    parr[currPlayer].setJailCounter(parr[currPlayer].getJailCounter() + 1);
                }
            }
            else
            {
                payGetOutOfJail();
            }
        }
        public bool canGetOutOfJailFree()
        {
            return parr[currPlayer].getJailCards() > 0;
        }
        public void cardGetOutOfJail()
        {
            if (canGetOutOfJailFree())
            {
                parr[currPlayer].setJailed(false);
                parr[currPlayer].setJailCounter(0);
                parr[currPlayer].setJailCards(parr[currPlayer].getJailCards() - 1);
            }
            else
            {
                //implement maybe?
            }
        }
        //end jail methods
        //card methods
        // chance cards
        public int drawChanceCard()
        {
            int cardNo = chanceCards[0];
            chanceCards.RemoveAt(0);
            chanceCards.Add(cardNo);
            return cardNo;
        }
        public void chanceCard(int cardNo)
        {
            switch (cardNo)
            {
                case 0: //advance to go get 200 if start
                    teleport(0, true);
                    break;
                case 1://advance to istanbul get 200 if start
                    teleport(11, true);
                    break;
                case 2://advance to london get 200 if start
                    teleport(24, true);
                    break;
                case 3://advance to montreal
                    teleport(39, true);
                    break;
                case 4://advance to nearest station, can buy pay double rent
                    //station id,5,15,25,35
                    int pos = parr[currPlayer].getPosition();
                    if (pos == 7)
                    {//???????????????????????? sor
                        teleport(15, false);
                        if (sqarr[15].getRailroadOnSquare().isOwned())
                        {
                            payRent();
                        }
                    }
                    else if (pos == 22)
                    {
                        teleport(25, false);
                        if (sqarr[25].getRailroadOnSquare().isOwned())
                        {
                            payRent();
                        }
                    }
                    else if (pos == 36)
                    {
                        teleport(5, false);
                        if (sqarr[5].getRailroadOnSquare().isOwned())
                        {
                            payRent();
                        }
                    }
                    else
                    {
                        //error
                    }
                    break;
                case 5://banks pay you dividend of 50
                    parr[currPlayer].money += 50;
                    break;
                case 6://you have won crossword competetion get 100
                    parr[currPlayer].money += 100;
                    break;
                case 7://your buildings loan matures get 150
                    parr[currPlayer].money += 150;
                    break;
                case 8://you have been elected chairman pay everyone 50
                    for (int i = 0; i < 4; i++)
                    {
                        if (i != currPlayer)
                        {
                            parr[i].money += 50;
                        }
                    }
                    parr[currPlayer].money -= 150;
                    break;
                case 9://make general repairs on all of your prop, 25 house 100 hotel
                    int htc = parr[currPlayer].getHotelCount();
                    int hsc = parr[currPlayer].getHouseCount();
                    htc *= 100;
                    hsc *= 25;
                    parr[currPlayer].money -= (hsc + htc);
                    break;
                case 10://get out of jail free
                    parr[currPlayer].setJailCards(parr[currPlayer].getJailCards() + 1);
                    break;
                case 11://go back three
                    int togo = (parr[currPlayer].getPosition() - 3) % 40;
                    teleport(togo, false);
                    break;
                case 12://go to jail
                    goToJail();
                    break;
                case 13://pay 15 poor tax
                    parr[currPlayer].money -= 15;
                    taxMoney += 15;
                    break;
                case 14://go to grand central station, get 200 if start
                    teleport(5, true);
                    break;
                case 15:// go to nearest station, can buy, pay 10*dice
                    //probably needs a flag, probably all of them needs a flag ...
                    if (parr[currPlayer].getPosition() == 22)
                    {
                        teleport(28, false);
                        if (sqarr[28].getUtilityOnSquare().isOwned())
                        {
                            int rent = parr[currPlayer].getLastDice() * 10;
                            parr[currPlayer].money -= rent;
                            parr[sqarr[28].getUtilityOnSquare().getOwner().getId()].money += rent;
                        }
                        else
                        {
                            //property is not owned, can buy
                        }
                    }
                    else
                    { // then needs to teleport to electrical
                        teleport(12, false);
                        if (sqarr[12].getUtilityOnSquare().isOwned())
                        {
                            int rent = parr[currPlayer].getLastDice() * 10;
                            parr[currPlayer].money -= rent;
                            parr[sqarr[12].getUtilityOnSquare().getOwner().getId()].money += rent;
                        }
                        else
                        {
                            //Property is not owned, can buy
                        }
                    }
                    break;
                default:
                    //error
                    break;
            }
        }
        public bool canBuildHouse(int playerID, int pos, ref int cost)
        {
            //cost will give back the cost of the house that is being questioned
            cost = sqarr[pos].getPropertyOnSquare().getHouseCost();
            int pColor = sqarr[pos].getPropertyOnSquare().getPropertyColorInt();
            bool b = sqarr[pos].getPropertyOnSquare().getHotelCost() == 0;
            if (availableHouse <= 0)
            {
                return false;
            }
            if (pColor == 0 || pColor == 7)
            {
                return (parr[playerID].colorArray[pColor] == 2) && b;
            }
            else
            {
                return (parr[playerID].colorArray[pColor] == 3) && b;
            }
        }
        public bool canBuildHouse(ref int cost)
        {
            cost = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCost();
            int pColor = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getPropertyColorInt();
            bool b = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHotelCost() == 0;
            if (availableHouse <= 0)
            {
                return false;
            }
            if (pColor == 0 || pColor == 7)
            {
                return (parr[currPlayer].colorArray[pColor] == 2 && b);
            }
            else
            {
                return (parr[currPlayer].colorArray[pColor] == 3 && b);
            }
        }
        public bool canBuildHotel(int playerID, int pos)
        {
            int pColor = sqarr[pos].getPropertyOnSquare().getPropertyColorInt();
            if (pColor == 0 || pColor == 7)
            {
                if (parr[currPlayer].colorArray[pColor] == 2)
                {
                    return sqarr[pos].getPropertyOnSquare().getHouseCount() == 4;
                }
                return false;
            }
            else
            {
                if (parr[currPlayer].colorArray[pColor] == 3)
                {
                    return sqarr[pos].getPropertyOnSquare().getHouseCount() == 4;
                }
                return false;
            }
        }
        public bool canBuildHotel()
        {
            int pColor = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getPropertyColorInt();
            bool b = (sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHotelCount() == 0);
            if (pColor == 0 || pColor == 7)
            {

                if (parr[currPlayer].colorArray[pColor] == 2 && b)
                {
                    return sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCount() == 4;
                }
                return false;
            }
            else
            {
                if (parr[currPlayer].colorArray[pColor] == 3 && b)
                {
                    return sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCount() == 4;
                }
                return false;
            }
        }
        public bool isOwnedBy(int id)
        {
            return (sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getOwner().getId() == id);
        }
        public int buildHouse()
        {
            //returns the ith house that is being built
            int cost = 0;
            if (canBuildHouse(ref cost))
            {
                parr[currPlayer].setHouseCount(parr[currPlayer].getHouseCount() + 1);
                sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().setHouseCount(sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCount() + 1);
                int toret = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCount();
                //for debug
                Console.WriteLine("cost is: " + cost);
                parr[currPlayer].money -= cost;
                availableHouse--;
                return toret;
            }
            else
            {
                //error
                return 0;
            }
        }
        public int buildHotel()
        {
            if (canBuildHotel())
            {
                parr[currPlayer].setHouseCount(parr[currPlayer].getHouseCount() - 4);
                parr[currPlayer].setHotelCount(parr[currPlayer].getHotelCount() + 1);
                sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().setHouseCount(0);
                sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().setHotelCount(1);
                int cost = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getHouseCost();
                parr[currPlayer].money -= cost;
                availableHouse += 4;
                return cost;
            }
            else
            {
                //error
                return 0;
            }
        }
        // community cards
        public int drawCommunityChestCard()
        {
            int cardNo = communityCards[0];
            communityCards.RemoveAt(0);
            communityCards.Add(cardNo);
            return cardNo;
        }
        public void communityChestCard(int cardNo)
        {
            switch (cardNo)
            {
                case 0://advance to go
                    teleport(0, true);
                    break;
                case 1://bank error in your favor get 200
                    parr[currPlayer].money += 200;
                    break;
                case 2://2nd prize in beauty contest get 10
                    parr[currPlayer].money += 10;
                    break;
                case 3://its your birthday get 10 from each player
                    for (int i = 0; i < 4; i++)
                    {
                        if (i != currPlayer)
                        {
                            parr[i].money -= 10;
                        }
                    }
                    parr[currPlayer].money += 30;
                    break;
                case 4://doctors fee pay 50
                    parr[currPlayer].money -= 50;
                    break;
                case 5://go to jail
                    goToJail();
                    break;
                case 6://get out of jail free card
                    parr[currPlayer].setJailCards(parr[currPlayer].getJailCards() + 1);
                    break;
                case 7://hospitals fee pay 50
                    parr[currPlayer].money -= 50;
                    break;
                case 8://income tax refund get 20
                    parr[currPlayer].money += 20;
                    break;
                case 9://you inherit 100
                    parr[currPlayer].money += 100;
                    break;
                case 10://life insurance matures get 100
                    parr[currPlayer].money += 100;
                    break;
                case 11://grand opera opening, get 50 from each player
                    for (int i = 0; i < 4; i++)
                    {
                        if (i != currPlayer)
                        {
                            parr[i].money -= 50;
                        }
                    }
                    parr[currPlayer].money += 150;
                    break;
                case 12://recieve 25 consultancy fee
                    parr[currPlayer].money += 25;
                    break;
                case 13://from sale of stock you get 50
                    parr[currPlayer].money += 50;
                    break;
                case 14: //school fees pay 50
                    parr[currPlayer].money -= 50;
                    break;
                case 15://you are assesed for street repairs, 40 for house, 115 for hotel pay
                    int htc = parr[currPlayer].getHotelCount();
                    int hsc = parr[currPlayer].getHotelCount();
                    htc *= 115;
                    hsc *= 40;
                    parr[currPlayer].money -= (hsc + htc);
                    break;
                case 16://xmas founds mature get 100
                    parr[currPlayer].money += 100;
                    break;
                default:
                    //error
                    break;
            }
        }
        //end card methods
        public void payUtilityRent()
        {
            if (sqarr[parr[currPlayer].getPosition()].getUtilityOnSquare().isMortgaged())
            {
                return;
            }
            Player rentPayer = parr[currPlayer];
            Player rentReciever = sqarr[parr[currPlayer].getPosition()].getUtilityOnSquare().getOwner();
            int rent = sqarr[parr[currPlayer].getPosition()].getUtilityOnSquare().getRentModifier() * rentPayer.getLastDice();
            rentPayer.money -= rent;
            rentReciever.money += rent;
        }
        public void payPropertyRent()
        {
            if (sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().isMortgaged())
            {
                return;
            }
            Player rentPayer = parr[currPlayer];
            Player rentReciever = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getOwner();
            int rent = sqarr[parr[currPlayer].getPosition()].getPropertyOnSquare().getRent();
            rentPayer.money -= rent;
            rentReciever.money += rent;
        }
        public void payRailroadRent()
        {
            if (sqarr[parr[currPlayer].getPosition()].getRailroadOnSquare().isMortgaged())
            {
                return;
            }
            Player rentPayer = parr[currPlayer];
            Player rentReciever = sqarr[parr[currPlayer].getPosition()].getRailroadOnSquare().getOwner();
            int rent = sqarr[parr[currPlayer].getPosition()].getRailroadOnSquare().getRent();
            rentPayer.money -= rent;
            rentReciever.money += rent;
        }

        public int getPlayerMoney(int id)
        {
            return parr[id].money;
        }
        public void move(int dice)
        {
            if (parr[currPlayer].isJailed() == false)
                parr[currPlayer].move(dice);

        }
        public void move(int dice, int player)
        {
            if (parr[player].isJailed() == false)
                parr[player].move(dice);
        }
        public void teleport(int pos, bool getsMoney)
        {
            int curpos = parr[currPlayer].getPosition();
            if (curpos > pos)
            {
                if (getsMoney)
                    parr[currPlayer].money += 200;
            }
            parr[currPlayer].setPosition(pos);
        }
        public bool isGameOver()
        {
            for (int i = 0; i < 4; i++)
            {
                if (parr[i].money <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void teleport(int pos, bool getsMoney, int id)
        {
            int curpos = parr[id].getPosition();
            if (curpos + pos > 40)
            {
                if (getsMoney)
                    parr[id].money += 200;
            }
            parr[id].setPosition(pos);

        }
        public void getColorCounts(int playerID)
        {
            parr[playerID].getColorCounts();
        }
        public void buy(int id, int pos)
        {
            SqType t = sqarr[pos].getType();
            switch (t)
            {
                case SqType.property:
                    if (sqarr[pos].getPropertyOnSquare().isOwned())
                    {//error
                    }
                    else
                    {
                        parr[id].colorArray[sqarr[pos].getPropertyOnSquare().getPropertyColorInt()]++;
                        int cost = sqarr[pos].getPropertyOnSquare().getCost();
                        parr[id].money -= cost;
                        sqarr[pos].getPropertyOnSquare().setOwner(parr[id]);
                        parr[id].addAsset(sqarr[pos].getPropertyOnSquare().getName());
                    }
                    break;
                case SqType.railroad:
                    if (sqarr[pos].getRailroadOnSquare().isOwned())
                    {//error
                    }
                    else
                    {
                        int cost = sqarr[pos].getRailroadOnSquare().getCost();
                        parr[id].money -= cost;
                        sqarr[pos].getRailroadOnSquare().setOwner(parr[id]);
                        parr[id].incrementRailroadCount();
                        parr[id].addAsset(sqarr[pos].getRailroadOnSquare().getName());
                    }
                    break;
                case SqType.utility:
                    if (sqarr[pos].getUtilityOnSquare().isOwned())
                    { //error
                    }
                    else
                    {
                        int cost = sqarr[pos].getUtilityOnSquare().getCost();
                        parr[id].money -= cost;
                        sqarr[pos].getUtilityOnSquare().setOwner(parr[id]);
                        parr[id].incrementUtilityCount();
                        parr[id].addAsset(sqarr[pos].getUtilityOnSquare().getName());
                    }
                    break;
                default:
                    //error
                    break;
            }
        }
        public void buyFor(int id, int pos, int costof)
        {
            SqType t = sqarr[pos].getType();
            switch (t)
            {
                case SqType.property:
                    if (sqarr[pos].getPropertyOnSquare().isOwned())
                    {//error
                    }
                    else
                    {
                        parr[id].colorArray[sqarr[pos].getPropertyOnSquare().getPropertyColorInt()]++;
                        parr[id].money -= costof;
                        sqarr[pos].getPropertyOnSquare().setOwner(parr[id]);
                        parr[id].addAsset(sqarr[pos].getPropertyOnSquare().getName());
                    }
                    break;
                case SqType.railroad:
                    if (sqarr[pos].getRailroadOnSquare().isOwned())
                    {//error
                    }
                    else
                    {
                        int cost = sqarr[pos].getRailroadOnSquare().getCost();
                        parr[id].money -= cost;
                        sqarr[pos].getRailroadOnSquare().setOwner(parr[id]);
                        parr[id].incrementRailroadCount();
                        parr[id].addAsset(sqarr[pos].getRailroadOnSquare().getName());
                    }
                    break;
                case SqType.utility:
                    if (sqarr[pos].getUtilityOnSquare().isOwned())
                    { //error
                    }
                    else
                    {
                        int cost = sqarr[pos].getUtilityOnSquare().getCost();
                        parr[id].money -= cost;
                        sqarr[pos].getUtilityOnSquare().setOwner(parr[id]);
                        parr[id].incrementUtilityCount();
                        parr[id].addAsset(sqarr[pos].getUtilityOnSquare().getName());
                    }
                    break;
                default:
                    //error
                    break;
            }
        }

        public void trade(int id, List<string> sender, int senderMoney, List<string> reciever, int recieverMoney)
        {
            ///sender list al
            ///her string icin
            ///asset bul 
            ///adama ver                ->> asset owner degis, iki playerın asset arrayleri degis,
            ///string i sil
            ///her reciever icin yap
            ///paraları don
            ///dagıl
            ///sender = curr player
            ///reciever = id
            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            bool flag4 = true;

            while ((sender.Count > 0) && (flag1 == true))
            {
                for (int i = 0; ((i < 40) && (flag2 == true)); i++)
                {
                    SqType t = sqarr[i].getType();
                    switch (t)
                    {
                        case SqType.property:
                            if (sender[0] == sqarr[i].getPropertyOnSquare().getName())
                            {
                                //auth check
                                if (sqarr[i].getPropertyOnSquare().getOwner().getId() == currPlayer)
                                {
                                    //since the hotels and houses stay on the property,
                                    //just update the players' house and hotel counts
                                    int hsc = sqarr[i].getPropertyOnSquare().getHouseCount();
                                    int htc = sqarr[i].getPropertyOnSquare().getHotelCount();
                                    parr[currPlayer].setHouseCount(parr[currPlayer].getHouseCount() - hsc);
                                    parr[currPlayer].setHotelCount(parr[currPlayer].getHotelCount() - htc);
                                    parr[id].setHouseCount(parr[id].getHouseCount() + hsc);
                                    parr[id].setHotelCount(parr[id].getHotelCount() + htc);
                                    //also update the color counts of each participant of the trade
                                    parr[currPlayer].colorArray[sqarr[i].getPropertyOnSquare().getPropertyColorInt()]--;
                                    parr[id].colorArray[sqarr[i].getPropertyOnSquare().getPropertyColorInt()]++;

                                    //change the owner of the property, remove property from the previous
                                    //owners asset list, add it to the new owners asset list
                                    //and remove from trade list as trade is complete
                                    sqarr[i].getPropertyOnSquare().setOwner(parr[id]);
                                    parr[currPlayer].removeAsset(sender[0]);
                                    parr[id].addAsset(sender[0]);
                                    sender.RemoveAt(0);
                                    if (sender.Count <= 0)
                                    {
                                        flag1 = false;
                                        flag2 = false;
                                    }
                                }
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.utility:
                            if (sender[0] == sqarr[i].getUtilityOnSquare().getName())
                            {
                                //auth check
                                if (sqarr[i].getUtilityOnSquare().getOwner().getId() == currPlayer)
                                {
                                    //update players info
                                    parr[currPlayer].decrementUtilityCount();
                                    parr[id].incrementUtilityCount();
                                    //execute swap
                                    sqarr[i].getUtilityOnSquare().setOwner(parr[id]);
                                    parr[currPlayer].removeAsset(sender[0]);
                                    parr[id].addAsset(sender[0]);
                                    sender.RemoveAt(0);
                                }
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.railroad:
                            if (sender[0] == sqarr[i].getRailroadOnSquare().getName())
                            {
                                //auth check
                                if (sqarr[i].getRailroadOnSquare().getOwner().getId() == currPlayer)
                                {
                                    //update player info
                                    parr[currPlayer].decrementRailroadCount();
                                    parr[id].incrementRailroadCount();
                                    //execute swap
                                    sqarr[i].getRailroadOnSquare().setOwner(parr[id]);
                                    parr[currPlayer].removeAsset(sender[0]);
                                    parr[id].addAsset(sender[0]);
                                    sender.RemoveAt(0);
                                }
                            }
                            break; //this needs to be a double break, but there is none in c#
                        default:
                            //error
                            break;
                    }
                }
            }
            while ((reciever.Count > 0) && (flag3 == true))
            {
                for (int i = 0; ((i < 40) && (flag4 == true)); i++)
                {
                    SqType t = sqarr[i].getType();
                    switch (t)
                    {
                        case SqType.property:
                            if (reciever[0] == sqarr[i].getPropertyOnSquare().getName())
                            {
                                //auth check
                                if (sqarr[i].getPropertyOnSquare().getOwner().getId() == id)
                                {
                                    //update player info
                                    int hsc = sqarr[i].getPropertyOnSquare().getHouseCount();
                                    int htc = sqarr[i].getPropertyOnSquare().getHotelCount();
                                    parr[id].setHouseCount(parr[currPlayer].getHouseCount() - hsc);
                                    parr[id].setHotelCount(parr[currPlayer].getHotelCount() - htc);
                                    parr[currPlayer].setHouseCount(parr[id].getHouseCount() + hsc);
                                    parr[currPlayer].setHotelCount(parr[id].getHotelCount() + htc);
                                    //update color numbers of each player
                                    parr[id].colorArray[sqarr[i].getPropertyOnSquare().getPropertyColorInt()]--;
                                    parr[currPlayer].colorArray[sqarr[i].getPropertyOnSquare().getPropertyColorInt()]++;

                                    //swap properties
                                    sqarr[i].getPropertyOnSquare().setOwner(parr[currPlayer]);
                                    parr[id].removeAsset(reciever[0]);
                                    parr[currPlayer].addAsset(reciever[0]);
                                    reciever.RemoveAt(0);
                                    if (reciever.Count <= 0)
                                    {
                                        flag3 = false;
                                        flag4 = false;
                                    }
                                }
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.utility:
                            if (reciever[0] == sqarr[i].getUtilityOnSquare().getName())
                            {
                                //auth check
                                if (sqarr[i].getUtilityOnSquare().getOwner().getId() == id)
                                {
                                    //update player info
                                    parr[id].decrementUtilityCount();
                                    parr[currPlayer].incrementUtilityCount();
                                    //swap utilities
                                    sqarr[i].getUtilityOnSquare().setOwner(parr[currPlayer]);
                                    parr[id].removeAsset(reciever[0]);
                                    parr[currPlayer].addAsset(reciever[0]);
                                    reciever.RemoveAt(0);
                                }
                            }
                            break; // this needs to be a double break, but there is none in c#
                        case SqType.railroad:
                            if (reciever[0] == sqarr[i].getRailroadOnSquare().getName())
                            {
                                if (sqarr[i].getRailroadOnSquare().getOwner().getId() == id)
                                {
                                    //update player info
                                    parr[id].decrementRailroadCount();
                                    parr[currPlayer].incrementRailroadCount();
                                    //swap
                                    sqarr[i].getRailroadOnSquare().setOwner(parr[currPlayer]);
                                    parr[id].removeAsset(reciever[0]);
                                    parr[currPlayer].addAsset(reciever[0]);
                                    reciever.RemoveAt(0);
                                }
                            }
                            break; //this needs to be a double break, but there is none in c#
                        default:
                            //error
                            break;
                    }
                }
            }
            parr[currPlayer].money += recieverMoney;
            parr[id].money -= recieverMoney;
            parr[id].money += senderMoney;
            parr[currPlayer].money -= senderMoney;
        }
        public int biddingWar(int bid1, int bid2, int bid3, int bid4, string name)
        {
            int pos = findProperty(name);
            if (pos == -1)
            {
                //error
                return -2;
            }
            int[] arr = new int[] { bid1, bid2, bid3, bid4 };
            int max = Int32.MinValue;
            int winnerID = -1;

            for (int i = 0; i < 4; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    winnerID = i;
                }
            }
            buyFor(winnerID, pos, max);
            return winnerID;
        }

        public int findProperty(String s)
        {
            SqType t;
            for (int i = 0; i < 40; i++)
            {
                t = sqarr[i].getType();
                switch (t)
                {
                    case SqType.property:
                        if (sqarr[i].getPropertyOnSquare().getName() == s)
                        {
                            return i;
                        }
                        break;
                    default:
                        break;
                }
            }

            return -1;
        }
    }

}
