using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer myRenderer;
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }
    /*------- Week 6: ------  ------  Challenge 1 ------  ------  Intermediate ------
     * 1. Write a function that changes the colour of the player whenever they press "c". 
     *      Use Random.Range and randomise the colour of our player game object by using the code in the update function below. 
     *      Try to implemented this with both RGB values between 0-255 (Color32) and 0-1 (Color) 
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
*/
    // Update is called once per frame
    void Update()
    {
        myRenderer.color = new Color(1f,0,1f,0.5f);
    }
    /*------- Week 6: ------  ------  Challenge 3 ------  ------  Hard ------
     * 1. Write a public function that allows you to change the opacity of your player object based on their healthchanges the colour of the player whenever they press "c". 
     * 2. As the player health changes, call the function above from the "health manager" class to update the colour okf player.
     *    note: - 100 health is 100% opacity and 0 health is 0% opacity
     *          - Both Color and Color32 accept Red,Green,Blue, Alpha (RGBA) values
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
    */
}
