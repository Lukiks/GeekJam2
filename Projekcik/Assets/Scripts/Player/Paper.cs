using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper : MonoBehaviour
{
    public GameObject paper;
    public bool[] papersbool;
    public GameObject[] papers;
    public int page = -1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            paper.active = !paper.active;
        if (!paper.active)
            page = -1;

        if(page != -1)
        {
            if (page >= papers.Length)
                page = -1;
            for (int i = 0; i < papers.Length; i++)
            {
                if (i == page)
                {
                    if (papersbool[i])
                    {
                        papers[i].active = true;
                    }
                    else
                        page += 1;
                }
                else
                    papers[i].active = false;
            }
        }
        else
        {
            for (int i = 0; i < papers.Length; i++)
            {
                papers[i].active = false;
            }
        }
           
        
        if (page < -1)
            page = -1;

    }

    public void TurnPaper(int a)
    {
        page += a;
    }
}
