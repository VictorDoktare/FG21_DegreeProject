using UnityEngine;

namespace Misc
{
    [ExecuteInEditMode]
    public class CameraAngleSetting : MonoBehaviour
    {
        [SerializeField] private GameObject _camera;
        [SerializeField] private CameraAngle _cameraType;
        private enum CameraAngle {TopDown, TopDownLowAngle, TopDownExperimental, Sideview}

        private Transform _cameraTransform;
        private Camera _cameraComponent;

        private void OnValidate()
        {
            SetCamera();
        }
        
        private void SetCamera()
        {
            if (_camera == null)
                return;
            
            _cameraTransform = _camera.GetComponent<Transform>();
            _cameraComponent = _camera.GetComponent<Camera>();
            
            switch (_cameraType)
           {
               case CameraAngle.TopDown:
                   SetCameraPos(new Vector3(-8f, 12f, -8.5f));
                   SetCameraRot(Quaternion.Euler(45f, 45f, 0f));
                   SetCameraFov(45f);
                   break;
               case CameraAngle.TopDownLowAngle:
                   SetCameraPos(new Vector3(-8f, 10f, -8f));
                   SetCameraRot(Quaternion.Euler(40f, 45f, 0f));
                   SetCameraFov(30f);
                   break;
               case CameraAngle.TopDownExperimental:
                   SetCameraPos(new Vector3(-21.5f, 25f, -10.5f));
                   SetCameraRot(Quaternion.Euler(45f, 65f, 0f));
                   SetCameraFov(20f);
                   break;
               case CameraAngle.Sideview:
                   SetCameraPos(new Vector3(-12f, 3.5f, 0f));
                   SetCameraRot(Quaternion.Euler(10f, 90f, 0f));
                   SetCameraFov(30f);
                   break;
           }
        }

        private void SetCameraPos(Vector3 value)
        {
            _cameraTransform.position = value;
        }

        private void SetCameraRot(Quaternion value)
        {
            _cameraTransform.rotation = value;
        }

        private void SetCameraFov(float value)
        {
            _cameraComponent.fieldOfView = value;
        }
    }
}
