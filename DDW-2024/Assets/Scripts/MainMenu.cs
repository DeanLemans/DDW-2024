using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene("PVP");
        Debug.Log("tThe entity know as player has begun playing the game."); 
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("The entity know as player has quit the game.");
    }

    public void Restart()
    {
        SceneManager.LoadScene("main menu");
        Debug.Log("The entity know as player has restarted the game.");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
        Debug.Log("The entity know as player initiated the tutorial.");
    }

    public void About()
    {
        SceneManager.LoadScene("about");
        Debug.Log("The entity know as player look at our about page.");
    }

    public void NuhUh()
    {
        SceneManager.LoadScene("lose");
        Debug.Log("The entity know as player has restarted the game.");
    }
}
