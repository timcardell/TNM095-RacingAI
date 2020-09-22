using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePlacement : MonoBehaviour
{
    // the Equip prefab - required for instantiation
    public GameObject equipPrefab;
    public GameObject upgradePrefab;
    private Grid GameGrid;


    // list that holds all created objects - deleate all instances if desired
    public List<GameObject> createdObjects = new List<GameObject>();
    public Player currentPlayer;
    private float minX, maxX, minY, maxY;

    public void Awake()
    {
        GameGrid = FindObjectOfType<Grid>();
    }

    void Start()
    {
        // get the screen bounds
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;
    }



    public void CreateObject()
    {
        // a prefab is need to perform the instantiation
        if (equipPrefab != null)
        {
            // get a random postion to instantiate the prefab - you can change this to be created at a fied point if desired
            Vector3 position = new Vector3(Random.Range(minX + 0.5f, maxX - 0.5f), Random.Range(minY + 0.5f, maxY - 0.5f), 0);

            // instantiate the object
            GameObject go = Instantiate(equipPrefab, position, Quaternion.identity) as GameObject; ;

            createdObjects.Add(go);
            currentPlayer.Towns.Add(go);
        }
    }

    public void upgradeToTown()
    {

        if(currentPlayer.Stone >= 2 && currentPlayer.Wheat >= 3 && currentPlayer.Towns.Count > 0)
        {
            currentPlayer.Towns.RemoveAt(currentPlayer.Towns.Count);
            // get a random postion to instantiate the prefab - you can change this to be created at a fied point if desired
            Vector3 position = new Vector3(Random.Range(minX + 0.5f, maxX - 0.5f), Random.Range(minY + 0.5f, maxY - 0.5f), 0);

            // instantiate the object
            GameObject go = (GameObject)Instantiate(upgradePrefab, position, Quaternion.identity);

            currentPlayer.Settlements.Add(go);

        }



    }

}
