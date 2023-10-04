using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField]
    private Material[] materials;

    [SerializeField]
    private float playerSpeed;
    private CharacterController controller;
    private Renderer rend;

    void Start()
    {   
        string playerName = gameObject.name;
        //Debug.Log(playerName + "\n");
        int playerNumber = (int)Char.GetNumericValue(playerName[^1]);
        //Debug.Log(playerName[^1] + "\n");
        controller = gameObject.GetComponent<CharacterController>();
        gameObject.GetComponent<Renderer>().sharedMaterial = materials[playerNumber - 1];
    }

    void Update()
    {
        if(gameObject.name.Equals("Player1")) {
            controller.Move(new Vector3(Input.GetAxis("HorizontalWASD"), 0, Input.GetAxis("VerticalWASD")) * playerSpeed * Time.deltaTime);
        }
        if(gameObject.name.Equals("Player2")) {
            controller.Move(new Vector3(Input.GetAxis("HorizontalArrows"), 0, Input.GetAxis("VerticalArrows")) * playerSpeed * Time.deltaTime);
        }
        if(gameObject.name.Equals("Player3")) {
            controller.Move(new Vector3(Input.GetAxis("HorizontalNumPad"), 0, Input.GetAxis("VerticalNumPad")) * playerSpeed * Time.deltaTime);
        }
        if(gameObject.name.Equals("Player4")) {
            controller.Move(new Vector3(Input.GetAxis("HorizontalIJKL"), 0, Input.GetAxis("VerticalIJKL")) * playerSpeed * Time.deltaTime);
        }
    }
}
