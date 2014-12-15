// Character.cs
// (c) Copyright Sarah Plotkin (splotkin@gmail.com)
// 
// This file is part of GRGL.
// GRGL is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// GRGL is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with GRGL.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using Grgl.Dialog;
using Grgl.Item;
using Grgl.Other;
using Grgl.World;

namespace Grgl.Character
{
    /// <inheritdoc cref="ICharacter" />
    public class Character : ICharacter
    {
        ///  <inheritdoc />
        public Character()
        {
            this.Inventory = new Inventory();
            this.CharacterStates = new List<CharacterStateType>();
            this.Position = new Location("MajorExteriorLoc01", 0, 0, 0);
            this.InitCollections();
        }

        ///  <inheritdoc />
        public Character(string name, string refId) : this()
        {
            this.Name = name;
            this.RefId = refId;
        }


        #region Properties
        ///  <inheritdoc />
        public string Name
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public string RefId
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public ILocation Position
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IInventory Inventory
        {
            get; protected set;
        }
        ///  <inheritdoc />
        public ICollection<CharacterStateType> CharacterStates
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IDictionary<WearableEquipSlotType, IWearable> WearableEquipSlots
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IDictionary<WeaponEquipSlotType, IWeapon> WeaponEquipSlots
        {
            get; protected set;
        }
        ///  <inheritdoc />
        public IDictionary<string, ICharacterTrait> Traits
        {
            get; protected set;
        }


        public IDictionary<string, ICharacterResource> Resources
        {
            get;
            protected set;
        }

        #endregion

        #region Methods
        ///  <inheritdoc />
        public bool Equip(IEquippable equippableItem)
        {
            if (equippableItem is IWeapon)
            {
                IWeapon weaponEquip = equippableItem as IWeapon;
                this.WeaponEquipSlots[weaponEquip.EquipSlotType] = weaponEquip; 
            }
            else if (equippableItem is IWearable)
            {
                IWearable wearableEquip = equippableItem as IWearable;
                this.WearableEquipSlots[wearableEquip.EquipSlotType] = wearableEquip;
            }
            else // if cannot be equipped
            {
                return false;
            }

            return true;
        }
        ///  <inheritdoc />
        public bool Use(IUsable usableItem)
        {
            throw new System.NotImplementedException();
        }
        ///  <inheritdoc />
        public IDialogTree Talk(INpc otherCharacter)
        {
            return otherCharacter.DialogTree;
        }

        private void InitCollections()
        {
            // initialize traits
            this.Traits = new Dictionary<string, ICharacterTrait>();
            this.Resources = new Dictionary<string, ICharacterResource>(){
                {"Health", new CharacterResource(250)},
                {"Mana", new CharacterResource(100)}
            };

            // initialize equip slots
            this.WearableEquipSlots = new Dictionary<WearableEquipSlotType, IWearable>(){
                { WearableEquipSlotType.Chest, null },
                { WearableEquipSlotType.Legs, null },
                { WearableEquipSlotType.Feet, null },
                { WearableEquipSlotType.Hands, null },
                { WearableEquipSlotType.Head, null }
            };

            this.WeaponEquipSlots = new Dictionary<WeaponEquipSlotType, IWeapon>() { 
                { WeaponEquipSlotType.Primary, null },
                { WeaponEquipSlotType.Secondary, null }
            };
        }
        


        #endregion
    }
}
