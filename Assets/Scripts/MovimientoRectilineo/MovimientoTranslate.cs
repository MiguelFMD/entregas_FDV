using UnityEngine;

public class MovimientoTranslate : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 5);

    void Start()
    {
        this.transform.Translate(goal);
    }
}