using UnityEngine;

namespace FactoryMethodTesting
{
    public class EnemyFactory : IEnemyFactory
    {
        private IWeaponFactory weaponFactory;
        private IArmourFactory armourFactory;

        public EnemyFactory(IWeaponFactory _weaponFactory, IArmourFactory _armourFactory)
        {
            weaponFactory = _weaponFactory;
            armourFactory = _armourFactory;
        }

        public IEnemy GetEnemy(EnemySO enemySO, int level)
        {
            GameObject newEnemy = GameObject.Instantiate(enemySO.prefab);

            if (newEnemy.TryGetComponent(out IEnemy iEnemy))
            {
                IWeapon iWeapon = weaponFactory.GetWeapon(enemySO, level);
                IArmour iArmour = armourFactory.GetArmour(enemySO, level);
                iEnemy.Initialize(enemySO, iWeapon, iArmour);
                return iEnemy;
            }
            else
            {
                return null;
            }
        }
    }
}