using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard turret selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    
    public void PurchaseMediumTurret()
    {
        Debug.Log("Medium turret selected");
        buildManager.SetTurretToBuild(buildManager.mediumTurretPrefab);
    }

    public void PurchaseHeavyTurret()
    {
        Debug.Log("Heavy turret selected");
        buildManager.SetTurretToBuild(buildManager.heavyTurretPrefab);
    }


}