using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class DesisionPlayer : MonoBehaviour
{

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
    System.Random rnd = new System.Random();

    public void Rock()
    {
        if (!Done)
        {
            AI(1);
            Debug.Log("Rock");
        }
    }
    public void Paper()
    {
        if (!Done)
        {
            AI(2);
            Debug.Log("Paper");
        }
    }
    public void Siccors()
    {
        if (!Done)
        {
            AI(3);
            Debug.Log("Siccors");
        }
    }
    public void AI(int Player)
    {
        Done = true;
        ai=rnd.Next(1,3);
        if(Player==1 && ai == 2)
        {WIN();}
        else if (Player==1 && ai ==3)
        { LOSE();}
        if (Player==2 && ai ==3)
        { WIN();}
        else if (Player == 2 && ai == 1)
        { LOSE(); }
        if (Player == 3 && ai == 1)
        { WIN(); }
        else if (Player == 3 && ai == 2)
        { LOSE(); }


    }
    public void WIN() 
    {
        Debug.Log("win");
    }
    public void LOSE()
    {
        Debug.Log("win");
    }

}
