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

using System;
using System.Collections.Generic;
using Grgl.Interfaces.Character;
using Grgl.Interfaces.Dialog;
using Grgl.Interfaces.World;
using Grgl.Interfaces.Item;
using Grgl.Concrete.Item;
using Grgl.Other;

namespace Grgl.Concrete.Character
{
    public class Character : ICharacter
    {


        public Character()
        {
            this.Inventory = new Inventory();
            this.CharacterStates = new List<CharacterStateType>();
            this.InitCollections();
        }

        public Character(string name, string refId) : this()
        {
            this.Name = name;
            this.RefId = refId;
            this.BaseId = refId; // TODO: re-factor whether this takes refid and baseid, or just one
        }


        #region Properties

        public string Name
        {
            get;
            set;
        }

        public string BaseId
        {
            get;
            set;
        }

        public string RefId
        {
            get;
            set;
        }

        public IPosition Position
        {
            get;
            set;
        }

        public IInventory Inventory
        {
            get; set;
        }

        public ICollection<CharacterStateType> CharacterStates
        {
            get;
            private set;
        }

        public IDictionary<WearableEquipSlotType, IWearable> WearableEquipSlots
        {
            get;
            private set;
        }

        public IDictionary<WeaponEquipSlotType, IWeapon> WeaponEquipSlots
        {
            get; private set;
        }

        public IDictionary<string, ICharacterTrait> Traits
        {
            get; private set;
        }

        #endregion

        #region Methods

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

        public bool Use(IUsable usableItem)
        {
            throw new NotImplementedException();
        }

        public IDialogTree Talk(INpc otherCharacter)
        {
            //throw new NotImplementedException();
            Console.WriteLine(">> (" + this.Name + " is talking to " + otherCharacter.Name + ")");
            return otherCharacter.DialogTree;
        }

        private void InitCollections()
        {
            // initialize traits
            this.Traits = new Dictionary<string, ICharacterTrait>();

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
