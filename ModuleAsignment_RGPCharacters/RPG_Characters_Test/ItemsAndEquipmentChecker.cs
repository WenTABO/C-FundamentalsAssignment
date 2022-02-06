using ModuleAsignment_RPGcharacters.RPGcharacters.Characters;
using ModuleAsignment_RPGcharacters.RPGcharacters.Item;
using ModuleAsignment_RPGcharacters.RPGcharacters.Tools;
using Xunit;

namespace RPG_Characters_Test
{
    public class ItemsAndEquipmentChecker
    {
        //        1) If a character tries to equip a high level weapon, InvalidWeaponException should be thrown.
        //o Use the warrior, and the axe, but set the axes level to 2.

        [Fact]
        public void CheckWrongWeaponLevel_Thrown_Exception_Mage()
        {
            //Arrange
            MageCharacter checkValidWeaponLevel = new MageCharacter();
            //Act and Assert
            var itemWeapon = new Weapon { weaponType = WeaponType.Staffs, Slot = ItemSlot.Weapon };
            int actualitemlevel = 2;
            Assert.Throws<System.Exception>(() => checkValidWeaponLevel.EquipWeapon(itemWeapon, actualitemlevel));
        }
        //2) If a character tries to equip a high level armor piece, InvalidArmorException should be thrown.
        // I use Mage, and the plate body armor.

        [Fact]
        public void CheckWrongArmourLevel_Thrown_Exception_Mage()
        {
            //Arrange
            MageCharacter checkValidArmourLevel = new MageCharacter();
            //Act and Assert
            var itemArmour = new Armour { ArmourType = ArmourType.Cloth, Slot = ItemSlot.Body };
            int actualitemlevel = 2;
            Assert.Throws<System.Exception>(() => checkValidArmourLevel.EquipArmour( itemArmour, actualitemlevel));
        }
        //3) If a character tries to equip the wrong weapon type, InvalidWeaponException should be thrown.
        //o Use the warrior and the bow.
        [Fact]
        public void CheckWrongWeapon_Thrown_Exception_Mage()
        {
            //Arrange
            MageCharacter checkMageValidWeapon = new MageCharacter();
            //Act and Assert
            var itemWeapon = new Weapon { weaponType = WeaponType.Bows, Slot = ItemSlot.Weapon };
            int actualitemlevel = 1;
            Assert.Throws<InvalidWeaponException>(() => checkMageValidWeapon.EquipWeapon(itemWeapon,actualitemlevel ));
        }

        //4) If a character tries to equip the wrong armor type, InvalidArmorException should be thrown.
        //I Use the Mage and the Plate armor.

        [Fact]
        public void CheckWrongArmour_Thrown_Exception_Mage()
        {
            //Arrange
            MageCharacter checkMageArmour = new MageCharacter();

            //Act and Assert
            int actualitemlevel = 1;
            var itemArmour = new Armour { ArmourType = ArmourType.Plate, Slot = ItemSlot.Body };
            Assert.Throws<InvalidArmourException>(() => checkMageArmour.EquipArmour(itemArmour,actualitemlevel));
        }

        //5) If a character equips a valid weapon, a success message should be returned
        //o “New weapon equipped!”
        [Fact]
        public void CheckValidWeapon_Message_Mage()
        {
            //Arrange
            MageCharacter checkValidMessage = new MageCharacter();
            string expectedMessage = "New Weapon equipped";
            //Act 
            var itemWeapon = new Weapon { weaponType = WeaponType.Wands, Slot = ItemSlot.Weapon };
            int actualitemlevel = 1;
            checkValidMessage.EquipWeapon(itemWeapon, actualitemlevel);
            string actualMessage = checkValidMessage.validWeaponMessage;


            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }
        //6) If a character equips a valid armor piece, a success message should be returned
        //o “New armour equipped!”
        [Fact]
        public void CheckValidArmour_Message_Mage()
        {
            //Arrange
            MageCharacter checkValidMessage = new MageCharacter();
            string expectedMessage = "New Armour equipped";
            //Act 
            var itemArmour = new Armour { ArmourType = ArmourType.Cloth, Slot = ItemSlot.Body };
            int actualitemlevel = 1;
            checkValidMessage.EquipArmour(itemArmour, actualitemlevel);
            string actualMessage = checkValidMessage.validArmourMessage;


            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }
        //7) Calculate DPS if no weapon is equipped.
        //o Take warrior at level 1
        //o Expected DPS = 1*(1 + (5 / 100))
        //8) Calculate DPS with valid weapon equipped.
        //o Take warrior level 1.
        //o Equip axe.
        //o Expected DPS = (7 * 1.1) * (1 + (5 / 100))
        //9) Calculate DPS with valid weapon and armor equipped.
        //o Take warrior level 1.
        //o Equip axe.
        //o Equip plate body armor.
        //o Expected DPS = (7 * 1.1) * (1 + ((5 + 1) / 100))

    }
}
