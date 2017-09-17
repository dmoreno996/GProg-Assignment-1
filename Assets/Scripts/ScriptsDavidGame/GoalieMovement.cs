using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieMovement : MonoBehaviour {

    private Vector3 pos1 = new Vector3(9, 2, 0);
    private Vector3 pos2 = new Vector3(-9, 2, 0);
    public float speed = 1.0f;

    // Use this for initialization

    void Start () {
	}

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
        speed += .0003f;
    }
}