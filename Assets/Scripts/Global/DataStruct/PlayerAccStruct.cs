using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class PlayerAccStruct
{
    public Face face;

    public Head head;

    public HeadAcc headAcc;

    public Top top;

    public Gloves gloves;

    public Bottom bottom;

    public Boots boots;

    public Weapon weapon;
}

[Serializable]
public class Face
{
    public SpriteRenderer face;
}

[Serializable]
public class Head
{
    public SpriteRenderer head;
}

[Serializable]
public class HeadAcc
{
    public SpriteRenderer headAcc;
}

[Serializable]
public class Top
{
    public SpriteRenderer bodyUp;
    public SpriteRenderer shoulderLeft;
    public SpriteRenderer shoulderRight;
}

[Serializable]
public class Bottom
{

    public SpriteRenderer pelvis;
    public SpriteRenderer legLeft;
    public SpriteRenderer legRight;
}

[Serializable]
public class Boots
{
    public SpriteRenderer bootsLeft;
    public SpriteRenderer bootsRight;
}

[Serializable]
public class Gloves
{
    public SpriteRenderer leftWrist;
    public SpriteRenderer rightWrist;
    public SpriteRenderer leftElbow;
    public SpriteRenderer rightElbow;
}

[Serializable]
public class Weapon
{
    public SpriteRenderer weapon;
}


