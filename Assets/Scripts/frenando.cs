using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frenando : MonoBehaviour
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
        if (collision.gameObject.name == "RoadBlock_D (2)")
        {
            crash.Play();
        }
    }
}
