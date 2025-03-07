using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTunnel : MonoBehaviour
{
    // Variables for configuring the wind tunnel
    public float windForce = 1f; // The force applied by the wind
    public float windDirection = 90f; // The direction of the wind in degrees

    private Vector2 windVector;

    void Start()
    {
        // Convert the wind direction from degrees to a unit vector
        float radians = windDirection * Mathf.Deg2Rad;
        windVector = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians)) * windForce;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    // Apply the wind force to the player's Rigidbody2D
                    rb.AddForce(windVector, ForceMode2D.Impulse);
                }
            }
            Debug.Log("Player has entered the wind tunnel."); // Debug log for player entry
        }
    }


    /*
    void OnTriggerStay2D(Collider2D other)
    {
        // Continuously apply wind force while the player is inside the wind tunnel
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Apply the wind force continuously to the player's Rigidbody2D
                rb.AddForce(windVector * Time.deltaTime, ForceMode2D.Force);
                Debug.Log("Wind force applied to player."); // Debug log for force application
            }
        }
    }
    */


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited the wind tunnel."); // Debug log for player exit
        }
    }
}
