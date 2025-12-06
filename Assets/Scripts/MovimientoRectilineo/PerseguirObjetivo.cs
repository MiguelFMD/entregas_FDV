using UnityEngine;
using UnityEngine.InputSystem;

public class PerseguirObjetivo : MonoBehaviour
{
    public Transform goal;
    public float speed = 2.0f;
    public float accuracy = 0.01f;
    public float rotSpeed = 5.0f;

    void Update()
    {
        if (goal == null) return;

        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        

        if (direction.magnitude > 0.01)
        {

            Quaternion targetRotation = Quaternion.LookRotation(direction.normalized);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, Time.deltaTime * rotSpeed);

            
        }

        if (direction.magnitude > accuracy)
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}