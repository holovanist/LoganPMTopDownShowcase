using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    string levelToLoad = "Level 2";
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        if (GameObject.FindWithTag("Enemy") == null) //&& timer > 1f)
        {
            GameObject Boss = Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //Boss.transform.position = transform.position;
            //if (GameObject.FindWithTag("Boss") == null && timer > 1f)
            //{
               // SceneManager.LoadScene(levelToLoad);
           // }
        }
    }
}
