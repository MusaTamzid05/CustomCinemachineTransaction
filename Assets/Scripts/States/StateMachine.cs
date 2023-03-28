using UnityEngine;

namespace CameraSystem {

    public class StateMachine  {
        private CameraState currentState;

        public StateMachine() {
            currentState = null;
        }

        public void ChangeState(CameraState state, CameraController cameraController) {
            if(currentState != null) {
                if(currentState.type == state.type) 
                    return;
                currentState.OnExit(cameraController);
            }

            currentState = state;
            currentState.OnEnter(cameraController);
        }

        public CameraState GetCurrentState() {
            return currentState;
        }
    }

}

