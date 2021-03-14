using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject arrowPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//LeftClick
        {
            SpawnArrow();
        }

        void SpawnArrow()
        {
            Instantiate(arrowPrefab, transform.position, transform.rotation);
        }
    }
}
