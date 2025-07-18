using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField] bool thisWin = false;
    private void OnTriggerEnter(Collider other)
    {
        if (thisWin) SceneManager.LoadScene("winScene");
        else SceneManager.LoadScene("Swinging");
    }
}
