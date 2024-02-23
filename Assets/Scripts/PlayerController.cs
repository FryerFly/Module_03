using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //creates a variable for the rigidbody component of the player to be reffered to later. 
    private Rigidbody playerRb;

    //Public variables
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    public bool gameOver = false;



    // Start is called before the first frame update
    void Start()
    {
        //gets the component called rigidbody attached to the player.
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        //playerRb.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false; 
        }
        
    }

    private void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("Obstacle")){
            Debug.Log("Game Over");
            gameOver = true;
        }
    }
}
