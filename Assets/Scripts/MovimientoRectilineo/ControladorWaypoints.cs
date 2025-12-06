using UnityEngine;

public class ControladorWaypoints : MonoBehaviour
{
    public Transform[] waypoints;

    public float speed = 5.0f;
    public float rotSpeed = 2.0f;
    public float accuracy = 1.0f;

    
    private int currentTargetIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform currentGoal = waypoints[currentTargetIndex];

        Vector3 direction = currentGoal.position - this.transform.position;

        if (direction.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction.normalized);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, rotSpeed * Time.deltaTime);

            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (direction.magnitude < accuracy)
        {
            currentTargetIndex++;

            if (currentTargetIndex >= waypoints.Length)
            {
                currentTargetIndex = 0;
            }
        }
    }
}