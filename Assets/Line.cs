using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public List<Vector3> positions;
    private LineRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<LineRenderer>();
        rend.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RecordPosition();
    }

    void RecordPosition()
    {
        positions.Add(transform.position);
    }
}
