using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float speed ;
	Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		speed = 10;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
	}
}
