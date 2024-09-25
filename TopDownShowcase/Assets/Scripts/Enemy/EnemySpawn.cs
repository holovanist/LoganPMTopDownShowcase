using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
   // float timer;
    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        if (GameObject.FindWithTag("Enemy") == null) //&& timer > 1f)
        {
            GameObject Boss = Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
