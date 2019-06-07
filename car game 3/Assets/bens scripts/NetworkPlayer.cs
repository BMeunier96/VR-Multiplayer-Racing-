using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class NetworkPlayer : Photon.MonoBehaviour
{
    public GameObject myCamera;

    // Start is called before the first frame update
    void Start()
    {
        if (photonView.isMine)
        {
            myCamera.SetActive(true);
            GetComponent<CarController>().enabled = true;
            GetComponent<CarUserControl>().enabled = true;
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
