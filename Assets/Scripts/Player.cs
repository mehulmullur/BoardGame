using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    PhotonView view;

    int stepsToMove = 1, stepsMoved;

    bool isGameFinished = false;

    public Route route;

    private void Awake()
    {
        route = FindObjectOfType<Route>();
    }
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if(transform.position.x == 0.5f && transform.position.z  == 0.5f)
        {
            if (isGameFinished)
                return;
            else
            {
                Debug.Log("Game Over");
                isGameFinished = true;
            }
        }

        if (Input.GetKey(KeyCode.W) && view.IsMine)
        {
            StartCoroutine(Move());
            return;
        }
    }

    IEnumerator Move()
    {
        for (int i = stepsMoved; i < (stepsMoved+stepsToMove); i++)
        {
            transform.position = route.commonPath[i].transform.position;
            this.transform.position = new Vector3(transform.position.x, 0.55f, transform.position.z);
            yield return new WaitForSeconds(0.35f);
        }
        stepsMoved += stepsToMove;
    }
}
