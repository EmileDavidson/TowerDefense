using UnityEngine;

public class EnemyInRangeChecker : MonoBehaviour
{
    [SerializeField] float range = 10f;
    [SerializeField] private LayerMask _layer;

    public Enemy GetFirstEnemyInRange()
    {

        Collider[] cols = Physics.OverlapSphere(transform.position, range, _layer);
        foreach (var c in cols)
        {
            if (cols.Length < 1) return null;
            return cols[0].GetComponent<Enemy>();
        }
        return null;
    }

    public Enemy[] GetAllEnemiesInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, range, _layer);
        if (cols.Length < 1) return null;
        Enemy[] enemies = new Enemy[cols.Length];
        for (int i = 0; i < cols.Length; i++) enemies[i] = cols[i].GetComponent<Enemy>();
        return enemies;
    }
    
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
