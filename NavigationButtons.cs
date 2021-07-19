using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationButtons : MonoBehaviour
{
    public GameObject[] objs;

    int index = 0;

    public void ClickOn()
    {
        objs[index++].SetActive(true);

        if (index == objs.Length)
        {
            index = objs.Length - 1;
        }
    }

    public void ClickOff()
    {
        objs[index--].SetActive(false);

        if (index < 0)
        {
            index = 0;
        }
    }
}
