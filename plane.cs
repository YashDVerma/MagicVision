using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour
{
    public void go1() { SceneManager.LoadScene(9); }
    public void go2() { SceneManager.LoadScene(10); }
    public void go3() { SceneManager.LoadScene(11); }
    public void back() { SceneManager.LoadScene(1); }
}
