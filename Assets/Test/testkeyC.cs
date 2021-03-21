using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testkeyC : MonoBehaviour
{
    private bool canclick = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && canclick)
        {
            testscore.testnum++;
            Debug.Log(testscore.testnum);
            canclick = false;
        }
    }
}
