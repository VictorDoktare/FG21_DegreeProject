using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraViewController : MonoBehaviour
{
    [SerializeField] private CameraAngle CameraType;
    private enum CameraAngle {TopDown, TopDownLowAngle, TopDownExperimental, Sideview}

    void Update()
    {
        switch (CameraType)
        {
            case CameraAngle.TopDown:
                transform.position = new Vector3(-8f, 12f, -8.5f);
                transform.rotation = Quaternion.Euler(45f, 45f, 0f);
                GetComponent<Camera>().fieldOfView = 45f;
                break;
            case CameraAngle.TopDownLowAngle:
                transform.position = new Vector3(-8f, 10f, -8f);
                transform.rotation = Quaternion.Euler(40f, 45f, 0f);
                GetComponent<Camera>().fieldOfView = 30f;
                break;
            case CameraAngle.TopDownExperimental:
                transform.position = new Vector3(-25f, 30f, -12f);
                transform.rotation = Quaternion.Euler(45f, 65f, 0f);
                GetComponent<Camera>().fieldOfView = 20f;
                break;
            case CameraAngle.Sideview:
                transform.position = new Vector3(0f, 6f, -20f);
                transform.rotation = Quaternion.Euler(10f, 0f, 0f);
                GetComponent<Camera>().fieldOfView = 30f;
                break;
            default:
                break;
        }
    }
}
