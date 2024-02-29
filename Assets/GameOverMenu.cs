using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    //public GameObject options;

    [Header("Main Menu Buttons")]
    public Button restartButton;
    //public Button optionButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        restartButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(QuitGame);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
    }

}
