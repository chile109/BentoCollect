using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public static GameObject pickup;
    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (WandController.take == false)
            if (collision.gameObject.name == "pCylinder11" || collision.gameObject.name == "polySurface31" || collision.gameObject.name == "polySurface32" || collision.gameObject.name == "polySurface33" || collision.gameObject.name == "polySurface34" || collision.gameObject.name == "polySurface35" || collision.gameObject.name == "polySurface36" || collision.gameObject.name == "polySurface37" || collision.gameObject.name == "polySurface38" || collision.gameObject.name == "polySurface39" || collision.gameObject.name == "pCube3" || collision.gameObject.name == "pPlane2")
            {
                pickup = collision.gameObject;
            }
    }
    // Update is called once per frame
    void Update()
    {


    }
}
