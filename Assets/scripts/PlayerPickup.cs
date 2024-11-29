using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    /*------- Week 6: ------  ------  Challenge 5 ------  ------  Hard ------
 * 1. Make a new prefab for pickup objects
 * 2. Attach this script to it
 * 3. You have access to the player game object by using thePlayer variable below. 
 * 4. Write a function to check the distance between this game object (transform.position) and the player
 * 5. If the distance is less than 1
 * 6. Call the AddToScore function from the Inventory manager variable
 */
    GameObject thePlayer;
    InventoryManager playerInventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer= GameObject.Find("Player");
        playerInventoryManager = thePlayer.GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
