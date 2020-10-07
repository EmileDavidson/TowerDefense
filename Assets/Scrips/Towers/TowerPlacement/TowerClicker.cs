using UnityEngine;

public class TowerClicker : MonoBehaviour
{
    // Update is called once per frame
    public Camera cam;
    public TowerHandler TowerHandler;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.transform.gameObject;
                print(obj);
                if (obj.CompareTag("TowerObject") || obj.CompareTag("EmptyTower"))
                {
                    //het object dat is geraakt is een tower object
                    TowerHandler.currentlySelectedTower = obj;
                    TowerHandler.TowerClicked();
                }
            }
        }
    }
}
