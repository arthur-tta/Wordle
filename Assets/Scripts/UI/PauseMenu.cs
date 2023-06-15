using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private Board board;

    public void ContinueButton()
    {
        board.SetIsPlaying(true);
        gameObject.SetActive(false);
    }

    public void ExitButton() 
    {
        board.ExitGame();
        gameObject.SetActive(false);
    }

}
