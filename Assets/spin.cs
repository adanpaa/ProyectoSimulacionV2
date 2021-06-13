using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinValue = 90;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
    }

    public void flipSpin()
    {
        spinValue = -spinValue;
    }
}
