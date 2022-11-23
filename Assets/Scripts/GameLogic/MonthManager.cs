using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthManager : MonoBehaviour
{
    private const int MONTH_LIMIT = 50;

    private int monthCounter;

    private void Start()
    {
        monthCounter = 0;
    }

    public void MoveToNextMonth()
    {
        Debug.Log("New Month begins");
        monthCounter++;
    }
}
