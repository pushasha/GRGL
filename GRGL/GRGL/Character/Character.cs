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
            // initialize traits
            this.NumericTraits = new Dictionary<string, float>();
            this.Resources = new Dictionary<string, ICharacterResource>();

            // initialize equip slots
            this.WearableEquipSlots = new Dictionary<WearableEquipSlotType, IWearable>();
            this.WeaponEquipSlots = new Dictionary<WeaponEquipSlotType, IWeapon>();
            this.Position = new Location();
        }

        /// <summary>
        /// Creates a new instance of a Character object
        /// </summary>
        /// <param name="name">Human-readable name of the Character</param>
        /// <param name="refId">RefId for this character</param>
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
        public IDictionary<string, float> NumericTraits
        {
            get; protected set;
        }

        ///  <inheritdoc />
        public IDictionary<string, ICharacterResource> Resources
        {
            get;
            protected set;
        }

        ///  <inheritdoc />
        public float this[string s]
        {
            get
            {
                if (this.Resources.ContainsKey(s))
                {
                    return this.Resources[s].CurrentValue;
                }

                return this.NumericTraits.ContainsKey(s) ? this.NumericTraits[s] : 0;
            }

            set
            {
                if (this.Resources.ContainsKey(s))
                {
                    this.Resources[s].CurrentValue = value >= this.Resources[s].MaxValue ? this.Resources[s].MaxValue : value;  
                }
                else if (this.NumericTraits.ContainsKey(s))
                {
                    this.NumericTraits[s] = value;
                }
                else
                {
                    throw new Exception("Could not set value - no key \"" + s + "\" found.");
                }
            }
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

        #endregion
    }
}
