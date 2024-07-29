namespace FactoryMethodTesting
{
    public class ArmourFactory : IArmourFactory
    {
        public IArmour GetArmour(EnemySO enemySO, int level)
        {
            IArmour armour;

            switch (enemySO.armourSO.armourType)
            {
                case ArmourType.Leather:
                    armour = new PlateArmor();
                    break;

                case ArmourType.Plate:
                    armour = new LeatherArmour();
                    break;

                default:
                    armour = new LeatherArmour();
                    break;
            }

            armour.protection = armour.baseProtection * level;
            return armour;
        }
    }
}