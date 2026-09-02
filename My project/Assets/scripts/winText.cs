using UnityEngine;

public class WinText : MonoBehaviour
{
    public GameObject winText;

    public void ShowWin()
    {
        winText.SetActive(true);
    }
}