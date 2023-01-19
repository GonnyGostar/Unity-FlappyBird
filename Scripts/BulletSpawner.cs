using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bullet;
    public HeadScript headScript;
    public GameObject head;

    // Start is called before the first frame update
    void Start()
    {
        headScript = head.GetComponent<HeadScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)) spawnBullet();
    }

    void spawnBullet() {
        Instantiate(bullet, headScript.transform.position + new Vector3(3,0,0), transform.rotation);
    }
}
