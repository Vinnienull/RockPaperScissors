using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public string p1Choice = "None";
    public string p2Choice = "None";

    public Text winText;
    public GameObject textHost;

    public void p1Fire()
    {
        Debug.Log("Player 1 picked Fire!");
        p1Choice = "Fire";
        winCheck();
    }

    public void p1Water()
    {
        Debug.Log("Player 1 picked Water!");
        p1Choice = "Water";
        winCheck();
    }

    public void p1Earth()
    {
        Debug.Log("Player 1 picked Earth!");
        p1Choice = "Earth";
        winCheck();
    }

    public void p2Fire()
    {
        Debug.Log("Player 2 picked Fire!");
        p2Choice = "Fire";
        winCheck();
    }

    public void p2Water()
    {
        Debug.Log("Player 2 picked Water!");
        p2Choice = "Water";
        winCheck();
    }

    public void p2Earth()
    {
        Debug.Log("Player 2 picked Earth!");
        p2Choice = "Earth";
        winCheck();
    }

    public void Reset()
    {
        Debug.Log("Reset!");
        p1Choice = "None";
        p2Choice = "None";
        textHost.SetActive(false);
    }

    private void winCheck()
    {
        Debug.Log("winCheck called");
        if (p1Choice != "None" && p2Choice != "None")
        {
            Debug.Log("fight time");
            textHost.SetActive(true);
            if(p1Choice == "Fire")
            {
                if(p2Choice == "Fire")
                {
                    Debug.Log("Draw");
                    winText.text = "Draw";
                }
                else if (p2Choice == "Water")
                {
                    Debug.Log("P2 Wins!");
                    winText.text = "Player 2 Wins!";
                }
                else if (p2Choice == "Earth")
                {
                    Debug.Log("P1 Wins!");
                    winText.text = "Player 1 Wins!";
                }
            }
            else if (p1Choice == "Water")
            {
                if (p2Choice == "Fire")
                {
                    Debug.Log("P1 Wins!");
                    winText.text = "Player 1 Wins!";
                }
                else if (p2Choice == "Water")
                {
                    Debug.Log("Draw");
                    winText.text = "Draw";
                }
                else if (p2Choice == "Earth")
                {
                    Debug.Log("P2 Wins!");
                    winText.text = "Player 2 Wins!";
                }
            }
            else if (p1Choice == "Earth")
            {
                if (p2Choice == "Fire")
                {
                    Debug.Log("P2 Wins!");
                    winText.text = "Player 2 Wins!";
                }
                else if (p2Choice == "Water")
                {
                    Debug.Log("P1 Wins!");
                    winText.text = "Player 1 Wins!";
                }
                else if (p2Choice == "Earth")
                {
                    Debug.Log("Draw");
                    winText.text = "Draw";
                }
            }
        }
    }
}
