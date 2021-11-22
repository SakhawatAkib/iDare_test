using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class MoveIn_XZ_Axis : MonoBehaviour
{
    private Camera mainCamera;
    private float CameraZDistance;

    void Start()
    {
        mainCamera = Camera.main;
        CameraZDistance =
            mainCamera.WorldToScreenPoint(transform.position).z; //z axis of the game object for screen view
    }

    void OnMouseDrag()
    {
        Vector3 ScreenPosition =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance); //z axis added to screen point 
        Vector3 NewWorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition); //Screen point converted to world point

        transform.position = NewWorldPosition;
    }

    private void Update()
    {
        if (gameObject.transform.position.y > 0.5f || gameObject.transform.position.y < 0.5f)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }
}