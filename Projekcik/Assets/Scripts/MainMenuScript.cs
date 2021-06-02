using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    float timer = 2.6f;
    bool timerbool = false;
    
    void Update()
    {
        if (timerbool)
            timer -= Time.deltaTime;

        if (timer < 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Playgame()
    {
        timerbool = true;
    }

    void Start()
    {
        StartCoroutine(Quitgame());
    }

    IEnumerator Quitgame()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("quit");
            //Application.Quit();
    }

}