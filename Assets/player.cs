using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float moveSpeed = 1.5f;
	public float rotateSpeed = 1.0f;

	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("up"))
			transform.Translate(Vector3.forward * moveSpeed);
		if (Input.GetKey("down"))
			transform.Translate(Vector3.forward * -moveSpeed);
		if (Input.GetKey("left"))
			transform.Rotate(Vector3.up * -rotateSpeed);
		if (Input.GetKey("right"))
			transform.Rotate(Vector3.up * rotateSpeed);

	}

}
