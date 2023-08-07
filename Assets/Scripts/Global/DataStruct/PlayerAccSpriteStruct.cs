using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class PlayerAccSpriteStruct
{
    public List<FaceSprite> faceSprite;

    public List<HeadSprite> headSprite;

    public List<HeadAccSprite> headAccSprite;

    public List<TopSprite> topSprite;

    public List<GlovesSprite> glovesSprite;

    public List<BottomSprite> bottomSprite;

    public List<BootsSprite> bootsSprite;

    public List<WeaponSprite> weaponSprite;
}

[Serializable]
public class PlayerAccSpriteStructOwned
{
    public List<PriceOwned> faceSprite;

    public List<PriceOwned> headSprite;

    public List<PriceOwned> headAccSprite;

    public List<PriceOwned> topSprite;

    public List<PriceOwned> glovesSprite;

    public List<PriceOwned> bottomSprite;

    public List<PriceOwned> bootsSprite;

    public List<PriceOwned> weaponSprite;
}

[Serializable]
public class FaceSprite
{
    public Sprite face;
    public PriceOwned priceOwned;
}

[Serializable]
public class HeadSprite
{
    public Sprite head;
    public PriceOwned priceOwned;
}

[Serializable]
public class HeadAccSprite
{
    public Sprite headAcc;
    public PriceOwned priceOwned;
}

[Serializable]
public class TopSprite
{
    public Sprite bodyUp;
    public Sprite shoulderLeft;
    public Sprite shoulderRight;
    public PriceOwned priceOwned;
}

[Serializable]
public class BottomSprite
{

    public Sprite pelvis;
    public Sprite legLeft;
    public Sprite legRight;
    public PriceOwned priceOwned;
}

[Serializable]
public class BootsSprite
{
    public Sprite bootsLeft;
    public Sprite bootsRight;
    public PriceOwned priceOwned;
}

[Serializable]
public class GlovesSprite
{
    public Sprite leftWrist;
    public Sprite rightWrist;
    public Sprite leftElbow;
    public Sprite rightElbow;
    public PriceOwned priceOwned;
}

[Serializable]
public class WeaponSprite
{
    public Sprite weapon;
    public PriceOwned priceOwned;
}

[Serializable]
public class PriceOwned
{
    public float price;
    public bool isOwned;
}


