using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    private Board board;

    public GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }


    public void PauseButton()
    {
        board.SetIsPlaying(false);
        pauseMenu.SetActive(true);
    }

   
}
