using NSubstitute;
using Potyczka.Roles.Models;
using Potyczka.Weapons;

namespace Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        // arrange
        var random = NSubstitute.Substitute.For<Random>();
        random.Next(40).Returns(13);

        var weapon = NSubstitute.Substitute.For<IWeapon>();
        weapon.Damage.Returns(10);
        weapon.Name.Returns("UDAR");
        Character Person = new Character("arek", 100, 2, );
        Person.UseWeapon(weapon);

        //act
        int temp = Person.Attack(true, 0.0);

        // assert
        Assert.AreEqual(12, temp);
    }
}
