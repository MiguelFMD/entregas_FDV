using UnityEngine;
using UnityEngine.InputSystem; 

public class ColorInesperado : MonoBehaviour
{
    private Renderer rend;

    public Color colorEsperado;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rend.material.color = colorEsperado;

            Debug.Log("El color aplicado es: " + colorEsperado);
        }
    }
}