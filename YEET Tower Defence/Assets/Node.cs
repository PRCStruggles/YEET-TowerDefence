using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    BuildManager buildManager;


    private GameObject currentTurret;
    private Renderer rend;
    private Color nodeStartColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        nodeStartColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (currentTurret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
       currentTurret = Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject()) //When player moves game behind the UI, hovering on nodes will be disabled.
        {
            return;
        }

        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        rend.material.color = hoverColor;
        if (currentTurret != null)
        {
            rend.material.color = Color.red;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = nodeStartColor;
    }

}
