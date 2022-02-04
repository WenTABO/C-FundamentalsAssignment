using ModuleAsignment_RPGcharacters.RPGcharacters.Characters;

using Xunit;

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
            int ActualLevel = leveltocheck.Level;
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
            int ActuaGainlLevel = GainLevelToCheck.levelUp();
            //Assert
            Assert.Equal(ExpectedGainLevel, ActuaGainlLevel);
        }
        //
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
            int ActualVitalityAttribute = CheckVitalityPrimaryAttribute.Attributes.Vitality;
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
            int ActualDexterityAttribute = CheckDexterityPrimaryAttribute.Attributes.Dexterity;
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
            int ActualStrenghtAttribute = CheckStrenghtPrimaryAttribute.Attributes.Strength;
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
            int ActualIntelligenceAttribute = CheckIntelligencePrimaryAttribute.Attributes.Intelligence;
            //Assert

            Assert.Equal(ExpectedIntelligenceAttribute,ActualIntelligenceAttribute);

        }




        //UnitTest #5 check_default_AttributesGainPerLevel_in this case Level UP once For  MAGE Character


        [Fact]
        public void CheckIF_MagePrImaryAttributesGainPerLevel_Vitality_IncreasestoEight()
        {
            //Arrange
            BaseCharacter CheckVitalityGainAttribute = new MageCharacter();
            int ExpectedVitalityGainAttribute = 8;

            //Act
            int ActualVitalityGainAttribute = CheckVitalityGainAttribute.pri();
            //Assert

            Assert.Equal(ExpectedVitalityGainAttribute, ActualVitalityGainAttribute);

        }

        ////UnitTest #6 check_SecondAttributes for Health = Vitality*10  For  MAGE Character
        ///
        [Fact]
        public void CheckMageSecondAttributes_Health_isFifty()
        {
            //Arrange
            BaseCharacter CheckMageHealthAttribute = new MageCharacter();
            int ExpectedMageHealthAttribute = 50;

            //Act
            int ActualMageHealthAttribute = CheckMageHealthAttribute.CharacterSecondAttributes.Health;
            //Assert

            Assert.Equal(ExpectedMageHealthAttribute, ActualMageHealthAttribute);

        }

    }
}