using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkmanager : MonoBehaviour
{
    const string VERSION = "v0.0.1";
    public string roomName = "racing";
    public string PlayerPrefabname = "Car Player";
    public Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.autoJoinLobby = true;
        PhotonNetwork.ConnectUsingSettings(VERSION);
    }

    void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
        RoomOptions roomOptions = new RoomOptions() { IsVisible = false, MaxPlayers = 4 };
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(PlayerPrefabname,
                                    SpawnPoint.position,
                                    SpawnPoint.rotation,
                                    0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
