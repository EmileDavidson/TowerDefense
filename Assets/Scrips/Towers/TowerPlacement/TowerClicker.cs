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
            //what has to happen when clicked
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //what happens when you hit
            if (Physics.Raycast(ray, out hit))
            {
                //what happens when you hit the specif object.
                GameObject obj = hit.transform.gameObject;
                if (obj.CompareTag("TowerObject") || obj.CompareTag("EmptyTower"))
                {
                    //het object dat is geraakt is een tower object
                    TowerHandler.TowerClicked(obj);
                }
            }
        }
    }
}
