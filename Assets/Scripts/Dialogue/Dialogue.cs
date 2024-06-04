using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Dialogue
{
    public string name;

    [TextArea(2,10)]
    public string[] sentences;

}