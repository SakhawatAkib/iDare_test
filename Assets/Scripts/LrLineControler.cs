using System;
using UnityEngine;

public class LrLineControler : MonoBehaviour
{

    private LineRenderer line;
    private GameObject[] points;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    public void SetUpLine(GameObject[] points)
    {
        line.positionCount = points.Length;
        this.points = points;
    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            line.SetPosition(i, points[i].transform.position);
        }
    }
}
