using DuckHunt.Models;
using System.Windows;
using System;
using DuckHunt.Factories;

namespace DuckHunt.Behaviours
{
    interface DrawBehaviour : Behaviour
    {
        DrawBehaviour CreateInstance(Unit unit);
    }
}
