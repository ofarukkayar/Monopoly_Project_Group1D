using System;

namespace Monopoly_Project
{
    public enum SqType
    {
        start,
        property,
        utility,
        chance,
        community,
        tax,
        parking,
        gotojail,
        jail,
        railroad
    }
    class GameSquare
    {
        int pos;
        SqType type;
        Property p;
        Railroad r;
        Utility u;
        public GameSquare(int pos, SqType type, Property p, Railroad r, Utility u)
        {
            this.pos = pos;
            this.type = type;
            this.p = p;
            this.u = u;
            this.r = r;
        }
        public int getPos()
        {
            return pos;
        }
        public void test()
        {
            switch (type)
            {
                case SqType.railroad:
                    Console.WriteLine(r.getName());
                    break;
                case SqType.utility:
                    Console.WriteLine(u.getName());
                    break;
                case SqType.property:
                    Console.WriteLine(p.getName());
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }
        public SqType getType()
        {
            return type;
        }
        public Property getPropertyOnSquare()
        {
            return p;
        }
        public Utility getUtilityOnSquare()
        {
            return u;
        }
        public Railroad getRailroadOnSquare()
        {
            return r;
        }
    }

    /* 
     * move()  ******&tick
     * tax *****&tick -> methodlar
     * teleport ******&tick -> move gibi ama starttan gecmiyo
     * getPropertyOnSquare() ******&tick
     * payRent(int playerId) ******&tick
     * mortgage() ******&tick
     * buy() ******&tick --> property e eklemeli para azalmalı, envantere koyup square i belirlemeli
     * ******&tick not railroad property buylamak aynı mı bakın bi ******&tick
     * *****&tick freeParking()
     * visit jail*****&tick -> nothing
     * go to jail *****&tick-> teleport(), isJailed(), canGetOutOfJailed(),jailAccordingtoDice etc.
     * trade *****&tick
     * get money on start *****&tick
     * mortgage methodu evleri geri versin *****&tick
     * 
     * 
     * chance -> butun kartlar icin methodları 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * chance 
     *0   +   --> advance to go, get 200
     *1   +   --> advance to istanbul get 200 if start
     *2   +   --> advance to london get 200 if start
     *3   +   --> advance to montreal
     *4   +   --> advance to nearest station,can buy,pay double
     *5   +   --> get 50
     *6   +   --> get 100
     *7   +   --> get 150
     *8   +   --> pay everyone 50
     *9   +   --> each house 25, each house 100 pay
     *10      --> get out of jail free
     *11  +   --> go back three
     *12  +   --> go to jail
     *13  +   --> pay 15 tax
     *14  +   --> go to grand central, get 200 if start
     *15  +   --> go to nearest utility, can buy, pay 10 * dice
     * talk with batu,
     * sometimes the sq you teleported to takes effect, 
     * sometimes does not,
     * how to handle
     * flag solution? 
     * ask
     * community
     *0   +   --> advance to go, get 200
     *1   +   --> get 200
     *2   +   --> get 10
     *3   +   --> get 10 from each player
     *4   +   --> pay 50
     *5   +   --> go to jail
     *6       --> get out of jail free
     *7   +   --> pay 50
     *8   +   --> get 20
     *9   +   --> get 100
     *10  +   --> get 100
     *11  +   --> get 50 from each player
     *12  +   --> get 25
     *13  +   --> get 50
     *14  +   --> pay 50
     *15  +   --> each house 40, each hotel 115 pay
     *16  +   --> get 100 
     * 
     * 
     */

    //start            -> 1 
    ///property        -> 22 tick
    ///utility         -> 2  tick 
    ///chance          -> 3  
    ///---may merge with community chest  
    ///community chest -> 3
    ///pay tax         -> 2
    ///free parking    -> 1
    ///go to jail      -> 1
    ///jail            -> 1
    ///railroad        -> 4 tick
}
