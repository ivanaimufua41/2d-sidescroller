using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
    private Rigidbody2D playerRigidbody2D;
    private float movePlayerHorizontal;
    private Vector2 movement;
    private Animator playerAnim;
    private SpriteRenderer playerSpriteImage;

    public float speed = 2.0f;

	// Use this for initialization
	void Awake () {
        playerRigidbody2D = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
        playerAnim = (Animator)GetComponent(typeof(Animator));
        playerSpriteImage = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
	}
	
	// Update is called once per frame
	void Update () {

        if (movePlayerHorizontal > 0)
        {
            playerAnim.SetBool("isWalking", true);
            playerSpriteImage.flipX = false;
        }

        else if(movePlayerHorizontal < 0)
        {
            playerAnim.SetBool("isWalking", true);
            playerSpriteImage.flipX = true;
        }

        else
        {
            playerAnim.SetBool("isWalking", false);
        }
 
        movePlayerHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(movePlayerHorizontal, 0);

        playerRigidbody2D.velocity = movement * speed;
	}
}
