using UnityEngine;
using Valve.VR;
using System.Collections;
using System.Collections.Generic;

public class WandController : MonoBehaviour
{
    public static WandController _inst;
    private SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device; 
    public GameObject open, close,cube;
    public static bool take=false;
    
    void Start ()
	{
        _inst = this;
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
        if (device.GetPressDown (triggerButton) && touch.pickup == null) {
            Debug.Log("zxc");
            take = true;
        }

		if (device.GetPressUp (triggerButton) && touch.pickup != null) {
            Debug.Log("asd");
            touch.pickup.GetComponent<Rigidbody>().useGravity = true;
            touch.pickup.GetComponent<Rigidbody>().isKinematic = false;
            touch.pickup.transform.parent = null;
            touch.pickup = null;
            take = false;
		}

   
	}
   

}