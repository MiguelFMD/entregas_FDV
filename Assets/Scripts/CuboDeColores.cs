using UnityEngine;

public class CuboDeColores : MonoBehaviour
{
    public Color colorDelCubo = Color.white;
    public float tamanoDelCubo = 1f;

    void Start()
    {
        Renderer miRenderer = GetComponent<Renderer>();
        if (miRenderer != null)
        {
            miRenderer.material.color = colorDelCubo;
        }
        transform.localScale = Vector3.one * tamanoDelCubo;
    }
}