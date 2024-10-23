using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene("PVP");
        Debug.Log("the entity know as player has begun playing the game"); 
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("the entity know as player has quit the game");
    }

    public void Restart()
    {
        SceneManager.LoadScene("main menu");
        Debug.Log("the entity know as player has restarted the game");
    }
}
