using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] Collider player;
    [SerializeField] int thisCheck = 0;
    [SerializeField] GameObject thisGreen, thisRed;
    void Start()
    {
        if (thisGreen != null && thisRed != null)
        {
            thisGreen.SetActive(false);
            thisRed.SetActive(true);
        }        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            if (thisGreen != null && thisRed != null)
            {
                thisGreen.SetActive(true);
                thisRed.SetActive(false);
            }
            Respawn.currentCheck = thisCheck;
            Debug.Log("ACTIVATED CHECKPOINT");
        }
    }
}
