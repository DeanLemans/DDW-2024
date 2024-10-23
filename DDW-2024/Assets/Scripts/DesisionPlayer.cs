using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Windows;
using UnityEngine.UI;
public class DesisionPlayer : MonoBehaviour
{
    public int P_Hearts = 3;
    int P_Health = 3;

    public int AI_Hearts = 3;
    int AI_Health = 3;
    #region test
    /*
    InputAction P1Button1;
    InputAction P1Button2;
    InputAction P1Button3;

    InputAction P2Button1;
    InputAction P2Button2;
    InputAction P2Button3;


    bool rock1 = false; bool rock2 = false;
    bool paper1 = false; bool paper2 = false;
    bool siccors1 = false; bool siccors2 = false;

    private void Start()
    {

        P1Button1 = InputSystem.actions.FindAction("N1");
        P1Button2 = InputSystem.actions.FindAction("N2");
        P1Button3 = InputSystem.actions.FindAction("N3");


        P2Button1 = InputSystem.actions.FindAction("M1");
        P2Button2 = InputSystem.actions.FindAction("M2");
        P2Button3 = InputSystem.actions.FindAction("M3");
    }
    public void FixedUpdate()
    {
        #region player 1
        if (P1Button1.IsPressed())
        {
            rock1 = true; paper1 = false; siccors1 = false;
        }
        if (P1Button2.IsPressed())
        {
            rock1 = false; paper1 = true; siccors1 = false;
        }
        if (P1Button3.IsPressed())
        {
            rock1 = false; paper1 = false; siccors1 = true;
        }
        #endregion 
        #region player 2
        if (P2Button1.IsPressed())
        {
            rock2 = true; paper2 = false; siccors2 = false;
        }
        if (P2Button2.IsPressed())
        {
            rock2 = false; paper2 = true; siccors2 = false;
        }
        if (P2Button3.IsPressed())
        {
            rock2 = false; paper2 = false; siccors2 = true;
        }
        Result();
    }
    #endregion



    public void Result()
    {
        #region Player 1 result
        if (rock1 == true && siccors2 == true) { P1Wins(); }
        if (paper1 == true && rock2 == true) { P1Wins(); }
        if (siccors1 == true && paper2 == true) { P1Wins(); }
        #endregion
        #region Player 2 result
        if (rock2 == true && siccors1 == true) { P2Wins(); }
        if (paper2 == true && rock1 == true) { P2Wins(); }
        if (siccors2 == true && paper1 == true) { P2Wins(); }
        else if (rock1 == true && rock2 == true|| paper1 == true && paper2 == true|| siccors1 == true && siccors2 == true) { Draw(); }

        #endregion
    }
    public void P1Wins()
    {
        Debug.Log("p1");
        Debug.Log(" rock "+ rock1 +" siccors " +siccors1 + " paper "+paper1 + rock2 + siccors2 + paper2);
        
    }
    public void P2Wins()
    {
        Debug.Log("p2");
        Debug.Log(" rock " + rock1 + " siccors " + siccors1 + " paper " + paper1 + rock2 + siccors2 + paper2);
    }
    public void Draw()
    {
        Debug.Log("draw");
        Debug.Log(" rock " + rock1 + " paper " + siccors1 + " siccors " + paper1 + rock2 + siccors2 + paper2);

    }
    */
    #endregion test
    bool Done;
    int ai;
    int Player;


    public Image[] P_hearts;
    public Image[] AI_hearts;

    public Sprite fullheart;
    public Sprite emptyHeart;


    private ScoreManager manager;

    public float targetTime = 0.0f;

    System.Random rnd = new System.Random();
    private void Start()
    {
        manager = GameObject.FindObjectOfType<ScoreManager>();
    }
    public void Rock()
    {
        if (!Done)
        {
            Player = 1;
            AI();
            Debug.Log("Rock");
        }
    }
    public void Paper()
    {
        if (!Done)
        {
            Player = 2;
            AI();
            Debug.Log("Paper");
        }
    }
    public void Siccors()
    {
        if (!Done)
        {
            Player = 3;
            AI();
            Debug.Log("Siccors");
        }
    }
    public void AI()
    {
        Done = true;
        ai=rnd.Next(1,3);
        if (Player == 1 && ai == 2)
        { WIN(); }
        else if (Player == 1 && ai == 3)
        { LOSE(); }
        else if (Player == 2 && ai == 3)
        { WIN(); }
        else if (Player == 2 && ai == 1)
        { LOSE(); }
        else if (Player == 3 && ai == 1)
        { WIN(); }
        else if (Player == 3 && ai == 2)
        { LOSE(); }
        else if (Player==1 && ai==1 || Player == 2 && ai==2 || Player ==3 && ai==3) 
        { TIE(); }
        if (ai == 1) { Debug.Log("AI chose Rock"); }
        else if (ai == 2) { Debug.Log("AI chose Paper"); }
        else if (ai == 3) { Debug.Log("AI chose Scissors"); }
        
    }
    public void TIE()
    {
        manager.Tie(Player, ai);
        
    }
    public void WIN() 
    {
        AI_Health = AI_Health-1;
        if (AI_Health <= 0) 
        {
            SceneManager.LoadScene("win");
        }
        else {targetTime = 5.0f; }
        Debug.Log("Player health: " + P_Health);
        manager.Win(Player, ai);
    }
    public void LOSE()
    {
        P_Health = P_Health - 1;
        if (AI_Health <= 0)
        {
            SceneManager.LoadScene("lose");
        }
        else { targetTime = 3.0f; }
        Debug.Log("AI health: " + AI_Health);
        manager.Loss(Player, ai);
    }

    private void Update()
    {
        

            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
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


        if (AI_Health > AI_Hearts) { AI_Health = AI_Hearts; }
        for (int i = 0; i < AI_hearts.Length; i++)
        {

            if (i < AI_Health) { P_hearts[i].sprite = fullheart; }
            else { AI_hearts[i].sprite = emptyHeart; }

            if (i < P_Hearts)
            {
                AI_hearts[i].enabled = true;
            }
            else
            {
                AI_hearts[i].enabled = false;
            }
        }




    }
    void timerEnded()
        {
        Done = false;
        }






}


