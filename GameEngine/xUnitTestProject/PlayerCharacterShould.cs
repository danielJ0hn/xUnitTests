using GameEngine;

namespace xUnitTestProject.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }
        [Fact]
        public void CalculateFullName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Test";
            sut.LastName = "Name1";

            Assert.Equal("Test Name1", sut.FullName);
            Assert.StartsWith("Test", sut.FullName);
            Assert.EndsWith("e1", sut.FullName);
            Assert.Equal("test name1", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullName_startWithProperty()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Test";
            sut.LastName = "Name1";

            Assert.StartsWith("Test", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_endsWithProperty()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Test";
            sut.LastName = "Name1";

            Assert.EndsWith("e1", sut.FullName);
        }


        [Fact]
        public void CalculateFullName_ignoreCase()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Test";
            sut.LastName = "Name1";
            Assert.Equal("test name1", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullNameSubstring()
        {

            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Test";
            sut.LastName = "Name1";

            Assert.Contains("t N", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "Test";
            sut.LastName = "Name1";

            Assert.Matches("[A-Z][a-z]+ [A-Z][a-z]+", sut.FullName);
        }

        [Fact]
        public void StartWithDefaultValue()
        {
            var sut = new PlayerCharacter();

            Assert.Equal(100, sut.Health);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter();
            sut.Sleep();

            Assert.True(sut.Health > 100 && sut.Health <= 200);
            Assert.InRange<int>(sut.Health, 101, 200);
        }

        [Fact]
        public void NotHaveNicknamesByDefault()
        {
            var sut = new PlayerCharacter();
            Assert.Null(sut.Nickname);
        }

        [Fact]
        public void HaveALongBow()
        {
            var sut = new PlayerCharacter();
            Assert.Contains("Long Bow", sut.Weapons);
        }

        [Fact]
        public void NotHaveStaffOfWonder()
        {
            var sut = new PlayerCharacter();
            Assert.DoesNotContain("Staff of wonder", sut.Weapons);
        }
        [Fact]
        public void HaveAtleastOneKindOfSword()
        {
            var sut = new PlayerCharacter();
            Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));
        }

        [Fact]
        public void HaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();
            var expectedWeapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
            };

            Assert.Equal(expectedWeapons, sut.Weapons);

        }
    }
}
