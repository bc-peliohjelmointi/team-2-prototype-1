using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    private bool doorOpened = false;

    private void OnMouseDown()
    {
        if (doorOpened)
            return;

        if (KeyManager.Instance.HasAllKeys())
        {
            OpenDoor();
        }
        else
        {
            Debug.Log("You need all 3 keys!");
        }
    }

    private void OpenDoor()
    {
        doorOpened = true;

        Debug.Log("All keys collected! You win!");

        // Remove the door
        Destroy(gameObject);

        // Put your win code here
    }
}