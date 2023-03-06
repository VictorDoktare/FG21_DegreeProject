using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraViewController : MonoBehaviour
{
    [SerializeField] private CameraAngle CameraType;
    private enum CameraAngle {TopDown, TopDownLowAngle, Sideview}

    void Update()
    {
        switch (CameraType)
        {
            case CameraAngle.TopDown:
                transform.position = new Vector3(-8, 20, -8);
                transform.rotation = Quaternion.Euler(60, 45, 0);
                break;
            case CameraAngle.TopDownLowAngle:
                transform.position = new Vector3(-8, 10, -8);
                transform.rotation = Quaternion.Euler(40, 45, 0);
                break;
            case CameraAngle.Sideview:
                transform.position = new Vector3(0, 6, -20);
                transform.rotation = Quaternion.Euler(10, 0, 0);
                break;
            default:
                break;
        }
    }
}
