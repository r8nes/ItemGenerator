using System;
using ItemGenerator.UI.Services;
using UnityEngine;
using UnityEngine.UI;

namespace ItemGenerator.UI
{
    public abstract class WindowBase : MonoBehaviour
    {
        public Button CloseButton;

        protected WindowId _windowId;

        public event Action<WindowId> WindowClosed;

        public void Construct(WindowId Id)
        {
            _windowId = Id;
        }

        private void Awake() => OnAwake();
        private void Start()
        {
            SubScribeUpdates();
        }
        private void OnDestroy() => CleanUp();

        protected virtual void OnAwake() => CloseButton.onClick.AddListener(() => Destroy(gameObject));
        protected virtual void SubScribeUpdates() { }
        protected virtual void CleanUp() { }

        public WindowId GetId()
        {
            return _windowId;
        }
    }
}
