using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance; // only one buildmanager for the whole scene //singleton pattern

    public GameObject standardTurretPrefab;
    public GameObject mediumTurretPrefab;
    public GameObject heavyTurretPrefab;

    private GameObject turretToBuild;

	public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Multiple BuildManagers in scene");
            return;
        }
        instance = this;
    }

   public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
