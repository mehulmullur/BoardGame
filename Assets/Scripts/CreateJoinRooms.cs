using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class CreateJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField create, join;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }
}
