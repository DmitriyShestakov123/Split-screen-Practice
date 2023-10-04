using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            DataHandler._winner = other.gameObject.name[^1] - '0';
            SceneManager.LoadScene("MainMenu");
        }
    }
}
