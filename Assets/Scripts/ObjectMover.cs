using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField]
    private bool _allowYrotation = true;

    [SerializeField]
    private bool _allowXrotation = true;
    
    private Vector3 _mousePosition = Vector3.zero;
    
    private void OnMouseDrag()
    {
        var currentMousePosition = Input.mousePosition;
        if (_allowYrotation)
        {
            if (_mousePosition.x < currentMousePosition.x)
            {
                transform.RotateAround(transform.position, Vector3.up, -Settings.RotationStep);
            }
            else if (_mousePosition.x > currentMousePosition.x)
            {
                transform.RotateAround(transform.position, Vector3.up, Settings.RotationStep);
            }
        }

        if (_allowXrotation)
        {
            if (_mousePosition.y < currentMousePosition.y)
            {
                transform.RotateAround(transform.position, Vector3.forward, -Settings.RotationStep);
            }
            else if (_mousePosition.y > currentMousePosition.y)
            {
                transform.RotateAround(transform.position, Vector3.forward, Settings.RotationStep);
            }
        }

        _mousePosition = currentMousePosition;
    }
}