using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youDead : MonoBehaviour
{
    void dead()
     
    {
        SceneManager.LoadScene("Dead");
    }
}
