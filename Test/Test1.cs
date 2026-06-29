using NSubstitute;
using Potyczka.Roles;
using Potyczka.Weapons;
using Potyczka.Roles.ModelsCreators;
using Potyczka.Extra;

namespace Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        // arrange
        var random = NSubstitute.Substitute.For<Random>();
        random.Next(41).Returns(20);

        var weapon = NSubstitute.Substitute.For<IWeapon>();
        weapon.Damage.Returns(10);
        weapon.Name.Returns("UDAR");
        weapon.PerformAttack().Returns(10);

        CharacterSpawner characterSpawner = new MageCreator();
        Character Person = characterSpawner.CreateCharacter();
        Person.UseWeapon(weapon);

        //act
        AttackerResponse temp = Person.Attack();
        AttackerResponse ans = new AttackerResponse(40, 40, 0);

        // assert
        Assert.AreEqual(ans, temp);
    }
}



