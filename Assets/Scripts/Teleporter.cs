using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{

    public int destination;
    public Vector3 position;


    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadSceneAsync(destination);
        StartCoroutine(WaitForFade());
    }
    
    IEnumerator WaitForFade()
    {
        yield return null;

        GameController.instance.player.SetPosition(position);
        SceneManager.LoadSceneAsync(destination);

    }
    

}
