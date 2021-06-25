using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public AudioSource crash;
    // Start is called before the first frame update
    void Start()
    {
        crash = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "House_07 (1)" || collision.gameObject.name == "Car_6_Silver")
        {
            crash.Play();
        }
    }
}
