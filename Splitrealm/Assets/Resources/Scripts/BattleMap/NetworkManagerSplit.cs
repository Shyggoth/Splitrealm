using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Splitrealm
{
	public class NetworkManagerSplit : NetworkManager
	{
		List<Player> playerList = new List<Player>();
		List<Army> armyList = new List<Army>();
        public Transform leftRacketSpawn;
        public Transform rightRacketSpawn;
        public GameObject mapManager;
        public int playerAmount;

        void Start()
        {
          //  Instantiate(mapManager, new Vector3(0, 0, 0), Quaternion.identity);
         //   SetSpawn();
        }

        public void SetSpawn()
        {
            leftRacketSpawn = GameObject.Find("Light Spawner").GetComponent<Transform>();
            rightRacketSpawn = GameObject.Find("Dark Spawner").GetComponent<Transform>();
        }

        public override void OnServerAddPlayer(NetworkConnection conn)
        {
            Transform start = numPlayers == 0 ? leftRacketSpawn : rightRacketSpawn;
            playerAmount++;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            base.OnServerDisconnect(conn);
        }
    }
}