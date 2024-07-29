using UnityEngine;

namespace FactoryMethodTesting
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]
    public class WeaponSO : ScriptableObject
    {
        public Sprite sprite;
        public WeaponType weaponType;
    }
}