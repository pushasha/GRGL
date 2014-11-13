// ICharacter.cs
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
using Grgl.Interfaces.Global;
using Grgl.Interfaces.Item;
using Grgl.Interfaces.World;
using Grgl.Other;

namespace Grgl.Interfaces.Character
{
    public interface ICharacter : IGameObject
    {

        #region Properties

        /// <summary>
        /// Represents the player's position in the world.
        /// </summary>
        IPosition Position { get; set; }

        /// <summary>
        /// Represents the character's item inventory
        /// </summary>
        IInventory Inventory { get; }

        /// <summary>
        /// A collection that represents the wearable items this character has equipped
        /// </summary>
        IDictionary<WearableEquipSlotType, IWearable> WearableEquipSlots { get; set; }

        /// <summary>
        /// A collection that represents the weapons this character has equipped
        /// </summary>
        IDictionary<WeaponEquipSlotType, IWeapon> WeaponEquipSlots { get; set; }

        /// <summary>
        /// A collection that holds values representing this character's various traits
        /// </summary>
        IDictionary<string, ICharacterTrait> Traits { get; }

        #endregion

        #region Methods

        bool Equip(IEquippable equippableItem);
        bool Use(IUsable usableItem);

        #endregion
    }
}