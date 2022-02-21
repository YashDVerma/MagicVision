using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Categories : MonoBehaviour
{
   public void go1() { SceneManager.LoadScene(3); }
    public void go2() { SceneManager.LoadScene(5); }
    public void go3() { SceneManager.LoadScene(4); }
    public void go4() { SceneManager.LoadScene(2); }
    public void back() { SceneManager.LoadScene(0); }
}
