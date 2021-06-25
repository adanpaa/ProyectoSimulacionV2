using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public AudioSource crash;
    public string obj1 = "House_07 (1)";
    public string obj2 = "Car_6_Silver";
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
        if (collision.gameObject.name ==obj1 || collision.gameObject.name == obj2)
        {
            crash.Play();
        }
    }
}
