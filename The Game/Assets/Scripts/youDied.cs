using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youDied : MonoBehaviour
{
    void OnTriggerEnter(Collider player)

    {
        SceneManager.LoadScene("Dead");
    }
}
