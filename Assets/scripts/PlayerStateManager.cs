using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    HealthManager playerHealthManager;
    // Start is called before the first frame update
    /*------- Week 6: ------  ------  Challenge 2 ------  ------  Intermediate ------
 * 1. Make a new public function in HealthManager class and call it SetHealth() 
 * 2. Set player health from the start function here. 
 */

    void Start()
    {
        playerHealthManager = GetComponent<HealthManager>();
        print(playerHealthManager.GetHealth());

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.G))
        {
            playerHealthManager.TakeDamage(2f); 

        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            playerHealthManager.Heal(1f);

        }
    }
}
