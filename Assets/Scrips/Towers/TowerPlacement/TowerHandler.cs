using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    [SerializeField] private GameObject ballistaPrefab;
    [SerializeField] private GameObject blasterPrefab;
    [SerializeField] private GameObject cannonPrefab;
    [SerializeField] private GameObject catapultPrefab;
    [SerializeField] private GameObject woodStructorPrefab;
    [SerializeField] private GameObject woodStructorBuildingPrefab;
    [Space]
    [SerializeField] private GameObject emptyUI;
    [SerializeField] private GameObject ballistaUI;
    [SerializeField] private GameObject cannonUI;
    [Space]
    [SerializeField] public GameObject currentlySelectedTower;

    private void Start()
    {
        DeActiveAllUserInterfaces();
    }

    public void DeActiveAllUserInterfaces()
    {
        emptyUI.SetActive(false);
        ballistaUI.SetActive(false);
        cannonUI.SetActive(false);
    }

    public void ActiveUserInterface(GameObject userInterface)
    {
        userInterface.SetActive(true);
    }

    public void TowerClicked()
    {
        if (currentlySelectedTower.CompareTag("EmptyTower"))
        {
            //er staat nog geen toren. 
            DeActiveAllUserInterfaces();
            ActiveUserInterface(emptyUI);
        }

        if (currentlySelectedTower.CompareTag("TowerObject"))
        {
             //er staat wel een tower op 
        }
    }

    public void SetTower(GameObject tower)
    {
        GameObject obj = Instantiate(tower);
        obj.transform.position = currentlySelectedTower.transform.position;
        Destroy(currentlySelectedTower);
        DeActiveAllUserInterfaces();
    }
}
