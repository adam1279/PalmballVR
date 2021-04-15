using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Transform ball;
    public int hits = 0;
    // Start is called before the first frame update
    void Start()
    {
        hits = 0;
        InvokeRepeating("CreateBall", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreateBall()
    {
        Instantiate(ball);

    }
    public void Hit() {
        Debug.Log("ry");
        hits += 1;
    }
}
