using UnityEngine;
using UnityEngine.InputSystem;

public class CarruselManagerColor : MonoBehaviour
{
    public GameObject[] cubos;
    public Color[] colores;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            CambiarColores();
        }
    }

    void CambiarColores()
    {
        for (int i = 0; i < cubos.Length; i++)
        {
            if (cubos[i] != null)
            {
                Renderer rend = cubos[i].GetComponent<Renderer>();
                Color colorParaEsteCubo = colores[i % colores.Length];

                rend.material.color = colorParaEsteCubo;
            }
        }
        Debug.Log("¡Colores cambiados!");
    }
}