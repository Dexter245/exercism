using System;

public class SpaceAge
{
    private static readonly int daysToSecs = 24 * 60 * 60;
    private static readonly float earthDaySeconds = 365.25f * daysToSecs;
    private static readonly float mercuryDaySeconds = 0.2408467f * earthDaySeconds;
    private static readonly float venusDaySeconds = 0.61519726f * earthDaySeconds;
    private static readonly float marsDaySeconds = 1.8808158f * earthDaySeconds;
    private static readonly float JupiterDaySeconds = 11.862615f * earthDaySeconds;
    private static readonly float SaturnDaySeconds = 29.447498f * earthDaySeconds;
    private static readonly float uranusDaySeconds = 84.016846f * earthDaySeconds;
    private static readonly float neptuneDaySeconds = 164.79132f * earthDaySeconds;
    private int seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return seconds / earthDaySeconds;
    }

    public double OnMercury()
    {
        return seconds / mercuryDaySeconds;
    }

    public double OnVenus()
    {
        return seconds / venusDaySeconds;
    }

    public double OnMars()
    {
        return seconds / marsDaySeconds;
    }

    public double OnJupiter()
    {
        return seconds / JupiterDaySeconds;
    }

    public double OnSaturn()
    {
        return seconds / SaturnDaySeconds;
    }

    public double OnUranus()
    {
        return seconds / uranusDaySeconds;
    }

    public double OnNeptune()
    {
        return seconds / neptuneDaySeconds;
    }
}