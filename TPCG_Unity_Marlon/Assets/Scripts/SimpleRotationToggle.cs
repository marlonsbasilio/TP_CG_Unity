using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotationToggle : MonoBehaviour
{
    public float Degrees = 5f;
    public bool mRotationState = true;

    // Update is called once per frame
    void Update(){
        if(mRotationState)
        transform.Rotate(0f, 0f, Degrees * Time.deltaTime);
        //transform.Translate(2f * Time.deltaTime,0f, 0f);
    }

    void OnMouseDown ()
    {
        mRotationState = !mRotationState;
        print("State = " + mRotationState);
    }
}
