using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTwin : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Twin2");
    }
}

