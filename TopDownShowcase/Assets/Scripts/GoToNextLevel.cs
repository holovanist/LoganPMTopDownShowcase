using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "Level 2";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            if (GameObject.FindWithTag("Boss") == null)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
