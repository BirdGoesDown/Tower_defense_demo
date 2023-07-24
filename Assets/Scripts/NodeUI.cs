using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    public Text upgradeCost;
    public Button upgradeButton;

    private Nodes target;

    
    public void SetTarget (Nodes _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }else
        {
            upgradeCost.text = "Full Upgraded";
            upgradeButton.interactable = false;
        }


        Debug.Log("ac");
        ui.SetActive(true);
    }

    public void Hide ()
    {
        ui.SetActive(false);
        Debug.Log("kapa");
    }

    public void Upgrade ()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }
}
