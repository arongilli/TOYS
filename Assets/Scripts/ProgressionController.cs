using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Objective
{
    public ObjectiveType objectiveType;
    public bool isDone;
}

public enum ObjectiveType { MAIN, SECONDARY }

public class ProgressionController : MonoBehaviour
{
    public List<Objective> objectives = new List<Objective>();
}
