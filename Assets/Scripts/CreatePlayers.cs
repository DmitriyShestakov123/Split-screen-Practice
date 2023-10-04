using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayers : MonoBehaviour
{   

    [SerializeField]
    private GameObject _player;

    private Camera cam1, cam2; //to be able to control cameras after setting up

    void Start()
    {
        if(DataHandler._numberOfPlayers >= 2) {
            GameObject Player1 = Instantiate(_player, new Vector3(27, 1, 27), Quaternion.identity);
            Player1.name = "Player1";
            GameObject Camera1 = Player1.transform.GetChild(0).gameObject;
            cam1 = Camera1.GetComponent<Camera>();
            cam1.rect = new Rect(0f, 0f, 0.5f ,1f); //if > 2 players, later will be corrected
            GameObject Player2 = Instantiate(_player, new Vector3(-27, 1, -27), Quaternion.identity);
            Player2.name = "Player2";
            GameObject Camera2 = Player2.transform.GetChild(0).gameObject;
            cam2 = Camera2.GetComponent<Camera>();
            cam2.rect = new Rect(0.5f, 0f, 0.5f ,1f);//same here
        }
        if(DataHandler._numberOfPlayers >= 3) {
            GameObject Player3 = Instantiate(_player, new Vector3(27, 1, -27), Quaternion.identity);
            Player3.name = "Player3";
            GameObject Camera3 = Player3.transform.GetChild(0).gameObject;
            Camera cam3 = Camera3.GetComponent<Camera>();
            cam3.rect = new Rect(0.5f, 0f, 0.5f ,0.5f);
            cam2.rect = new Rect(0.5f, 0.5f, 0.5f ,0.5f); //correction of camera
        }
        if(DataHandler._numberOfPlayers >= 4) {
            GameObject Player4 = Instantiate(_player, new Vector3(-27, 1, 27), Quaternion.identity);
            Player4.name = "Player4";
            GameObject Camera4 = Player4.transform.GetChild(0).gameObject;
            Camera cam4 = Camera4.GetComponent<Camera>();
            cam4.rect = new Rect(0f, 0f, 0.5f ,0.5f);
            cam1.rect = new Rect(0f, 0.5f, 0.5f ,0.5f); //correction of camera
        }
    }
}
