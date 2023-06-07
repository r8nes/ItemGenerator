using DG.Tweening;
using UnityEngine;

namespace ItemGenerator.UI
{
    [RequireComponent(typeof(RectTransform))]
    public class HomeWindow : MonoBehaviour
    {
        [SerializeField] private RectTransform _homeRectTransform;
        [SerializeField] private RectTransform _menuWindow;
        [SerializeField] private RectTransform _settingWindow;

        void Start()
        {
            if (_homeRectTransform != null)
                _homeRectTransform.DOAnchorPosX(0, 0f);
        }

        #region Animated Methods

        public void ShowSettingsMenu()
        {
            Hide(-1);
            _settingWindow.DOAnchorPosX(0, 0.3f);
        }

        public void ShowMenuWindow()
        {
            Hide();
            _menuWindow.DOAnchorPosX(0, 0.3f);
        }

        public void HideMenuWindow()
        {
            Show();
            _menuWindow.DOAnchorPosX(_menuWindow.rect.width*-1, 0.3f);
        }

        public void HideSettingWindow() 
        {
            Show();
            _settingWindow.DOAnchorPosX(_settingWindow.rect.width, 0.3f);
        }

        #endregion

        private void Show()
        {
            _homeRectTransform.DOAnchorPosX(0, 0.3f);
        }

        private void Hide(int direction = 1)
        {
            _homeRectTransform.DOAnchorPosX(_homeRectTransform.rect.width * direction, 0.3f);
        }
    }
}
