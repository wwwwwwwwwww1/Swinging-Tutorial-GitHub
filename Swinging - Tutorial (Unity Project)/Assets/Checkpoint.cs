using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] Collider player;
    [SerializeField] int thisCheck = 0;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            Respawn.currentCheck = thisCheck;
            Debug.Log("ACTIVATED CHECKPOINT");
        }
    }
}
