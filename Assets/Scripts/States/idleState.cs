using UnityEngine;

namespace CameraSystem {
    public class IdleState : CameraState {
        public IdleState():base(Type.Idle) {
        }

        public override void OnEnter(CameraController cameraController) {
            cameraController.LookAtTarget();

        }

        public override void OnExecute(CameraController cameraController) {

        }

        public override void OnExit(CameraController cameraController) {
            Vector3 src = cameraController.camera1.transform.position;
            Vector3 dst = cameraController.camera2.transform.position;

            cameraController.mover = new CameraMover(src, dst, 0.5f);

        }
    }
}

