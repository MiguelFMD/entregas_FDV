using UnityEngine;
using UnityEngine.InputSystem;

public class SoundController : MonoBehaviour
{
    private AudioSource mySource;
    public float speed = 5f;
    private bool isMoving = false;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            isMoving = true;
            if (!mySource.isPlaying) mySource.Play();
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            isMoving = false;
            mySource.Stop();
        }

        if (isMoving)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}