
namespace CameraSystem {
    public abstract class CameraState  {
        public enum Type {
            Idle,
            Transaction,
            Second,
        };

        public Type type;

        public CameraState(Type type) {
            this.type = type;
        }

        public abstract void OnEnter(CameraController cameraController);
        public abstract void OnExecute(CameraController cameraController);
        public abstract void OnExit(CameraController cameraController);

    }

}
