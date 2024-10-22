using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene("PVP");
        Debug.Log("utton pressed"); 
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("the entity know as player has quit the game");
    }
}
