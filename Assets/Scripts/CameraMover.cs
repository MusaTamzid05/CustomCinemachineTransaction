using UnityEngine;

namespace CameraSystem {

    public class CameraMover  {
        private Vector3 src;
        private Vector3 target;
        private float interpolateAmount;

        private Vector3 currentPosition;
        private bool complete;
        private float lerpSpeed;

        public CameraMover(Vector3 src, Vector3 target, float lerpSpeed) {
            this.src = src;
            this.target = target;
            interpolateAmount = 0.0f;
            complete = false;
            this.lerpSpeed = lerpSpeed;
        }

        public Vector3 Move() {
            interpolateAmount =  Mathf.Clamp01(interpolateAmount + Time.deltaTime * lerpSpeed);
            Debug.Log(interpolateAmount);

            if(interpolateAmount == 1.0) {
                complete = true;
                return currentPosition;
            }
            
            currentPosition = Vector3.Lerp(src, target, interpolateAmount);
            return currentPosition;
        }

        public bool Complete() {
            return complete;
        }

    }

}

