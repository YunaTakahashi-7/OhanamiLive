using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testbutton : MonoBehaviour
{
    Button buttonA;
    // Start is called before the first frame update
    void Start()
    {
        buttonA = gameObject.GetComponent<Button> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buttontest()
    {
        testscore.testnum++;
        Debug.Log(testscore.testnum);
        buttonA.enabled = false;
    }
}
