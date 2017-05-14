using UnityEngine;
using System.Collections;

public class SwanMove : MonoBehaviour {

	// Use this for initialization
    private float moveSpeed = 4;
	void Start () {
        transform.position = new Vector3(22, 3, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    if (transform.position.x > -22)
        {
            transform.Translate(Vector3.right * -moveSpeed * Time.deltaTime);
        }
        else 
        {
            transform.position = new Vector3(22, 3, 0);
        }
	}
}
