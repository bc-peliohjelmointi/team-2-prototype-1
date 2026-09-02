using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        Scoretext.text = KeyManager.Instance.keysCollected + " / " + KeyManager.Instance.keysNeeded;
    }
}