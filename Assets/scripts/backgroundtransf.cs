using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundtransf : MonoBehaviour {
    public float moveSpeed = 8f;


	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        Vector3 position = this.transform.position;
        if (position.y <= -8.52f) {
            this.transform.position = new Vector3(position.x, position.y + 8.52f * 2, position.z);
        }
	}
}
