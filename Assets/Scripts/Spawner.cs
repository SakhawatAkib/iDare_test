using UnityEngine;

public class Spawner: MonoBehaviour
{
    public GameObject box;
    public float radius = 4f;

    public void spown()
    {
        Instantiate(box, Vector3.zero, Quaternion.identity);

        for (int i = 1; i < WebRequest.boxCount; i++)
        {
            float angle = i * Mathf.PI*2f / (WebRequest.boxCount-1);
            Vector3 newPos = new Vector3(Mathf.Cos(angle)*radius, 0.5f, Mathf.Sin(angle)*radius);
            Instantiate(box, newPos, Quaternion.identity);
        }
        
    }
    
}
