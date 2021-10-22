using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int up = -1;
    [SerializeField] int down = -1;
    [SerializeField] int left = -1;
    [SerializeField] int right = -1;

    // takes a scene id and loads that scene if it is positive
    public void loadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    // Update is called once per frame
    void Update()
    {
        // if the user presses an arrow key, load the corresponding scene
        if (Input.GetKeyDown(KeyCode.RightArrow) && right >= 0)
        {
            loadScene(right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && left >= 0)
        {
            loadScene(left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && up >= 0)
        {
            loadScene(up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && down >= 0)
        {
            loadScene(down);
        }
        if(!SceneManager.GetActiveScene().name.Equals(FindObjectOfType<PathTracking>().recent()))
        {
            FindObjectOfType<PathTracking>().addRoom(SceneManager.GetActiveScene().name);
        }
    }
}
