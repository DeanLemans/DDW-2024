using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class DesisionPlayer : MonoBehaviour
{
    InputAction P1Button1;  
    InputAction P1Button2;  
    InputAction P1Button3;  

    InputAction P2Button1;
    InputAction P2Button2;
    InputAction P2Button3;


    bool rock1 = true; bool rock2 = true;
    bool paper1 = true; bool paper2 = true;
    bool siccors1 = true; bool siccors2 = true;

    private void Start()
    {
        
        P1Button1 = InputSystem.actions.FindAction("N1");
        P1Button2 = InputSystem.actions.FindAction("N2");
        P1Button3 = InputSystem.actions.FindAction("N3");


        P2Button1 = InputSystem.actions.FindAction("M1");
        P2Button2 = InputSystem.actions.FindAction("M2");
        P2Button3 = InputSystem.actions.FindAction("M3");
    }
    private void FixedUpdate()
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
            rock1 = false; paper1 = false; siccors1=true;
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
    }
    #endregion
}
