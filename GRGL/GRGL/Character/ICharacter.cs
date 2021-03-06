﻿// ICharacter.cs
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
using Grgl.Global;
using Grgl.Item;
using Grgl.Other;
using Grgl.World;

namespace Grgl.Character
{

    /// <summary>
    /// Represents a character in the game
    /// </summary>
    public interface ICharacter : IGameObject
    {

        #region Properties

        /// <summary>
        /// Represents the player's position in the world.
        /// </summary>
        ILocation Position { get; }

        /// <summary>
        /// Represents the character's item inventory
        /// </summary>
        IInventory Inventory { get; }

        /// <summary>
        /// Represents the character's current action state(s)
        /// </summary>
        ICollection<CharacterStateType> CharacterStates { get; }

        /// <summary>
        /// A collection that represents the wearable items this character has equipped
        /// </summary>
        IDictionary<WearableEquipSlotType, IWearable> WearableEquipSlots { get;}

        /// <summary>
        /// A collection that represents the weapons this character has equipped
        /// </summary>
        IDictionary<WeaponEquipSlotType, IWeapon> WeaponEquipSlots { get; }

        /// <summary>
        /// A collection that holds values representing this character's numeric traits/stats
        /// </summary>
        IDictionary<string, float> NumericTraits { get;}
        
        /// <summary>
        /// A collection that holds character resources
        /// </summary>
        IDictionary<string, ICharacterResource> Resources { get; }

        /// <summary>
        /// Bracket operator overload for easily retrieving stat/resource values.
        /// </summary>
        /// <param name="s">String identifier for stat/resource</param>
        /// <returns>The current value of the stat/resource</returns>
        float this[string s] { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Equips an item on this character, if possible
        /// </summary>
        /// <param name="equippableItem">Item to be equipped</param>
        /// <returns>Returns false if item cannot be equipped</returns>
        bool Equip(IEquippable equippableItem);
        
        /// <summary>
        /// Item is used by this character, if possible
        /// </summary>
        /// <param name="usableItem">Item to be used</param>
        /// <returns>Returns false if the item cannot be used</returns>
        bool Use(IUsable usableItem);


        /// <summary>
        /// This character starts a conversation with an NPC
        /// </summary>
        /// <param name="otherCharacter">The NPC that this character is to converse with</param>
        /// <returns>The NPC's dialog tree</returns>
        IDialogTree Talk(INpc otherCharacter);

        #endregion
    }
}