using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeButtonScript : MonoBehaviour
{

    public AudioSource sound;
    public bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        sound.Play();
        transform.position += new Vector3(3,0,0);
        pressed = true;
    }
}
