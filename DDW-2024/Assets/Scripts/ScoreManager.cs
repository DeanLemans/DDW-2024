using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text ResultText;

    string Player;
    string AI;

    public void Win(int player, int ai)
    {
        if (player == 1) { Player = "Rock"; }
        else if (player == 2) { Player = "Paper"; }
        else if (player == 3) { Player = "Scissors"; }


        if (ai == 1) { AI = "Rock"; }
        else if (ai == 2) { AI = "Paper"; }
        else if (ai == 3) { AI = "Scissors"; }


        ResultText.text = "You used " + Player + " and the AI used " + AI + " clash won!";
        
    }
    public void Loss(int player, int ai)
    {
        if (player == 1) { Player = "Shield"; }
        else if (player == 2) { Player = "Magic"; }
        else if (player == 3) { Player = "Sword"; }


        if (ai == 1) { AI = "Shield"; }
        else if (ai == 2) { AI = "Magic"; }
        else if (ai == 3) { AI = "Sword"; }



        ResultText.text = "You used " + Player + " and oponent used " + AI + " clash lost!";
    }
    public void Tie(int player, int ai)
    {
        if (player == 1) { Player = "Shield"; }
        else if (player == 2) { Player = "Magic"; }
        else if (player == 3) { Player = "Sword"; }

        ResultText.text = "Its a Tie! : " + Player;
    }
}
