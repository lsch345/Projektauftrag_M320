﻿namespace Projekt_M320;

public abstract class Person
{
    public string Name { get; set; }

    protected Person(string name)
    {
        Name = name;
    }
}