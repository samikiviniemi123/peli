using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

    Vector3 velocity;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    public void Move(Vector3 _velocity){
        velocity = _velocity;
    }

    public void LookAt(Vector3 lookpoint)
    {
        Vector3 heightCorrectedPoint = new Vector3(lookpoint.x, transform.position.y, lookpoint.z);
        transform.LookAt(heightCorrectedPoint);
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

}
