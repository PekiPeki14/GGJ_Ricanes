using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Load", 4);
        
    }

    void Load() {
        SceneManager.LoadScene("Cinescene");
    }
}
