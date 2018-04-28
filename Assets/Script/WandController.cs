using UnityEngine;
using Valve.VR;
using System.Collections;
using System.Collections.Generic;

public class WandController : MonoBehaviour
{

    private SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device; 
    public GameObject open, close,cube;
    public static bool take=false;
    
    void Start ()
	{
        
        close.SetActive(false);
    }

	void Update ()
	{
        var deviceIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost);
        device = SteamVR_Controller.Input(deviceIndex);
        var triggerButton = SteamVR_Controller.ButtonMask.Trigger;

        if (device.GetTouchUp(triggerButton))
        {
            open.SetActive(false);
            close.SetActive(true);
        }
        else if (device.GetPressUp(triggerButton))
        {
            close.SetActive(false);
            open.SetActive(true);
        }
        if (device.GetPressDown (triggerButton) && touch.pickup != null) {
            take = true;
            touch.pickup.transform.parent = cube.transform;
            touch.pickup.GetComponent<Rigidbody> ().useGravity = false;
            touch.pickup.GetComponent<Rigidbody>().isKinematic = true;
        }

		if (device.GetPressUp (triggerButton) && touch.pickup != null) {
            touch.pickup.GetComponent<Rigidbody>().useGravity = true;
            touch.pickup.GetComponent<Rigidbody>().isKinematic = false;
            touch.pickup.transform.parent = null;
            touch.pickup = null;
            take = false;
		}

   
	}
   

}