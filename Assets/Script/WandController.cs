using UnityEngine;
using Valve.VR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class WandController : MonoBehaviour
{
    public static WandController _inst;
    public SteamVR_TrackedObject trackedObj2;
    private SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    SteamVR_Controller.Device device2;
    public GameObject open, close, cube;
    public static bool take = false;

    void Start()
    {
        _inst = this;
        close.SetActive(false);
    }

    void Update()
    {
        var device = SteamVR_Controller.Input((int)trackedObj2.index);

        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("fawfa");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

        var deviceIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost);

        device = SteamVR_Controller.Input(deviceIndex);


        var triggerButton = SteamVR_Controller.ButtonMask.Trigger;


        if (device.GetTouchDown(triggerButton) && open.activeInHierarchy)
        {
            open.SetActive(false);
            close.SetActive(true);
        }
        else if (device.GetTouchUp(triggerButton) && close.activeInHierarchy)
        {
            Debug.Log("up");
            close.SetActive(false);
            open.SetActive(true);
        }

        if (device.GetTouchDown(triggerButton) && touch.pickup == null)
        {
            Debug.Log("pick");
            take = true;
        }

        else if (device.GetTouchUp(triggerButton) && touch.pickup != null)
        {

            touch.pickup.GetComponent<Rigidbody>().useGravity = true;
            touch.pickup.GetComponent<Rigidbody>().isKinematic = false;
            touch.pickup.transform.parent = null;
            touch.pickup = null;
            take = false;
        }

        else if (device.GetPressUp(triggerButton))
            take = false;

        
    }


}