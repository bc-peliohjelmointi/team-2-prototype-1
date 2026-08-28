using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main; //kamera muuttuja on scenen kamera
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        //jos pelaaja ei clickannut, ‰l‰ tee t‰t‰ funktiota aka return.
        if (!context.started) return;

        //saadaan hiiren paikka, kun painoi left mouse.
        //var tunnistaa mit‰ tietotyyppi‰ k‰ytet‰‰n.
        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay
            (Mouse.current.position.ReadValue()));

        //katsotaan, ett‰ hiiri osui johonkin objektiin, jossa on collider.
        if (!rayHit.collider) return;

        //Debug.Log(rayHit.collider.gameObject.name);

        //katsotaan, jos hiiri on osunut avaimeen
        if (rayHit.collider.CompareTag("Key")) 
        {
            //avain menee "inventoriin"
            KeyManager.Instance.CollectKey();
            //ja tuhotaan
            Destroy(rayHit.collider.gameObject);
        }
    }
}
