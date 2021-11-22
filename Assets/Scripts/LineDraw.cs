using UnityEngine;

public class LineDraw : MonoBehaviour
{

    [SerializeField] private GameObject[] points;
    [SerializeField] private GameObject lineObject;
    
    [SerializeField] private LrLineControler line;
    
    
    public void DrowConnector()
    {
        lineObject.SetActive(true);
        points = new GameObject[WebRequest.boxCount];
        points = GameObject.FindGameObjectsWithTag("Player");
        line.SetUpLine(points);
    }

}
