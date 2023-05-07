using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGear : MonoBehaviour
{
    public GameObject myCrystal;

    // Update is called once per frame
    void Update()
    {
        if(myCrystal.gameObject.activeSelf == true)
        {
            //start rotating when crystal activated
            float rotationSpeed = 20f;
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}
