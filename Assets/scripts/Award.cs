using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Award : MonoBehaviour {

    public int type = 0;
    public float speed = 1.5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (this.transform.position.y <= -4.5f) {
            Destroy(this.gameObject);
        }
	}
    
}
