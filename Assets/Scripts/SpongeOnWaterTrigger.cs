using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpongeOnWaterTrigger : MonoBehaviour
{
    //public UIController uiController;
    public GameObject activateIcon;
    //public boolean SpongeOnWater = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 4) {
            SpongeController controller = gameObject.GetComponent<SpongeController>();
            if (controller.enabled == false) {
                activateIcon.SetActive(true);
                }
            
        }
    }
}
