using UnityEngine;



namespace CameraSystem {
    public class TransactionState : CameraState {
        public TransactionState():base(Type.Transaction) {
        }

        public override void OnEnter(CameraController cameraController) {
            cameraController.LookAtTarget();

        }

        public override void OnExecute(CameraController cameraController) {
            cameraController.LookAtTarget();
            if(cameraController.GoNextPosition()) {
                if(CameraController.instance.stateMachine.GetPrevState().type == CameraState.Type.Idle)

                cameraController.stateMachine.ChangeState(new SecondCameraState(), cameraController);
                else
                cameraController.stateMachine.ChangeState(new IdleState(), cameraController);

            }

        }

        public override void OnExit(CameraController cameraController) {

        }
    }
}

