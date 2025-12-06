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

        float realSpeed = speed;

        if (Keyboard.current != null && Keyboard.current.spaceKey.isPressed)
        {
            realSpeed *= 2.0f;
        }

        if (direction.magnitude > 0.1f)
        {
            this.transform.Translate(direction.normalized * realSpeed * Time.deltaTime, Space.World);
        }
    }
}