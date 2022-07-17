using NUnit.Framework;
using FluentAssertions;

namespace OopCatExercise.Tests;

public class CatTests
{
    private DomesticCat DomesticCat;
    private LionCat LionCat;
    private CheetahCat CheetahCat;
    [SetUp]

    [Test]
    public void DomesticCat_Should_Be_Awake_By_Default()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.IsAsleep.Should().Be(false);
    }

    [Test]
    public void DomesticCat_Should_Be_Asleep_When_GoToSleep_Is_Called()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.GoToSleep();
        domesticCat.IsAsleep.Should().Be(true);
    }

    [Test]
    public void DomesticCat_Should_Be_Awake_When_WakeUp_Is_Called()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.GoToSleep();
        domesticCat.WakeUp();
        domesticCat.IsAsleep.Should().Be(false);
    }

    [Test]
    public void DomesticCat_Setting_Should_Be_Domestic()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.Setting.Should().Be("domestic");
    }

    [Test]
    public void DomesticCat_AverageHeight_Should_Be_Correct()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.AverageHeight.Should().Be(23);
    }

    [Test]
    public void LionCat_AverageHeight_Should_Be_Correct()
    {
        LionCat lionCat = new LionCat();
        lionCat.AverageHeight.Should().Be(1100);
    }

    [Test]
    public void LionCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        LionCat lionCat = new LionCat();
        lionCat.Eat().Should().Be("Roar!!!!");
    }

    [Test]
    public void CheetahCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        CheetahCat cheetahCat = new CheetahCat();
        cheetahCat.Eat().Should().Be("Zzzzzzz");
    }

    [Test]
    public void DomesticCat_Should_Make_A_Sound_When_Eat_Is_Called()
    {
        DomesticCat domesticCat = new DomesticCat();
        domesticCat.Eat().Should().Be("Purrrrrrr");
    }
}
