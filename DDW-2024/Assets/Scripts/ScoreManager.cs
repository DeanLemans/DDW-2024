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


        ResultText.text = "You Won: you used " + Player + " and the AI used " + AI;
        
    }
    public void Loss(int player, int ai)
    {
        if (player == 1) { Player = "Rock"; }
        else if (player == 2) { Player = "Paper"; }
        else if (player == 3) { Player = "Scissors"; }


        if (ai == 1) { AI = "Rock"; }
        else if (ai == 2) { AI = "Paper"; }
        else if (ai == 3) { AI = "Scissors"; }



        ResultText.text = "You Lost: you used " + Player + " but the AI used " + AI;
    }
    public void Tie(int player, int ai)
    {
        if (player == 1) { Player = "Rock"; }
        else if (player == 2) { Player = "Paper"; }
        else if (player == 3) { Player = "Scissors"; }

        ResultText.text = "You Tied: you both used " + Player;
    }
}
