using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testscore : MonoBehaviour
{
    public static int testnum;
    private Text targetText;

    // Start is called before the first frame update
    void Start()
    {
        testnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.targetText = this.GetComponent<Text>(); 
        this.targetText.text = testnum.ToString();;
    }
}
