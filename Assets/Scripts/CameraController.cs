using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;//private allows us to set value in script
    
     
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        	
	}
	
	// runs after each frame but only after all objects have been updated
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
