﻿using UnityEngine;
using System.Collections;

public enum StructureType {

    Station,
    Ship,
    Human,
    Item
}

public enum FactoryType
{
    Coal,
    Fuel,
    Iron,
    Steel,
    Ship,
    Glass,
    Sculpture,
    Wheat,
    Food,
    Consumer
}

public enum SolarType
{
    Star,
    Planet,
    Moon,
    Asteroid,
    Structure
}

public enum ShipMode
{
    Buy,
    Sell,
    SearchingTradeRoute,
    Idle
}