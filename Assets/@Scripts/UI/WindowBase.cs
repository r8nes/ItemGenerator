using UnityEngine;
using UnityEngine.UI;

namespace ItemGenerator.UI
{
    public abstract class WindowBase : MonoBehaviour
    {
        public Button CloseButton;

        private void Awake() => OnAwake();
        
        private void Start()
        {
            Initialize();
            SubScribeUpdates();
        }

        private void OnDestroy() => CleanUp();
        protected virtual void OnAwake() => CloseButton.onClick.AddListener(() => Destroy(gameObject));
        protected virtual void Initialize() {}
        protected virtual void SubScribeUpdates() {}
        protected virtual void CleanUp() {}
        
    }
}
