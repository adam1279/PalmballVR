using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mirror
{
    /// <summary>Shows NetworkManager controls in a GUI at runtime.</summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Network/NetworkManagerHUD")]
    [RequireComponent(typeof(NetworkManager))]
    [HelpURL("https://mirror-networking.com/docs/Articles/Components/NetworkManagerHUD.html")]
    public class Control : MonoBehaviour
    {
        NetworkManager manager;
        // Start is called before the first frame update
        void Start()
        {
            manager = GetComponent<NetworkManager>();
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                manager.StartHost();
                Debug.Log("rain");
                
            } else {
                manager.StartClient();
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}