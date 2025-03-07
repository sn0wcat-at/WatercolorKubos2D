using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text_YouWin : MonoBehaviour

{
    // Text_YouWin
}

public class TextTriggerScript : MonoBehaviour
{
    public GameObject textObject; // Assign your text GameObject in the Inspector

    void Start()
    {
        // Initially hide the text
        textObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Show the text when the player enters the trigger
            textObject.SetActive(true);
            Debug.Log("Text displayed as player enters trigger.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the text when the player exits the trigger
            textObject.SetActive(false);
            Debug.Log("Text hidden as player exits trigger.");
        }
    }
}
