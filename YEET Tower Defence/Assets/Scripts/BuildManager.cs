using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance; // only one buildmanager for the whole scene //singleton pattern

    public GameObject standardTurretPrefab;
    public GameObject mediumTurretPrefab;
    public GameObject heavyTurretPrefab;

    private TurretBlueprint turretToBuild;


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Multiple BuildManagers in scene");
            return;
        }
        instance = this;
    }

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

    public void  BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("not enough money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret =  (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.currentTurret = turret;

        Debug.Log("Turret build! Money left: " + PlayerStats.Money);
    }
}
