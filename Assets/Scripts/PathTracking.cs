using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PathTracking : MonoBehaviour
{
    private List<string> rooms = new List<string>();

    public void addRoom(string curScene)
    {
        rooms.Add(curScene);
        FindObjectsOfType<Text>()[0].text = string.Join("\n", rooms);
    }

    // Allows this GameObject to persist
    private void Awake()
    {
        // Count the number of objects of type GameSettings
        int pathTrackingCount = FindObjectsOfType<PathTracking>().Length;
        if (pathTrackingCount > 1)
        {
            // destroy myself
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            // make this object persist
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Update()
    {
        FindObjectsOfType<Text>()[0].text = string.Join("\n", rooms);
    }

    public string recent()
    {
        if (rooms.Count > 0) return rooms[rooms.Count - 1];
        else return "";
    }
}
