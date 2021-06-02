using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public GameObject player;
    public GameObject timer;
    private float distance;
    public float minDistance;
    private float timeToInteract;
    public float timeTI;
    public bool pickUp;

    public int toDo;
    public int paper;

    private void OnMouseDown()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (minDistance >= distance)
            pickUp = true;
    }

    private void Update()
    {
        timer.GetComponentInChildren<Text>().text = timeToInteract.ToString();
        if(pickUp)
        {
            timer.active = true;
            if (Input.GetMouseButtonDown(1))
            {
                timer.active = false;
                pickUp = false;
            }
            timeToInteract -= 1 * Time.deltaTime;
            if(timeToInteract <= 0)
            {
                timer.active = false;
                Interaction();
                pickUp = false;
            }
            if (minDistance < Vector2.Distance(transform.position, player.transform.position))
                pickUp = false;
        }
        else
        {
            timer.active = false;
            timeToInteract = timeTI;
        }
    }


    void Interaction()
    {

        switch (toDo)
        {
            //Aidkit
            case 0:
                player.GetComponent<PlayerSC>().health = 3;
                Destroy(gameObject);
                break;
            //Paper
            case 1:
                player.GetComponent<Paper>().papersbool[paper] = true;
                player.GetComponent<PlayerSC>().paperBool = true;
                Destroy(gameObject);
                break;
            //Car
            case 2:
                if(paper == 0)
                {
                    player.GetComponent<PlayerSC>().metalScrap += 2;
                    player.GetComponent<PlayerSC>().electronicParts += 1;
                    paper = 1;
                }
                break;
            //Robot
            case 3:
                if (paper == 0)
                {
                    player.GetComponent<PlayerSC>().metalScrap += 1;
                    player.GetComponent<PlayerSC>().electronicParts += 2;
                    player.GetComponent<PlayerSC>().energyCells += 4;
                    paper = 1;
                }
                break;
            //Wiadro
            case 4:
                if (paper == 0)
                {
                    player.GetComponent<PlayerSC>().metalScrap += 1;
                    paper = 1;
                }
                break;
        }
    }
}
