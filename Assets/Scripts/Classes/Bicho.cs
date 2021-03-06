﻿using System;

[Serializable]
public class Bicho
{
    public enum Families
    {
        Animals, Persons, Dinosaurs, Robots, Aliens
    }

    public enum Purities
    {
        Mixed, Combined, Pure
    }

    public enum Materials
    {
        Glass, Wood, Stone, Gold, Rubi
    }

    private Families _familyTop;
    private Families _familyBottom;
    private Purities _purity;
    private Materials _material;

    public int ID
    {
        get => _id;
        set => _id = value;
    }

    private int _id;

    public Bicho(int id, Families familyTop, Families familyBottom, Purities purity, Materials material)
    {
        _id = id;
        _familyTop = familyTop;
        _familyBottom = familyBottom;
        _purity = purity;
        _material = material;
    }

    public Families FamilyTop
    {
        get => _familyTop;
        set => _familyTop = value;
    }

    public Families FamilyBottom
    {
        get => _familyBottom;
        set => _familyBottom = value;
    }

    public Purities Purity
    {
        get => _purity;
        set => _purity = value;
    }

    public Materials Material
    {
        get => _material;
        set => _material = value;
    }
}
