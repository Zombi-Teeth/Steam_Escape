using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma once

#include <iostream>

class DoorBeh
{
    private:
    bool isOpen;
    int activatedPressurePoints;
    int totalPressurePoints;

    public:
    DoorBeh(int pressurePoints);

    // Checks if the door can open
    void CheckDoorStatus();

    // Called when a pressure point is activated
    void ActivatePressurePoint();

    // Opens the door
    void OpenDoor();
};
// Constructor to initialize door and pressure points
DoorBeh::DoorBeh(int pressurePoints)
    : isOpen(false), activatedPressurePoints(0), totalPressurePoints(pressurePoints) { }

void DoorBeh::ActivatePressurePoint() {
    if (activatedPressurePoints < totalPressurePoints)
    {
        activatedPressurePoints++;
        std::cout << "Pressure Point Activated: " << activatedPressurePoints << "/" << totalPressurePoints << "\n";
        CheckDoorStatus();
    }
}

void DoorBeh::CheckDoorStatus() {
    if (activatedPressurePoints == totalPressurePoints)
    {
        OpenDoor();
    }
}

void DoorBeh::OpenDoor() {
    isOpen = true;
    std::cout << "Door is now open!\n";
    // Add actual logic for interacting with your door in the game.
}

void DoorBeh::CloseDoor() {
    isOpen = false;
    activatedPressurePoints = 0;
    std::cout << "Door is now closed.\n";
}

bool DoorBeh::GetDoorStatus() const {
    return isOpen;
}