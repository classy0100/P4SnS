using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour
{
    public void ContinuePrologue()
    {
        SceneManager.LoadScene("Level1");
    }
}
