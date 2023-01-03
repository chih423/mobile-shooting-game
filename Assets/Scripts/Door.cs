using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && GameVariables.keyCount>0)
        {
            GameVariables.keyCount --;
            Destroy (gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
