using UnityEngine;
using UnityEngine.InputSystem;

public class PerseguirObjetivo : MonoBehaviour
{
    public Transform goal;
    public float speed = 2.0f;
    public float accuracy = 0.01f;

    void Update()
    {
        if (goal == null) return;

        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        
        this.transform.LookAt(goal.position);

        if (direction.magnitude > accuracy)
        {
            // Global
            // this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
            
            // Local
            
             this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            
        }
    }
}