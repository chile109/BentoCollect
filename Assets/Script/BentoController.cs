using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BentoController : MonoBehaviour {

    public GameObject[] _pool;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.name);
        foreach(var obj in _pool)
        {
            if(obj.name == collision.name)
            {
                Destroy(collision.gameObject);
                obj.SetActive(true);
                break;
            }
        }
    }
}
