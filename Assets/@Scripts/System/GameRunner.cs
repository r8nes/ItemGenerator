using UnityEngine;

namespace ItemGenerator.System
{
    public class GameRunner : MonoBehaviour
    {
        public Bootstrap BootPrefab;

        private void Awake()
        {
            var bootstrap = FindObjectOfType<Bootstrap>();

            if (bootstrap == null)
                Instantiate(BootPrefab);
        }
    }
}