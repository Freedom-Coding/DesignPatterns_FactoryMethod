using UnityEngine;

namespace FactoryMethodTesting
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Enemy")]
    public class EnemySO : ScriptableObject
    {
        public GameObject prefab;
        public WeaponSO weaponSO;
        public ArmourSO armourSO;
    }
}