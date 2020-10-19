using System;
using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    // [SerializeField] private GameObject ballistaPrefab;
    // [SerializeField] private GameObject blasterPrefab;
    // [SerializeField] private GameObject cannonPrefab;
    // [SerializeField] private GameObject catapultPrefab;
    // [SerializeField] private GameObject woodStructorPrefab;
    // [SerializeField] private GameObject woodStructorBuildingPrefab;
    // [Space]
    [SerializeField] private GameObject emptyUI;
    [SerializeField] private GameObject ballistaUI;
    [SerializeField] private GameObject cannonUI;
    [SerializeField] private GameObject blasterUI;
    [SerializeField] private GameObject catapultUI;
    [Space]
    [SerializeField] public GameObject currentlySelectedTower;
    public bool userInterfaceOpened = false;
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
        userInterfaceOpened = true;
    }

    public void TowerClicked(GameObject obj)
    {
        if (userInterfaceOpened) return;
        currentlySelectedTower = obj;
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
        currentlySelectedTower = obj;
        DeActiveAll();
    }
    
    public void setTowerUserInterface(GameObject towerUserInterface)
    {
        currentlySelectedTower.GetComponent<TowerBase>().setUsterinterface(towerUserInterface);
    }
    

    public void DeActiveAll()
    {
        DeActiveAllUserInterfaces();
        userInterfaceOpened = false;
    }
}
