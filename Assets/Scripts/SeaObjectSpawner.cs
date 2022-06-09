using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coralPrefab;
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private GameObject seaTurtlePrefab;
    [SerializeField] private GameObject dolphinPrefab;
    [SerializeField] private GameObject seahorsePrefab;
    [SerializeField] Transform parent;

    // Start is called before the first frame update
    public void SpawnCoral()
    {
        Vector3 position = new Vector3(0, -0.79f, -3.66f);
        Instantiate(coralPrefab, position, Quaternion.identity, parent);
    }

    public void SpawnRock()
    {
        Vector3 position = new Vector3(0, -0.7f, -3.3f);
        Instantiate(rockPrefab, position, Quaternion.Euler(-89.98f, 170, 180), parent);
    }

    public void SpawnSeaTurtle()
    {
        Vector3 position = new Vector3(0, 0.54f, -7.68f);
        GameObject seaTurtle = Instantiate(seaTurtlePrefab, position, Quaternion.identity, parent) as GameObject;
        seaTurtle.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }

    public void SpawnDolphin()
    {
        Vector3 position = new Vector3(0, .12f, -7);
        GameObject dolphin = Instantiate(dolphinPrefab, position, Quaternion.Euler(0, -105, 0), parent) as GameObject;
        dolphin.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
    }

    public void SpawnSeahorse()
    {
        Vector3 position = new Vector3(0.1f, .5f, -8);
        GameObject seahorse = Instantiate(seahorsePrefab, position, Quaternion.Euler(0, 50, 0), parent) as GameObject;
        seahorse.transform.localScale = new Vector3(5, 5, 5);
    }

}
