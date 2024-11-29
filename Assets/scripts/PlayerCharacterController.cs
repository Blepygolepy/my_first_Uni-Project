using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    float xMovement = 0;
    float jumpValue=0;

    Vector2 targetVelocity = new Vector2(0,0);

    public float movementSpeed = 0.5f;
    public float jumpAmount = 15f;

    Rigidbody2D playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        CheckInputs();
        targetVelocity.Set(xMovement * movementSpeed, jumpValue * jumpAmount);
        playerRigidBody.velocity += targetVelocity;

    }
    /*------- Week 6: ------  ------  Challenge 4 ------  ------  Easy ------
 * 1. Check when the player is pressing down the shiftkey and if so, double the player movementSpeed otherwise set movementSpeed = 0.5f
 * 2. Set player health from the start function here. 
 */
    void CheckInputs() {
        xMovement = Input.GetAxis("Horizontal");
        jumpValue = Input.GetAxis("Jump");
    }
}
