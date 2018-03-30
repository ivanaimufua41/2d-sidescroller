using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float xOffset = 0f;
    public float yOffset = 0f;
    public Transform player;

    private Camera _camera;

    void Awake()
    {
        _camera = gameObject.GetComponent<Camera>();

    }
    // Use this for initialization
    void LateUpdate () {

        this.transform.position = new Vector3(player.transform.position.x + xOffset, this.transform.position.y + yOffset, -10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
