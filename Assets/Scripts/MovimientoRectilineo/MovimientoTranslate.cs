using UnityEngine;

public class MovimientoTranslate : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 5);

    void Start()
    {
        goal = goal * 0.5f;
    }

    private void Update()
    {
        this.transform.Translate(goal);
        
    }
}