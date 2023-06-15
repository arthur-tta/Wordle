using UnityEngine.UI;
using UnityEngine;

public class NextLevelMenu : MonoBehaviour
{
    [SerializeField]
    private Board board;

    public void NewWordButton()
    {
        board.Initialized();
        board.SetRandomWord();
        gameObject.SetActive(false);
    }
}
