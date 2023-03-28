using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInputController : MonoBehaviour
{

    void Update() {
        if(Input.GetKeyDown("space")) {
            if(CameraSystem.CameraController.instance.stateMachine.GetCurrentState().type == CameraSystem.CameraState.Type.Idle)
                CameraSystem.CameraController.instance.stateMachine.ChangeState(new CameraSystem.TransactionState(), CameraSystem.CameraController.instance);

            else if(CameraSystem.CameraController.instance.stateMachine.GetCurrentState().type == CameraSystem.CameraState.Type.Second)
                CameraSystem.CameraController.instance.stateMachine.ChangeState(new CameraSystem.TransactionState(), CameraSystem.CameraController.instance);
        }
        
    }
}
