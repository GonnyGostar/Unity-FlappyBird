using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailScript : MonoBehaviour
{

    public float moveSpeed = 20;
    public float deadZone = 30;

    public Rigidbody2D nailBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // nailBody.transform.SetParent(headScript.myRigidbody.transform);
        transform.position += (Vector3.right * moveSpeed) * Time.deltaTime;
        if(transform.position.x > deadZone) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // if(collision.transform.name == "")
        Destroy(gameObject);
    }
}
