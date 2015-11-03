using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	Renderer rend;
	int cont;
	// Use this for initialization
	void Start () {
	
		rend = GetComponent<Renderer>();
		cont = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
			cont = Random.Range(1,5);
			switch(cont){
				case 1:
					rend.material.color = Color.red;
					break;
				case 2:
					rend.material.color = Color.yellow;
					break;
				case 3:
					rend.material.color = Color.green;
					break;
				case 4:
					rend.material.color = Color.blue;
					break;
					

			}
			 
		}
	}
}
