using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGears : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField]
    private float zAxisNumber;

    [SerializeField]
    private GameObject greenCrystal;
    [SerializeField]
    private GameObject gearCrystal;
    // Update is called once per frame
    private float closePosition = 1f;

    bool onthePosition = false;

    private void Start()
    {
        RandomzAxis();
    }
    void Update()
    {
        
        // Rotate the object in the Z-axis when A or D is held down
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, moveSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -moveSpeed * Time.deltaTime, Space.Self);
        }
        {
            CheckPosition();
               /* if (Mathf.Abs(transform.eulerAngles.z - zAxisNumber) <= closePosition)
                {
                    Debug.Log("WIN");
                }*/

        }
    }
    public void CheckPosition()
    {
        float zAxis = transform.eulerAngles.z;
        if (zAxisNumber < 0f)
        {
            zAxis = (zAxis > 180f) ? zAxis - 360f : zAxis;
            zAxisNumber = (zAxisNumber > -180f) ? zAxisNumber + 360f : zAxisNumber;
        }
        if (Mathf.Abs(zAxis - zAxisNumber) <= closePosition && !onthePosition)
        {
            Debug.Log("Crystal is Active");
            greenCrystal.SetActive(true);
            onthePosition = true;
            
        }
        if (onthePosition && Mathf.Abs(zAxis - zAxisNumber) > closePosition)
        {
            greenCrystal.SetActive(false);
            onthePosition = false;
        }
    }

    public void RandomzAxis()
    {
        //create a random number between 0 - 360
        float randomNumber = Random.Range(0, 360);
        zAxisNumber = randomNumber;

    }
}
