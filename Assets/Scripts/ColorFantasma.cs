using UnityEngine;

public class ColorFantasma : MonoBehaviour
{
    private Renderer rend;

    public Material materialFinal;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (UnityEngine.InputSystem.Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rend.material = materialFinal;
        }
    }
}