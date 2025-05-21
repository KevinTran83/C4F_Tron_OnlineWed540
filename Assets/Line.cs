using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; /// new

public class Line : MonoBehaviour
{
    public UnityEvent onLose; /// new

    public List<Vector3> positions;
    private LineRenderer rend;
    public float interval = 0.2f;
    public int length = 50;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<LineRenderer>();
        rend.positionCount = 0;
        Invoke("RecordPosition", 0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerCheck();
    }

    void RecordPosition()
    {
        positions.Add(transform.position);

        if (positions.Count > length) positions.RemoveAt(0);

        rend.positionCount = positions.Count;
        rend.SetPositions(positions.ToArray());

        Invoke("RecordPosition", interval);
    }

    void PlayerCheck()
    {
        for (int i = 0; i < positions.Count - 1 - 4; i++)
        {
            Vector3 vect = positions[i + 1] - positions[i];

            RaycastHit hit;
            if (Physics.Raycast(positions[i], vect, out hit, vect.magnitude))
                onLose.Invoke(); /// New
        }
    }
}
