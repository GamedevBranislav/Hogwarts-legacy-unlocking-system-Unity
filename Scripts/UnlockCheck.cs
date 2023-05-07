using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCheck : MonoBehaviour
{
    public GameObject greenCrystal;
    public GameObject blueCrystal;
    public GameObject winningSound;
    public GameObject windowOn;

    public MovingGears mainGear;
    public MoveSmallGear smallGear;


    private void Update()
    {
        //if both crystal are active will open the lock
        if(greenCrystal.gameObject.activeSelf && blueCrystal.gameObject.activeSelf == true)
        {
            float moveSpeed = 5f;
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            windowOn.SetActive(true);
            mainGear.enabled = false;
            smallGear.enabled = false;
            winningSound.SetActive(true);
            
        }
    }
}
