using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolSpawner : MonoBehaviour
{
    public static ObjectPoolSpawner Instance;

    public GameObject objectPrefab;
    public int poolSize = 10;
    private List<GameObject> pool;

    public GameObject visualIndicator;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }

        UpdateVisualIndicator();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }

        UpdateVisualIndicator();
    }

    public GameObject GetObject()
    {
        foreach (var obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        GameObject newObj = Instantiate(objectPrefab);
        newObj.SetActive(true);
        pool.Add(newObj);
        return newObj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void SpawnObject()
    {
        GameObject obj = GetObject();
        obj.transform.position = transform.position;
    }

    public void MoveLeft()
    {
        transform.position += Vector3.left;
    }

    public void MoveRight()
    {
        transform.position += Vector3.right;
    }

    public void MoveUp()
    {
        transform.position += Vector3.up;
    }

    public void MoveDown()
    {
        transform.position += Vector3.down;
    }

    private void UpdateVisualIndicator()
    {
        if (visualIndicator != null)
        {
            visualIndicator.transform.position = transform.position;
        }
    }
}
