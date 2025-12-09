using UnityEngine;
using UnityEngine.InputSystem;

public class ControladorMovimientoBasico : MonoBehaviour
{
    public float velocidad = 5f;

    private Vector2 direccionInput;

    void OnMove(InputValue valor)
    {
        direccionInput = valor.Get<Vector2>();
    }

    void Update()
    {
        Vector3 movimiento = new Vector3(direccionInput.x, 0, direccionInput.y);

        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}