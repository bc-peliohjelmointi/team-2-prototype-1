using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnMouseDown()
    {
        KeyManager.Instance.CollectKey();

        // Remove the key from the scene
        Destroy(gameObject);
    }
}