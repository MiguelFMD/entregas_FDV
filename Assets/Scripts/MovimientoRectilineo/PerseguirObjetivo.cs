using UnityEngine;

public class PerseguirObjetivo : MonoBehaviour
{
    public Transform goal; 
    public float speed = 1.0f;

    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;

        Debug.DrawRay(this.transform.position, direction, Color.red);

        this.transform.LookAt(goal.position);

        if (direction.magnitude > 0.1f) 
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}