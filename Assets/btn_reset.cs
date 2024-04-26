using UnityEngine;
using System.Collections.Generic; // Added namespace for Dictionary
using UnityEngine.SceneManagement;

public class btn_reset : MonoBehaviour
{
    // Dictionary to store original positions of cubes
    private Dictionary<GameObject, Vector3> originalPositions = new Dictionary<GameObject, Vector3>();

    void Start()
    {
        // Store original positions of cubes when the game starts
        StoreOriginalPositions();
    }

    void StoreOriginalPositions()
    {
        // Find all cubes in the scene
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        // Store original positions of cubes
        foreach (GameObject cube in cubes)
        {
            originalPositions[cube] = cube.transform.position;
        }
    }

    public void ResetToOriginalPositions()
    {
        // Reset cubes to their original positions
        foreach (var pair in originalPositions)
        {
            GameObject cube = pair.Key;
            Vector3 originalPosition = pair.Value;
            cube.transform.position = originalPosition;
        }
    }

    // Example method to move cubes during runtime
    void MoveCubes()
    {
        // Example: Move cubes around during runtime
    }
     //public void PlayGame()
    //{
        //SceneManager.LoadSceneAsync(0);
    //} 
    public void GameQuit()
    {
        Application.Quit();
    }
}
