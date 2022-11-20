using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField]
    private bool _allowYrotation = true;

    [SerializeField]
    private bool _allowXrotation = true;

    [SerializeField]
    private bool _allowMovement = false;
    
    private Vector3 _mousePosition = Vector3.zero;
    
    private void OnMouseDrag()
    {
        var currentMousePosition = Input.mousePosition;
        if (_allowYrotation && !Input.GetMouseButton(1))
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

        if (_allowXrotation && Input.GetMouseButton(1))
        {
            if (_mousePosition.y < currentMousePosition.y)
            {
                transform.RotateAround(transform.position, Vector3.right, -Settings.RotationStep);
            }
            else if (_mousePosition.y > currentMousePosition.y)
            {
                transform.RotateAround(transform.position, Vector3.right, Settings.RotationStep);
            }
        }

        _mousePosition = currentMousePosition;
    }
}