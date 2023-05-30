using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawn : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        //Color newColor = new Color(Random.value, Random.value, Random.value);
        var objRenderer = player.GetComponent<Renderer>().sharedMaterial;
        objRenderer.color = Color.blue;

        Vector3 randomWhitePos = new Vector3(-1.5f, 0.55f, -1.5f);
        PhotonNetwork.Instantiate(player.name, randomWhitePos, Quaternion.identity);
    }
}
