using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Johnny Joebird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0) && logic.alive)
        if(Input.GetKeyDown(KeyCode.U) && logic.alive)
            myRigidbody.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
    }
}
