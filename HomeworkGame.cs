using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkGame : MonoBehaviour
{
    string max = "Ace";
    int min = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void StartGame()
    {
        Debug.Log("WELCOME");
        Debug.Log("Pick a suit.....");
        Debug.Log("Diamonds?");
        Debug.Log("Hearts?");
        Debug.Log("Clubs?");
        Debug.Log("Spades?");
        Debug.Log("The highest value is Ace, the lowest is 2");
        Debug.Log("Tell me if your card is higher or lower than Jack?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

        string[] highSuits = { "Ace", "King",
                        "Queen", "Joker"};
        List<string> cardSuit = new List<string>(highSuits);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
