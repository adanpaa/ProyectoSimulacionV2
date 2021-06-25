using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frenando : MonoBehaviour
{
    public AudioSource crash;
    public string obj1 = "RoadBlock_D (2)";
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
        if (collision.gameObject.name == obj1)
        {
            crash.Play();
        }
    }
}
