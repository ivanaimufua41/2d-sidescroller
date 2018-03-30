using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Animator anim;
    float Input_X;
    float Input_Y;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float Input_X = Input.GetAxis("Horizontal");
        float Input_Y = Input.GetAxis("Vertical");

        bool isWalking = (Mathf.Abs(Input_X)) > 0;
        anim.SetBool("isWalking", isWalking);

        if (isWalking)
        {
            anim.SetFloat("x", Input_X);
            anim.SetFloat("y", Input_Y);

            transform.position += new Vector3(Input_X, Input_Y, 0).normalized * Time.deltaTime;
        }


	}
}
