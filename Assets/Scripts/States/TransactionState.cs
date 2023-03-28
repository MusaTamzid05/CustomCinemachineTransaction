using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace CameraSystem {
    public class TransactionState : CameraState {
        public TransactionState():base(Type.Transaction) {
        }

        public override void OnEnter(CameraController cameraController) {
            cameraController.LookAtTarget();
            Vector3 src = cameraController.transform.position;
            Vector3 dst = cameraController.camera2.transform.position;

            cameraController.mover = new CameraMover(src, dst);

        }

        public override void OnExecute(CameraController cameraController) {
            cameraController.LookAtTarget();
            if(cameraController.GoNextPosition())
                cameraController.stateMachine.ChangeState(new IdleState(), cameraController);

        }

        public override void OnExit(CameraController cameraController) {

        }
    }
}

