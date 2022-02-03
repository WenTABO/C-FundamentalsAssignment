namespace ModuleAsignment_RPGcharacters.RPGcharacters.Item
{
    public interface IWeapon
    {
        public WeaponType WeaponType { get; set; }
        public ItemSlot Slot { get; set; }
    }
}