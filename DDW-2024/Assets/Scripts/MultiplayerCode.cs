using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MultiplayerCode : MonoBehaviour
{
    InputAction P1Button1;
    InputAction P1Button2;
    InputAction P1Button3;

    InputAction P2Button1;
    InputAction P2Button2;
    InputAction P2Button3;



    public int P_Hearts = 3;
    public int P_Health = 3;

    public int AI_Hearts = 3;
    public int AI_Health = 3;


    private void Start()
    {
        manager = UnityEngine.Object.FindFirstObjectByType<ScoreManager>();
        P1Button1 = InputSystem.actions.FindAction("N1");
        P1Button2 = InputSystem.actions.FindAction("N2");
        P1Button3 = InputSystem.actions.FindAction("N3");


        P2Button1 = InputSystem.actions.FindAction("M1");
        P2Button2 = InputSystem.actions.FindAction("M2");
        P2Button3 = InputSystem.actions.FindAction("M3");
    }
    bool DoneP1;
    bool DoneP2;
    
    int Player1;
    int Player2;


    public Image[] P_hearts;
    public Image[] AI_hearts;

    public Sprite fullheart;
    public Sprite emptyHeart;


    private ScoreManager manager;

    public float targetTime = 0.0f;
    public bool timerEnd = false;

    System.Random rnd = new System.Random();


    public void FixedUpdate()
    {
        #region player 1
        if (P1Button1.IsPressed())
        {
            Rock(1);
        }
        if (P1Button2.IsPressed())
        {
            Paper(1);
        }
        if (P1Button3.IsPressed())
        {
            Scissors(1);
        }
        #endregion 

        #region player 2
        if (P2Button1.IsPressed())
        {
            Rock(2);
        }
        if (P2Button2.IsPressed())
        {
            Paper(2);
        }
        if (P2Button3.IsPressed())
        {
            Scissors(2);
        }
        #endregion
    }

    public void Rock(int player)
    {
        if (player == 1)
        {
            if (DoneP1 == false)
                {
                    Player1 = 1;
                    DoneP1 = true;
                    AI();
                    Debug.Log("Rock");
                }
        }

        else if (player == 2)
        {
            if (DoneP2 == false)
            {
                Player2 = 1;
                DoneP2 = true;
                AI();
                Debug.Log("Rock");
            }
        }
    }
    public void Paper(int player)
    {
        if (player == 1)
        {
            if (DoneP1==false)
            {
                Player1 = 2;
                DoneP1 = true;
                AI();
                Debug.Log("Paper");
            }
        }

        else if (player == 2)
        {
            if (DoneP2 == false)
            {
                Player2 = 2;
                DoneP2 = true;
                AI();
                Debug.Log("Paper");
            }
        }
    }
    public void Scissors(int player)
    {
        if (player == 1)
        {
            if (DoneP1 == false)
            {
                Player1 = 1;
                DoneP1 = true;
                AI();
                Debug.Log("Scissors");
            }
        }

        else if (player == 2)
        {
            if (DoneP2 == false)
            {
                Player2 = 1;
                DoneP2 = true;
                AI();
                Debug.Log("Scissors");
            }
        }
    }


    public void AI()
    {
        if (DoneP1== true && DoneP2 == true)
        {
            timerEnd = false;
            if (Player1 == 1 && Player2 == 3)
            { WIN(); }
            else if (Player1 == 1 && Player2 == 2)
            { LOSE(); }
            else if (Player1 == 2 && Player2 == 1)
            { WIN(); }
            else if (Player1 == 2 && Player2 == 3)
            { LOSE(); }
            else if (Player1 == 3 && Player2 == 2)
            { WIN(); }
            else if (Player1 == 3 && Player2 == 1)
            { LOSE(); }
            else if (Player1 == 1 && Player2 == 1 || Player1 == 2 && Player2 == 2 || Player1 == 3 && Player2 == 3)
            { TIE(); }
        }
    }
    public void TIE()
    {
        manager.Tie(Player1, Player2);
        targetTime = 3.0f;
    }
    public void WIN()
    {
        AI_Health = AI_Health - 1;
        if (AI_Health <= 0)
        {
            SceneManager.LoadScene("win");
        }
        else { targetTime = 3.0f; }
        Debug.Log("AI health: " + AI_Health);
        manager.Win(Player1, Player2);

        if (AI_Health > AI_Hearts) { AI_Health = AI_Hearts; }
        for (int i = 0; i < AI_hearts.Length; i++)
        {

            if (i < AI_Health) { P_hearts[i].sprite = fullheart; }
            else { AI_hearts[i].sprite = emptyHeart; }

            if (i < AI_Hearts)
            {
                AI_hearts[i].enabled = true;
            }
            else
            {
                AI_hearts[i].enabled = false;
            }
        }
    }
    public void LOSE()
    {
        P_Health = P_Health - 1;
        if (P_Health <= 0)
        {
            SceneManager.LoadScene("lose");
        }
        else { targetTime = 3.0f; }
        Debug.Log("Player health: " + P_Health);
        manager.Loss(Player1, Player2);

        if (P_Health > P_Hearts) { P_Health = P_Hearts; }
        for (int i = 0; i < P_hearts.Length; i++)
        {

            if (i < P_Health) { P_hearts[i].sprite = fullheart; }
            else { P_hearts[i].sprite = emptyHeart; }

            if (i < P_Hearts)
            {
                P_hearts[i].enabled = true;
            }
            else
            {
                P_hearts[i].enabled = false;
            }
        }

    }

    private void Update()
    {

        if (DoneP1 == true && DoneP2 == true)
        {
            targetTime -= Time.deltaTime;
        }

        if (targetTime <= 0.0f&& timerEnd == false)
        {
            timerEnded();
        }





    }

    void timerEnded()
    {
        timerEnd = true;
        DoneP1 = false;
        DoneP2 = false;
    }

}
