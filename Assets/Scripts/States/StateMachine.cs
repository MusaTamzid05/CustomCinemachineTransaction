using UnityEngine;

namespace CameraSystem {

    public class StateMachine  {
        private CameraState currentState;
        private CameraState prevState;

        public StateMachine() {
            currentState = null;
            prevState = null;
        }

        public void ChangeState(CameraState state, CameraController cameraController) {
            if(currentState != null) {
                if(currentState.type == state.type) 
                    return;
                currentState.OnExit(cameraController);
            }

            prevState = currentState;
            currentState = state;
            currentState.OnEnter(cameraController);
        }

        public CameraState GetCurrentState() {
            return currentState;
        }

        public CameraState GetPrevState() {
            return prevState;
        }
    }

}

