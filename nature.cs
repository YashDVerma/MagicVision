using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nature : MonoBehaviour
{
    public void go1() { SceneManager.LoadScene(12); }
    public void go2() { SceneManager.LoadScene(13); }
    public void go3() { SceneManager.LoadScene(14); }
    public void back() { SceneManager.LoadScene(1); }
}
