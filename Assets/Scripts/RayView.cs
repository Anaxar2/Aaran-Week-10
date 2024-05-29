using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayView : MonoBehaviour
{
    public float range = 50f;
    private Camera fpsCamera;
        
    // Start is called before the first frame update
    void Start()
    {
        fpsCamera = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrigin, fpsCamera.transform.forward * range, Color.red);
    }
}
