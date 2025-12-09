using UnityEngine;
using UnityEngine.InputSystem;

public class CarruselSize : MonoBehaviour
{
    public GameObject[] cubos;
    public Vector3[] sizes;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            CambiarSizes();
        }
    }

    void CambiarSizes()
    {
        for (int i = 0; i < cubos.Length; i++)
        {
            if (cubos[i] != null)
            {
                Transform size = cubos[i].GetComponent<Transform>();
                Vector3 sizeParaEsteCubo = sizes[i % sizes.Length];

                size.localScale = sizeParaEsteCubo;
            }
        }
        Debug.Log("¡Tamaños cambiados!");
    }
}