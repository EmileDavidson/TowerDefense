namespace Scrips.Towers
{
    public class SingleTargetTower : TowerBase
    {
        protected override bool CanAttack()
        {
            _target = _rangeChecker.GetFirstEnemyInRange();
            return _target != null;
        }
        protected override void Attack()
        {
            print("ik heb een target en val aan.");
        }
    }
}