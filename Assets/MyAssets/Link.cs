using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
  public void facebook()
    {
        Application.OpenURL("https://www.facebook.com");
    }
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com");
    }
    public void GitHub()
    {
        Application.OpenURL("https://github.com/");
    }
    public void LinkedIn()
    {
        Application.OpenURL("https://linkedin.com/");
    }
}
