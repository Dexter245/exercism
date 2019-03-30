// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

public class ResistorColorTest
{
    [Fact]
    public void Black()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    public void White()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    public void Orange()
    {
        Assert.Equal(3, ResistorColor.ColorCode("orange"));
    }

    public void Colors()
    {
        Assert.Equal(new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" }, ResistorColor.Colors());
    }
}