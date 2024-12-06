using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#include "DoorBeh.h"

void OnObjectPlacedOnPressurePoint(DoorBeh &door, bool isObjectPlaced)
{
    if (isObjectPlaced)
    {
        door.ActivatePressurePoint();
    }
}

int main()
{
    DoorBeh door(3); // Example: Door needs 3 pressure points

    // Simulating objects being placed
    OnObjectPlacedOnPressurePoint(door, true);
    OnObjectPlacedOnPressurePoint(door, true);
    OnObjectPlacedOnPressurePoint(door, true);

    if (door.GetDoorStatus())
    {
        std::cout << "Player can now proceed to the next area.\n";
    }

    return 0;
}