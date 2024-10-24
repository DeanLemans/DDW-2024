using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{

    public GameObject PausePanel;
    InputAction Esc;

    private void Start()
    {
        Esc = InputSystem.actions.FindAction("PauseMenu");
    }
    public void Pause() 
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseEsc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("pressed esc, should sent to pause menu");
        }
    }

    public void Continue() 
    {
        PausePanel.SetActive(false);
        Time.timeScale = 0;
    }
}
