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

        }
    }
}

