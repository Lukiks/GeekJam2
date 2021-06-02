using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSC : MonoBehaviour
{

    public int health = 3;
    public int metalScrap = 0; 
    public int electronicParts = 0; 
    public int energyCells = 6;

    public GameObject deadPanel;
    public GameObject[] hrImages;
    public GameObject panelPaper;
    public bool paperBool = false;
    private float paperTimer = 5f;


    public Text[] eq;

    void Start()
    {
        
    }

    void Update()
    {
        if (paperBool)
        {
            paperTimer -= Time.deltaTime;
            if (paperTimer < 0f)
                paperBool = false;
        }
        else
            paperTimer = 5f;
        panelPaper.active = paperBool;

        eq[0].text = metalScrap.ToString();
        eq[1].text = electronicParts.ToString();
        eq[2].text = energyCells.ToString();


        if (health <= 0)
            Dead();

        for (int i = 0; i < hrImages.Length; i++)
        {
            if (i == health -1)
                hrImages[i].active = true;
            else
                hrImages[i].active = false;

        }
    }

    private void Dead()
    {
        deadPanel.active = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
