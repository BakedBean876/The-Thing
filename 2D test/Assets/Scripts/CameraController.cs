using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.U2D;

public class CameraController : MonoBehaviour
{
    public GameObject follow;
    private float zoom;
    private int zoomFactor = 4;

    [SerializeField] private PixelPerfectCamera PPC;

    void Update()
    {
        transform.position = new Vector3(follow.transform.position.x,
                                        follow.transform.position.y, -10);

        zoom = Input.GetAxisRaw("Mouse ScrollWheel");


        if(zoom < 0)
        {
            PPC.assetsPPU -= zoomFactor;
        }
        else if (zoom > 0) 
        {
            PPC.assetsPPU += zoomFactor;
        }

        if( PPC.assetsPPU < 4 ) 
        {
            PPC.assetsPPU = 4;
        }
    }
}
