using UnityEngine;


namespace CameraSystem {
    public class SecondCameraState : CameraState {
        public SecondCameraState():base(Type.Second) {
        }

        public override void OnEnter(CameraController cameraController) {

        }

        public override void OnExecute(CameraController cameraController) {
            Debug.Log("Second stat");

        }

        public override void OnExit(CameraController cameraController) {

            Vector3 src = cameraController.camera2.transform.position;
            Vector3 dst = cameraController.camera1.transform.position;

            cameraController.mover = new CameraMover(src, dst, 0.5f);

        }
    }
}

