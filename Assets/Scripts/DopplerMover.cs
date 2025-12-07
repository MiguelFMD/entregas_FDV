using UnityEngine;
using UnityEngine.InputSystem;

public class DopplerMover : MonoBehaviour
{
    public float velocidad = 20f;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.mKey.isPressed)
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }
}