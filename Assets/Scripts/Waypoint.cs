using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField]
    GameObject towerPrefab;
    [SerializeField]
    bool isPlaceable;

    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
        }
    }
}
