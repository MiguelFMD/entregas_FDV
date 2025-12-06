using UnityEngine;

public class MovimientoTranslate : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);
    public float speed = 1.0f; 

    void Update() 
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}