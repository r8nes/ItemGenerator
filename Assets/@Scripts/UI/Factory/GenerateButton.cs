using ItemGenerator.Data;
using ItemGenerator.UI.Factory;
using UnityEngine;

namespace ItemGenerator.UI
{
    public class GenerateButton : MonoBehaviour
    {
        public Transform ContentBox;

        private IUIFactory _uiFactory;
        private FilterConfiguration _filterConfiguration;

        public void Construct(IUIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public void GenerateItems()
        {
            for (int i = 0; i < 5; i++)
            {
                ItemData data = new ItemData
                {
                    Name = "Swrod Of Painful Anal Penetration",
                    Description = "Lorem Ipsum this is a description",
                    Note = "Lorem Ipsum this is a note",
                    Properties = "Some Prop",
                    Rank = "Rare",
                    SubType = ItemTypeId.SWORD,
                    Type = "Equipment"
                };

               var item = _uiFactory.CreateItemBox(data);

                item.transform.SetParent(ContentBox);
                item.transform.localScale = Vector3.one;
            }
        }
    }
}