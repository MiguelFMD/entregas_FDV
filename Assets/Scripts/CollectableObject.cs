using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    [SerializeField] int points = 10;
    Animator animator;
    bool collected = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) { return; } //evita que se active otra vez en caso de que aun no se haya destruido
        if (other.CompareTag("Player"))
        {
            collected = true;
            // Logic for when the player collects the object
            Debug.Log("Collectable object collected!");
            animator.SetBool("Collected", true);
            Destroy(gameObject, 1.0f);
        }
    }
}
