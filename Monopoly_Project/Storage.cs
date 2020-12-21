using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Project
{
    public partial class PlayerDB
    {
        public String name { get; set; } = "";
        public int id { get; set; } = -1;
        public int pawnId { get; set; } = -1;
        public int pos { get; set; } = 0;
        public int railroadCount { get; set; } = 0;
        public int utilityCount { get; set; } = 0;
        public List<string> assets { get; set; } = new List<string>();
        public int houseCount { get; set; } = 0;
        public int hotelCount { get; set; } = 0;
        public bool jailed { get; set; } = false;
        public int money { get; set; } = 1500;
        public int lastDice { get; set; } = 0;
        public int jailCounter { get; set; } = 0;
        public int bid { get; set; } = 0;
    }

    public partial class GameBoardDB
    {
        public String hostName { get; set; } = "";
        public String gameId { get; set; } = "";
        public int dice1 { get; set; } = 0;
        public int dice2 { get; set; } = 0;
        public int numberOfPlayers { get; set; } = 0;
        public int currentPlayer { get; set; } = 0;
        public int functionCalls { get; set; } = 0;
        public List<int> pawn { get; set; } = new List<int>(new int[6]);
        public bool diceRolled { get; set; } = false;
        public bool bidMade { get; set; } = false;
        public bool bidNotMade { get; set; } = false;
        public int bidCount { get; set; } = 0;
        public bool endTurn { get; set; } = false;
        public bool boughtUtility { get; set; } = false;
    }

    public partial class Storage : Form
    {

        public Boolean serverError;
        public GameBoardDB gbdb;
        public PlayerDB[] pdb;
        public int myID;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EKBiPItEwPnsSNjlUQtLHSR5Qi8ccB7JZUA3KEyf",
            BasePath = "https://monopoly-db-group1d-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Storage()
        {
            gbdb = new GameBoardDB();
            pdb = new PlayerDB[4] { new PlayerDB(), new PlayerDB(), new PlayerDB(), new PlayerDB() };

            serverError = false;
            client = new FireSharp.FirebaseClient(config);
        }



        public async void hostGame(String gameId, String hostName)
        {
            FirebaseResponse response = await client.GetTaskAsync(gameId + "/gameBoard");

            gbdb.hostName = hostName;
            gbdb.gameId = gameId;
            gbdb.numberOfPlayers = 1;

            pdb[0].name = hostName;
            pdb[0].id = 0;
            pdb[0].pawnId = -1;
            myID = 0;

            SetResponse response1 = await client.SetTaskAsync(gameId + "/gameBoard/", gbdb);
            SetResponse response2 = await client.SetTaskAsync(gameId + "/players/0/", pdb[0]);
            SetResponse response3 = await client.SetTaskAsync(gameId + "/players/1/", pdb[1]);
            SetResponse response4 = await client.SetTaskAsync(gameId + "/players/2/", pdb[2]);
            SetResponse response5 = await client.SetTaskAsync(gameId + "/players/3/", pdb[3]);
        }
        public async void joinGame(String gameId, String joinName)
        {

            FirebaseResponse response = await client.GetTaskAsync(gameId + "/gameBoard");
            if (response == null)
                serverError = true;
            else
            {

                gbdb = response.ResultAs<GameBoardDB>();
                // number of players info updated
                if (gbdb.numberOfPlayers < 4)
                {

                    gbdb.numberOfPlayers += 1;
                    pdb[gbdb.numberOfPlayers - 1].name = joinName;
                    pdb[gbdb.numberOfPlayers - 1].id = gbdb.numberOfPlayers - 1;
                    pdb[gbdb.numberOfPlayers - 1].pawnId = -1;
                    myID = gbdb.numberOfPlayers - 1;

                    SetResponse responsegame = await client.SetTaskAsync(gameId + "/gameBoard/", gbdb);

                    //Other player info received

                    PlayerDB temp = new PlayerDB();
                    FirebaseResponse response1 = await client.GetTaskAsync(gbdb.gameId + "/players/0/");
                    temp = response1.ResultAs<PlayerDB>();
                    pdb[0] = temp;
                    if (gbdb.numberOfPlayers == 2)
                        _ = await client.SetTaskAsync(gameId + "/players/1", pdb[1]);
                    if (gbdb.numberOfPlayers == 3)
                    {
                        FirebaseResponse response2 = await client.GetTaskAsync(gbdb.gameId + "/players/1/");
                        pdb[1] = response2.ResultAs<PlayerDB>();
                        _ = await client.SetTaskAsync(gameId + "/players/2", pdb[2]);
                    }
                    if (gbdb.numberOfPlayers == 4)
                    {
                        FirebaseResponse response2 = await client.GetTaskAsync(gbdb.gameId + "/players/1/");
                        pdb[1] = response2.ResultAs<PlayerDB>();
                        FirebaseResponse response3 = await client.GetTaskAsync(gbdb.gameId + "/players/2/");
                        pdb[2] = response3.ResultAs<PlayerDB>();
                        _ = await client.SetTaskAsync(gameId + "/players/3", pdb[3]);
                    }
                    // gameboard info is received

                }
                else
                    serverError = true;
            }
        }
        public async void setDice(int dice1, int dice2)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            gbdb.dice1 = dice1;
            gbdb.dice2 = dice2;
            gbdb.diceRolled = true;
            SetResponse responseDice1 = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setDiceRolled(bool b)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(200));
            gbdb.diceRolled = b;
            SetResponse responseDiceRolled = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setDiceRolledInside(bool b)
        {
            gbdb.diceRolled = b;
            SetResponse responseDiceRolled = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setBidMade(bool b)
        {
            gbdb.bidMade = b;
            gbdb.diceRolled = b;
            SetResponse responseBid = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);

        }
        public async void setAll(bool b)
        {
            gbdb.bidMade = b;
            gbdb.diceRolled = b;
            gbdb.bidNotMade = b;
            SetResponse responseBid = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);

        }
        public async void setBidNotMade(bool b)
        {
            gbdb.bidNotMade = b;
            SetResponse responseBidNotMade = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setBoughtUtility(bool b)
        {
            gbdb.boughtUtility = b;
            SetResponse responseBidNotMade = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void getGameBoardDB()
        {
            FirebaseResponse response1 = await client.GetTaskAsync(gbdb.gameId + "/gameBoard");
            gbdb = response1.ResultAs<GameBoardDB>();
        }

        public async void getPlayerDB()
        {
            FirebaseResponse response1 = await client.GetTaskAsync(gbdb.gameId + "/players/0/");
            pdb[0] = response1.ResultAs<PlayerDB>();
            if (gbdb.numberOfPlayers == 2)
            {
                FirebaseResponse response2 = await client.GetTaskAsync(gbdb.gameId + "/players/1/");
                pdb[1] = response2.ResultAs<PlayerDB>();
            }
            if (gbdb.numberOfPlayers == 3)
            {
                FirebaseResponse response2 = await client.GetTaskAsync(gbdb.gameId + "/players/1/");
                pdb[1] = response2.ResultAs<PlayerDB>();
                FirebaseResponse response3 = await client.GetTaskAsync(gbdb.gameId + "/players/2/");
                pdb[2] = response3.ResultAs<PlayerDB>();
            }
            if (gbdb.numberOfPlayers == 4)
            {
                FirebaseResponse response2 = await client.GetTaskAsync(gbdb.gameId + "/players/1/");
                pdb[1] = response2.ResultAs<PlayerDB>();
                FirebaseResponse response3 = await client.GetTaskAsync(gbdb.gameId + "/players/2/");
                pdb[2] = response3.ResultAs<PlayerDB>();
                FirebaseResponse response4 = await client.GetTaskAsync(gbdb.gameId + "/players/3/");
                pdb[3] = response4.ResultAs<PlayerDB>();
            }
        }
        public async void setPlayerDB()
        {
            _ = await client.SetTaskAsync(gbdb.gameId + "/players/" + myID, pdb[myID]);
        }
        public async void setGameBoardDB()
        {
            _ = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void closeGameDB()
        {
            //To Do
            FirebaseResponse response = await client.DeleteTaskAsync(gbdb.gameId);
        }
        public async void pawnSelected(int playerId, int pawnId)
        {
            gbdb.pawn[pawnId] = 1;
            SetResponse responseDice1 = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
            pdb[playerId].pawnId = pawnId;
            SetResponse responseDice2 = await client.SetTaskAsync(gbdb.gameId + "/players/" + playerId, pdb[playerId]);
        }

        public async void addProperty(String s, int playerId)
        {
            pdb[playerId].assets.Add(s);
            SetResponse responseDice2 = await client.SetTaskAsync(gbdb.gameId + "/players/" + playerId, pdb[playerId]);
        }
        public async void setOfferNoBid(int b, int playerId)
        {
            pdb[playerId].bid = b;
            SetResponse responseOffer = await client.SetTaskAsync(gbdb.gameId + "/players/" + playerId, pdb[playerId]);
            getGameBoardDB();
        }

        public async void setOffer(int b, int playerId)
        {
            pdb[playerId].bid = b;
            SetResponse responseOffer = await client.SetTaskAsync(gbdb.gameId + "/players/" + playerId, pdb[playerId]);
            getGameBoardDB();
            gbdb.bidCount = gbdb.bidCount + 1;
            SetResponse responseBidCount = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setBidCount(int k)
        {
            gbdb.bidCount = k;
            SetResponse responseBidCount = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setCurrentPlayer(int k)
        {
            gbdb.currentPlayer = k;
            SetResponse responseCurrentPlayer = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setEndTurn(bool b)
        {
            gbdb.endTurn = b;
            SetResponse responseEndTurn = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
        public async void setEndTurnInside(bool b)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(200));
            gbdb.endTurn = b;
            SetResponse responseEndTurn = await client.SetTaskAsync(gbdb.gameId + "/gameBoard/", gbdb);
        }
    }
}
