namespace FactoryMethodTesting
{
    public interface IEnemy
    {
        void Initialize(EnemySO _enemySO, IWeapon _iWeapon, IArmour _iArmour);
        void Attack();
        void ReceiveDamage();
    }

    public interface IWeapon
    {
        float baseDamage { get; set; }
        float damage { get; set; }
        void Attack();
    }

    public interface IArmour
    {
        float baseProtection { get; set; }
        float protection { get; set; }
        void Protect();
    }

    public interface IEnemyFactory
    {
        IEnemy GetEnemy(EnemySO enemySO, int level);
    }

    public interface IWeaponFactory
    {
        IWeapon GetWeapon(EnemySO enemySO, int level);
    }

    public interface IArmourFactory
    {
        IArmour GetArmour(EnemySO enemySO, int level);
    }
}