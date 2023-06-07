using System;
using ItemGenerator.Data;
using TMPro;
using UnityEngine;

namespace ItemGenerator.UI
{
    public class ItemBox : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI ItemName;

        private ItemData ItemData;

        public void OpenInfo() 
        {
            
        }

        public void Constuct(ItemData data)
        {
            ItemName.text = data.Name;
        }
    }
}
