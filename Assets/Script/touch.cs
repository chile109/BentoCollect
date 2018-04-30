using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public static GameObject pickup;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(1);
        if (WandController.take)
        {
            Debug.Log(2);
            if (collision.tag == "Get" && WandController.take)
            {
                Debug.Log(3);
                pickup = collision.gameObject;
                pickup.transform.parent = WandController._inst.cube.transform;
                pickup.GetComponent<Rigidbody>().useGravity = false;
                pickup.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
