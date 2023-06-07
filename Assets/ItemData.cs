using System;

namespace ItemGenerator.Data
{
    [Serializable]
    public class ItemData
    {
        public string Name;
        public string Rank;

        public string Type;
        public ItemTypeId SubType;
         
        public string Description;
        public string Properties;
        public string Note;
    }
}