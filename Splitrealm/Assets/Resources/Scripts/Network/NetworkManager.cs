using UnityEngine;

namespace Mirror.Examples.Pong
{
    [AddComponentMenu("")]
    public class NetworkManagerPong : NetworkManager
    {
        public Transform topSpawn;
        public Transform bottomSpawn;

        public override void OnServerAddPlayer(NetworkConnection conn)
        {
            Transform spawn = numPlayers == 0 ? topSpawn : bottomSpawn;
            GameObject player = Instantiate(playerPrefab, spawn.position, spawn.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            base.OnServerDisconnect(conn);
        }
    }
}
