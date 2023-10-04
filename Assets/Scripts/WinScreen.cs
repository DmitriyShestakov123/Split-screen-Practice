using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{   
    [SerializeField]
    private GameObject _mainMenu;
    [SerializeField]
    private GameObject _winScreen;
    [SerializeField]
    private TMPro.TMP_Text _winnerText;
    // Start is called before the first frame update
    void Start()
    {
        if(DataHandler._winner > 0) {
            _winnerText.text = "Побеждает игрок №" + DataHandler._winner.ToString();
            _mainMenu.SetActive(false);
            _winScreen.SetActive(true);
        } else {
            _mainMenu.SetActive(true);
            _winScreen.SetActive(false);
        }
    }
    public void BackToMenu() {
        _mainMenu.SetActive(true);
        _winScreen.SetActive(false);
    }
}
