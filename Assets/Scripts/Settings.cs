public static class Settings
{
    public static GameMode GameMode = GameMode.Test;
    public static float Tolerance = 3.0f;
    public static float RotationStep = 0.5f;
    public static float MovementStep = 0.1f;
}

public enum GameMode
{
    Campaign,
    Test
}