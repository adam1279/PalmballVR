using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
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
}
