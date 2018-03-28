using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 4.3)
        {
            Destroy(this.gameObject);//删除子弹
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            if (!other.GetComponent<Enemy>().isDeath)
            {
                other.gameObject.SendMessage("BeHit");//调用方法
                GameObject.Destroy(this.gameObject);//子弹碰到敌人消除
            }
        }
    }
}
