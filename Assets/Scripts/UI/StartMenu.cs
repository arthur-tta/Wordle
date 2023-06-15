using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private Board board;

    public void StartGame()
    {
        board.Initialized();
        board.SetRandomWord();
        gameObject.SetActive(false);
    }
}
