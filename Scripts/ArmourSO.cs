using UnityEngine;

namespace FactoryMethodTesting
{
    [CreateAssetMenu(fileName = "Armour", menuName = "Scriptable Objects/Armour")]
    public class ArmourSO : ScriptableObject
    {
        public Sprite sprite;
        public ArmourType armourType;
    }
}