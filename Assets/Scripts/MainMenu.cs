using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    [SerializeField]
    private GameObject _winnerPanel;
    [SerializeField]
    private GameObject _mainMenu;

    void Start()
    {
        _winnerPanel.SetActive(false);
        _mainMenu.SetActive(true);
    }

    private void LoadGame() {
        SceneManager.LoadScene("Game");
        //SceneManager.UnloadScene("MainMenu");
    }
    // Update is called once per frame
    public void TwoPlayers() {
        DataHandler._numberOfPlayers = 2;
        SceneManager.LoadScene("Game");
    }
    public void ThreePlayers() {
        DataHandler._numberOfPlayers = 3;
        SceneManager.LoadScene("Game");
    }
    public void FourPlayers() {
        DataHandler._numberOfPlayers = 4;
        SceneManager.LoadScene("Game");
    }
}
