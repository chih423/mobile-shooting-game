using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
