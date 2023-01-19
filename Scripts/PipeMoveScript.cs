using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -30;
    public HeadScript head;
    public LogicScript logic;
    public PipeButtonScript button;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        button = GetComponent<PipeButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // deltatime: speed same no matter the frame rate
        if(logic.alive) transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone) Destroy(gameObject);

        if(button.pressed) {transform.position += Vector3.down * 5;button.pressed=false;}
    }
}
