using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //[SerializeField] Transform playerTransform;
    [SerializeField] Collider player;
    [SerializeField] Transform[] checks;
    static public int currentCheck = 0;
    void Start()
    {
        //currentCheck = 0;
    }
    private void Update()
    {
        if (currentCheck == 1)
        {
            transform.position = new Vector3(transform.position.x, 116.5f - 9.4f + 133.5f, transform.position.z); // 125.9
        }
        else if (currentCheck == 2)
        {
            transform.position = new Vector3(transform.position.x, 136.8f - 9.4f + 133.5f, transform.position.z);            
        }
        else if (currentCheck == 5)
        {
            transform.position = new Vector3(transform.position.x, 37f - 9.4f + 133.5f, transform.position.z);
        }
        else if (currentCheck == 6)
        {
            transform.position = new Vector3(transform.position.x, 80.6f - 9.4f + 133.5f, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            if (currentCheck == 0) Debug.LogError("ERROR! TRYING TO RESPAWN WITHOUT CHECKPOINT");
            else player.transform.position = checks[currentCheck - 1].position;
        }

    }
}
