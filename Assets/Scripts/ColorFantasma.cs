using UnityEngine;

public class ColorFantasma : MonoBehaviour
{
    private Renderer rend;

    public Color colorFinal = Color.red;

    void Start()
    {
    }

    void Update()
    {
        if (UnityEngine.InputSystem.Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rend.material.color = colorFinal;
        }
    }
}