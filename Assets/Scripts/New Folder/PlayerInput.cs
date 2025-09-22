using UnityEngine;
using System;


public class PlayerInput : MonoBehaviour
{

    public event Action<Vector3> OnMouseClick;

    RaycastHit hitinfo = new();
    public LayerMask clickLayerMask;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hitinfo, 100, clickLayerMask))
            {
                OnMouseClick?.Invoke(hitinfo.point);
                Debug.Log ($"Selected position is {hitinfo.point}");
            }
        }
    }
}
