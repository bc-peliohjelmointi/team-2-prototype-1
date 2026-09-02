using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public static KeyManager Instance;

    public int keysCollected = 0;
    public int keysNeeded = 3;
    public Score scoreUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

   

    public void CollectKey()
    {
        keysCollected++;
        Debug.Log("NYT" + keysCollected);
        scoreUI.UpdateScore();
        Debug.Log("Keys collected: " + keysCollected + "/" + keysNeeded);
    }

    public bool HasAllKeys()
    {
        return keysCollected >= keysNeeded;
    }
}