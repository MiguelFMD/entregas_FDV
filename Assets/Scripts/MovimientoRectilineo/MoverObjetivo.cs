using UnityEngine;
using UnityEngine.InputSystem;

public class MoverObjetivo : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        if (Keyboard.current == null) return;

        Vector3 move = Vector3.zero;

        if (Keyboard.current.upArrowKey.isPressed) move.z += 1;
        if (Keyboard.current.downArrowKey.isPressed) move.z -= 1;
        if (Keyboard.current.rightArrowKey.isPressed) move.x += 1;
        if (Keyboard.current.leftArrowKey.isPressed) move.x -= 1;

        
        transform.Translate(move.normalized * speed * Time.deltaTime);
    }
}