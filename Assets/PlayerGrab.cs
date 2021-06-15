using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject Myhand;
    bool inHands = false;
    Vector3 ballPos;
    void Start()
    {
        ballPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                ball.transform.SetParent(Myhand.transform);
                ball.transform.localPosition = new Vector3(-0.01f, -0.28f, 0.343f);
                inHands = true;
            } else if (inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                ball.transform.SetParent(null);
                ball.transform.localPosition = ballPos;
                inHands = false;
            }
        }
    }
}
