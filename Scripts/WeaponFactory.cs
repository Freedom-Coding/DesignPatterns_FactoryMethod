namespace FactoryMethodTesting
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon GetWeapon(EnemySO enemySO, int level)
        {
            IWeapon weapon;

            switch (enemySO.weaponSO.weaponType)
            {
                case WeaponType.Sword:
                    weapon = new Sword();
                    break;

                case WeaponType.Bow:
                    weapon = new Bow();
                    break;

                default:
                    weapon = new Sword();
                    break;
            }

            weapon.damage = weapon.baseDamage * level;
            return weapon;
        }
    }
}