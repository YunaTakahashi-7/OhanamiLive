using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testkeyM : MonoBehaviour
{
    private bool canclick = true;
   
    void OnEnable()
    {
        canclick = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M) && canclick)
        {
            testscore.testnum++;
            Debug.Log(testscore.testnum);
            // gameObject.SetActive(false);
            canclick = false;
        }
    }
}
