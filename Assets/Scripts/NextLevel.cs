using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string mLeveltoLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(mLeveltoLoad);
    }
}
