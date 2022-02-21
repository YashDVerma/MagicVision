using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animal : MonoBehaviour
{
    public void go1() { SceneManager.LoadScene(15); }
    public void go2() { SceneManager.LoadScene(16); }
    public void go3() { SceneManager.LoadScene(17); }
    public void back() { SceneManager.LoadScene(1); }
}
