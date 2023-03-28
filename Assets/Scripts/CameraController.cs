using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraSystem {
    public class CameraController : MonoBehaviour {

        public CameraMover mover;

        [SerializeField]
        private Transform targetTransform;


        public Transform camera1;
        public Transform camera2;

        public StateMachine stateMachine;

        static public CameraController instance;

        void Start() {

            if(instance != null)
                return;


            stateMachine = new StateMachine();
            stateMachine.ChangeState(new IdleState(), this);


            instance = this;
            
        }

        // Update is called once per frame
        void Update() {
            stateMachine.GetCurrentState().OnExecute(this);
            /*
            if(!mover.Complete()) {
                transform.position = mover.Move();
                transform.LookAt(targetTransform);
            }
            */
            
        }

        public void LookAtTarget() {
            transform.LookAt(targetTransform);
        }

        public bool GoNextPosition() {

            // return true when next dst reached
            if(mover.Complete())
                return true;

            transform.position = mover.Move();
            return false;
        }
    }

}

