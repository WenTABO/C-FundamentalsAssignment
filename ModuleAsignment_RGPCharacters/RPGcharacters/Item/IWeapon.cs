namespace ModuleAsignment_RPGcharacters.RPGcharacters.Item
{
    public interface IWeapon
    {
        public WeaponType weaponType { get; set; }
        public ItemSlot Slot { get; set; }
    }
}