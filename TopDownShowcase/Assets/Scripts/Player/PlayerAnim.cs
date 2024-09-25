using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");
            GetComponent<Animator>().SetFloat("x", xInput);
            GetComponent<Animator>().SetFloat("y", yInput);
        }   
        }
    }
