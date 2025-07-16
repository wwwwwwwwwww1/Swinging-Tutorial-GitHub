using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTree : MonoBehaviour
{
    [SerializeField] Collider player;

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            SceneManager.LoadScene("InsideTree");
        }

    }
}
