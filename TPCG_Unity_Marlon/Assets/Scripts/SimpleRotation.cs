using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public float Degrees = 10f;

    // Update is called once per frame
    void Update(){
        transform.Rotate(0f, Degrees * Time.deltaTime, 0f);
        //transform.Translate(2f * Time.deltaTime,0f, 0f);
    }
}
