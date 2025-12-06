using UnityEngine;
using UnityEngine.InputSystem;

public class PerseguirObjetivo : MonoBehaviour
{
    public Transform goal;
    public float speed = 2.0f;

    void Update()
    {
        if (goal == null) return;

        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        
        this.transform.LookAt(goal.position);

        if (direction.magnitude > 0.1f)
        {
            // Global
            // this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
            
            // Local
            
             this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            
        }
    }
}