using UnityEngine;

namespace FactoryMethodTesting
{
    public class Enemy : MonoBehaviour, IEnemy
    {
        [SerializeField] private SpriteRenderer weaponRenderer;
        [SerializeField] private SpriteRenderer armourRenderer;

        private EnemySO enemySO;
        private IWeapon iWeapon;
        private IArmour iArmour;

        public void Initialize(EnemySO _enemySO, IWeapon _iWeapon, IArmour _iArmour)
        {
            enemySO = _enemySO;
            iWeapon = _iWeapon;
            iArmour = _iArmour;
            SetWeaponAndArmour();
        }

        private void SetWeaponAndArmour()
        {
            weaponRenderer.sprite = enemySO.weaponSO.sprite;
            armourRenderer.sprite = enemySO.armourSO.sprite;
        }


        public void Attack()
        {
            iWeapon.Attack();
        }

        public void ReceiveDamage()
        {
            iArmour.Protect();
        }
    }
}