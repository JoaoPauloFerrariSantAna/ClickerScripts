using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager mInstance;
    public static GameManager gInstance => mInstance;

    [SerializeField]
    private static int mIncrement = 1;
    [SerializeField]
    private static int mCurrentPoints;
    [SerializeField]
    private static int mUpgradeValue = 15;

    public int GetPoints()
    {
        return mCurrentPoints;
    }

    public int GetUpgradeValue()
    {
        return mUpgradeValue;
    }

    public int GetIncrement()
    {
        return mIncrement;
    }

    public void SetPoints(int points)
    {
        mCurrentPoints = points;
    }

    public void UpdateUpgradeValue()
    {
        mUpgradeValue <<= 1;
    }

    public void UpdateIncrementValue()
    {
        mIncrement <<= 1;
    }

    public void Start()
    {
        mInstance = this;
    }
}