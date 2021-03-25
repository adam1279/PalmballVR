using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveHandPositions : MonoBehaviour
{
    public OSC osc;
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/Right/", LogMsg);
        //osc.SetAddressHandler("/HandPosition1", SetHandPosition1);
        //osc.SetAddressHandler("/HandPosition2", SetHandPosition2);
        Debug.Log("huh");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LogMsg(OscMessage msg) {
        Debug.Log("ok "+msg);
    }
    void SetHandPosition1(OscMessage msg) {
        Debug.Log(msg);
    }
    void SetHandPosition2(OscMessage msg) {
        Debug.Log(msg);
    }
}
