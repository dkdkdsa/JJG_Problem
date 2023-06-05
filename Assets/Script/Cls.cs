using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PluralQus
{

    [TextArea] public string qus;
    public List<string> selects = new List<string>();
    public string answer;

}

[System.Serializable]
public class SubjectivityQus
{

    [TextArea] public string qus;
    public string answer;

}