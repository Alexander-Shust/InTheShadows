﻿public static class Settings
{
    public static GameMode GameMode = GameMode.Test;
    public static float Tolerance = 2.0f;
    public static float RotationStep = 0.2f;
}

public enum GameMode
{
    Campaign,
    Test
}