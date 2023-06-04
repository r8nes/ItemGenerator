using System.Collections.Generic;
using UnityEngine;

namespace ItemGenerator.Data
{
    [CreateAssetMenu(fileName = "ImageData", menuName = "StaticData/ImageType")]
    public class ImageTypeStaticData : BaseStaticData
    {
        public List<ImageTypeConfigData> Configs;
    }
}