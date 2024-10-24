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


        ResultText.text = "You used " + Player + " and the oponent used " + AI + " [ Clash Won! ]";
        
    }
    public void Loss(int player, int ai)
    {
        if (player == 1) { Player = "Shield"; }
        else if (player == 2) { Player = "Magic Scroll"; }
        else if (player == 3) { Player = "Sword"; }


        if (ai == 1) { AI = "Shield"; }
        else if (ai == 2) { AI = "Magic Scroll"; }
        else if (ai == 3) { AI = "Sword"; }



        ResultText.text = "You used " + Player + " and oponent used " + AI + " [ Clash Lost! ]";
    }
    public void Tie(int player, int ai)
    {
        if (player == 1) { Player = "Shield"; }
        else if (player == 2) { Player = "Magic"; }
        else if (player == 3) { Player = "Sword"; }

        ResultText.text = "Both chose " + Player + " [ Its a Tie! ]";
    }
}
