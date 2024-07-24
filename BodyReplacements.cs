using ModelReplacement;
using UnityEngine;

namespace RWBY_NeoPolitan
{
    public class MRNEO : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Neo";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class MRNEOV2 : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "NeoV2";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}