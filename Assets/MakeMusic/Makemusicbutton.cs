using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makemusicbutton : MonoBehaviour
{
    public float time = 0;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
    }

    public void makemcBn()
    {
        Debug.Log(time);
    }
}
