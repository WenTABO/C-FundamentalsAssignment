using ModuleAsignment_RPGcharacters.RPGcharacters.Characters;

using Xunit;
//Character used for testing purpose is Mage
namespace RPG_Characters_Test
{
    public class AttributesAndLevelChecker
    {
        [Fact]
        public void CheckIfNewCharacter_IsLevelOne()
        {
            //Arrange
            BaseCharacter leveltocheck = new MageCharacter();
            int ExpectedLevel = 1;
           
            //Act
            int ActualLevel = leveltocheck.level;
            //Assert

           Assert.Equal(ExpectedLevel, ActualLevel);
        }
        [Fact]
        public void CheckNewCharacter_LevelUp_IsLevelTwo()
        {
            //Arrange
            BaseCharacter GainLevelToCheck = new MageCharacter();
            
            int ExpectedGainLevel = 2;
            //Act
            GainLevelToCheck.LevelUp();
            int ActuaGainlLevel = GainLevelToCheck.level;
            //Assert
            Assert.Equal(ExpectedGainLevel, ActuaGainlLevel);
        }

        //UnitTest #3 throw Exception when level is < 1
        //
        [Fact]
        public void CheckLevelUp_TrowException_LevelIsLessThenOne()
        {
            //Arrange
            BaseCharacter LevelToCheck = new MageCharacter();
            
            //Act and Assert
            LevelToCheck.LevelUp();
            LevelToCheck.level = -1;
            Assert.Throws<System.Exception>(() => LevelToCheck.LevelUp());
        }
        //
        //
        //UnitTest #4 check_default_PrimaryAttributes_fornewCharacter in this CASE MAGE


        [Fact]
        public void CheckIF_MagePrImaryAttributes_Vitality_isFive()
        {
            //Arrange
            BaseCharacter CheckVitalityPrimaryAttribute = new MageCharacter();
            int ExpectedVitalityAttribute = 5;

            //Act
            int ActualVitalityAttribute = CheckVitalityPrimaryAttribute.attributes.Vitality;
            //Assert

            Assert.Equal(ExpectedVitalityAttribute,ActualVitalityAttribute);

        }
        [Fact]
        public void CheckIF_MagePrImaryAttributes_Dexterity_isOne()
        {
            //Arrange
            BaseCharacter CheckDexterityPrimaryAttribute = new MageCharacter();
            int ExpectedDexterityAttribute = 1;

            //Act
            int ActualDexterityAttribute = CheckDexterityPrimaryAttribute.attributes.Dexterity;
            //Assert

            Assert.Equal(ExpectedDexterityAttribute,ActualDexterityAttribute);

        }
        [Fact]
        public void CheckIF_MagePrImaryAttributes_Strenght_isOne()
        {
            //Arrange
            BaseCharacter CheckStrenghtPrimaryAttribute = new MageCharacter();
            int ExpectedStrenghtAttribute = 1;

            //Act
            int ActualStrenghtAttribute = CheckStrenghtPrimaryAttribute.attributes.Strength;
            //Assert

            Assert.Equal(ExpectedStrenghtAttribute, ActualStrenghtAttribute);

        }

        [Fact]
        public void CheckIF_MagePrImaryAttributes_Intelligence_isEight()
        {
            //Arrange
            BaseCharacter CheckIntelligencePrimaryAttribute = new MageCharacter();
            int ExpectedIntelligenceAttribute = 8;

            //Act
            int ActualIntelligenceAttribute = CheckIntelligencePrimaryAttribute.attributes.Intelligence;
            //Assert

            Assert.Equal(ExpectedIntelligenceAttribute,ActualIntelligenceAttribute);

        }




        //UnitTest #5 check_default_AttributesGainPerLevel_in this case Level UP once For  MAGE Character


        [Fact]
        public void CheckIF_MagePrImaryAttributesGainPerLevel_Vitality_IncreasestoEight()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedVitalityGain = 8;

            //Act
            testMage.LevelUp();
            int actualVitalityGain = testMage.attributes.Vitality;
            //Assert

            Assert.Equal(expectedVitalityGain, actualVitalityGain);

        }

        [Fact]
        public void CheckIF_MagePrImaryAttributesGainPerLevel_Strenght_Increasestotwo()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedStrenghtGain = 2;

            //Act
            testMage.LevelUp();
            int actualStrenghtGain = testMage.attributes.Strength;
            //Assert

            Assert.Equal(expectedStrenghtGain, actualStrenghtGain);

        }

        [Fact]
        public void CheckIF_MagePrImaryAttributesGainPerLevel_Dexterity_IncreasestoTwo()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedDexterityGain = 2;

            //Act
            testMage.LevelUp();
            int actualDexterityGain = testMage.attributes.Dexterity;
            //Assert

            Assert.Equal(expectedDexterityGain, actualDexterityGain);

        }
        [Fact]
        public void CheckIF_MagePrImaryAttributesGainPerLevel_Intelligence_IncreasestoThirteen()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedIntelligenceGain = 13;

            //Act
            testMage.LevelUp();
            int actualIntelligenceGain = testMage.attributes.Intelligence;
            //Assert

            Assert.Equal(expectedIntelligenceGain, actualIntelligenceGain);

        }

        ////UnitTest #6 check_SecondAttributes for Health = Vitality*10  For  MAGE Character
        ///
        [Fact]
        public void CheckMageSecondAttributes_Health_isEighty()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedHealth = 80;

            //Act

            testMage.LevelUp();
            int actualHealth = testMage.characterSecondAttributes.Health;
            //Assert

            Assert.Equal(expectedHealth, actualHealth);

        }

        [Fact]
        public void CheckMageSecondAttributes_ArmourRating_isFour()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedArmourRating = 4;

            //Act

            testMage.LevelUp();
            int actualArmourRating = testMage.characterSecondAttributes.ArmourRating;
            //Assert

            Assert.Equal(expectedArmourRating, actualArmourRating); 

        }

        [Fact]
        public void CheckMageSecondAttributes_ElementalResistance_isThirteen()
        {
            //Arrange
            MageCharacter testMage = new MageCharacter();
            int expectedResistance = 13;

            //Act

            testMage.LevelUp();
            int actualResistance = testMage.characterSecondAttributes.ElementalResistance;
            //Assert

            Assert.Equal(expectedResistance, actualResistance);

        }

    }
}