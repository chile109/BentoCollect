using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BentoController : MonoBehaviour {

    public GameObject[] _pool;
    private int Count = 0;

    private void Start()
    {
        Count = 0;
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.name);
        foreach(var obj in _pool)
        {
            if(obj.name == collision.name && !WandController.take)
            {              
                Destroy(collision.gameObject);
                obj.SetActive(true);
                Count += 1;
                break;
            }
        }

        if(Count == 10)
        {
            StartCoroutine(ReloadLevel());
        } 
    }

    IEnumerator ReloadLevel()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
