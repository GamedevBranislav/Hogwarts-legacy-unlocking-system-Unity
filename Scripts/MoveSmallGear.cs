using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSmallGear : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField]
    private float zAxisNumber;

    [SerializeField]
    private GameObject blueCrystal;
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
       
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, moveSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -moveSpeed * Time.deltaTime, Space.Self);
        }
        CheckPosition();
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
            blueCrystal.SetActive(true);
            onthePosition = true;

        }
        if (onthePosition && Mathf.Abs(zAxis - zAxisNumber) > closePosition)
        {
            blueCrystal.SetActive(false);
            onthePosition = false;
        }
    }

    public void RandomzAxis()
    {
        float randomNumber = Random.Range(0, 360);
        zAxisNumber = randomNumber;

    }
}
