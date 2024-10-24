using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject PausePanel;

    public void Pause() 
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue() 
    {
        PausePanel.SetActive(false);
        Time.timeScale = 0;
    }
}
