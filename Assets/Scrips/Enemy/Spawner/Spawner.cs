using Opdrachten;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PlayerHealth PlayerHealthScript;
    
    private void Start()
    {
        SpawnEnemy();
    }
    
    public void SpawnEnemy()
    {
        GameObject enemyObj = Instantiate(enemyPrefab);
        enemyObj.GetComponent<PathFollower>().ONPathComplete.AddListener(() => PlayerHealthScript.TakeDamage(1));
        enemyObj.transform.position = this.transform.position;
    }
}
