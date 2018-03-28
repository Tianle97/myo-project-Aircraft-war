using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy0Prefab;
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    //public GameObject enemy3Prefab;
    public GameObject Award_type_0;
    public GameObject Award_type_1;
    public float enemy0Rate = 1f;
    public float enemy1Rate = 5f;
    public float enemy2Rate = 20f;
    public float Award_type_0Rate = 25f;
    public float Award_type_1Rate = 30f;
    // Use this for initialization
    void Start() { 
        InvokeRepeating("createEnemy0", 1, enemy0Rate);//生成对象
        InvokeRepeating("createEnemy1", 10, enemy1Rate);
        InvokeRepeating("createEnemy2", 20, enemy2Rate);
        InvokeRepeating("createAward_type_0",25, Award_type_0Rate);
        InvokeRepeating("createAward_type_1",10, Award_type_1Rate);


}

// Update is called once per frame
void Update()
{



}
public void createEnemy0()
{
    float x = Random.Range(-2.15f, 2.15f);//在范围内随机生成对象
    GameObject.Instantiate(enemy0Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
}
public void createEnemy1()
{
        //this.GetComponent<AudioSource>().Play();
        float x = Random.Range(-2.04f, 2.04f);
    GameObject.Instantiate(enemy1Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
}
public void createEnemy2()
{
    float x = Random.Range(-1.55f, 1.55f);
    GameObject.Instantiate(enemy2Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
}
public void createAward_type_0()
{
        //this.GetComponent<AudioSource>().Play();
        float x = Random.Range(-2.0f, 2.0f);//在范围内随机生成对象
    GameObject.Instantiate(Award_type_0, new Vector3(x, transform.position.y, 0), Quaternion.identity);
}
public void createAward_type_1()
{
        //this.GetComponent<AudioSource>().Play();
        float x = Random.Range(-2.0f, 2.0f);//在范围内随机生成对象
    GameObject.Instantiate(Award_type_1, new Vector3(x, transform.position.y, 0), Quaternion.identity);
}
}