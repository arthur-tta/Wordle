using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField]
    private Board board;


    public void NewWord()
    {
        board.Initialized();
        board.SetRandomWord();
        gameObject.SetActive(false);
    }

    public void TryAgain()
    {
        board.Initialized();
        gameObject.SetActive(false);
    }
}
