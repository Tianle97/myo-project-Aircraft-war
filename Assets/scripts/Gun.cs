using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float rate = 0.2f;
    public GameObject bullet;
    private void Start()
    {
        openFire();

    }
    public void fire (){
        GameObject.Instantiate(bullet, transform.position, Quaternion.identity);

    }
    public void openFire() {
        InvokeRepeating("fire", 1, rate);
    }
    public void stopFire() {
        CancelInvoke("fire");
    }
}
