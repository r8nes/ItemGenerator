using DG.Tweening;
using UnityEngine;

namespace ItemGenerator.UI
{
    [RequireComponent(typeof(RectTransform))]
    public class HomeWindow : MonoBehaviour
    {
        private RectTransform _homeRectTransform;

        [SerializeField] private RectTransform MenuWindow;
        [SerializeField] private RectTransform SettingWindow;

        void Start()
        {
            _homeRectTransform = GetComponent<RectTransform>();
            _homeRectTransform.DOAnchorPosX(0, 0f);
        }

        public void ShowSettingsMenu()
        {
            Hide(-1);
            SettingWindow.DOAnchorPosX(0, 0.3f);
        }

        public void ShowMenuWindow()
        {
            Hide();
            MenuWindow.DOAnchorPosX(0, 0.3f);
        }

        public void HideMenuWindow()
        {
            Show();
            MenuWindow.DOAnchorPosX(MenuWindow.rect.width*-1, 0.3f);
        }

        public void HideSettingWindow() 
        {
            Show();
            SettingWindow.DOAnchorPosX(SettingWindow.rect.width, 0.3f);
        }

        private void Show(float delay = 0f)
        {
            _homeRectTransform.DOAnchorPosX(0, 0.3f);
        }

        private void Hide(int direction = 1)
        {
            _homeRectTransform.DOAnchorPosX(_homeRectTransform.rect.width * direction, 0.3f);
        }
    }
}
