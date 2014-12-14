// EquipSlotType.cs
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

namespace Grgl.Other
{
    /// <summary>
    /// Wearable Item Slot Type Enumerators
    /// </summary>
    public enum WearableEquipSlotType
    {

        /// <summary>
        /// Head Slot (e.g. Helm, Cap)
        /// </summary>
        Head,
        /// <summary>
        /// Chest Slot (e.g. Breastplate, Cuirass, Shirt)
        /// </summary>
        Chest,
        /// <summary>
        /// Torso Slot (for armor types that include legs and chest)
        /// </summary>
        Torso,
        /// <summary>
        /// Shoulder Slot (e.g. Pauldrons, Spaulders)
        /// </summary>
        Shoulders,
        /// <summary>
        /// Hands Slot (e.g. Gloves, Gauntlets)
        /// </summary>
        Hands,
        /// <summary>
        /// Legs Slot (e.g. Greaves, Leggings)
        /// </summary>
        Legs,
        /// <summary>
        /// Feet Slot (e.g. Boots, Sabatons)
        /// </summary>
        Feet,
        /// <summary>
        /// Belt Slot (e.g. Belt, Sash)
        /// </summary>
        Belt,
        /// <summary>
        /// Neck Slot (e.g. Amulet, Scarf)
        /// </summary>
        Neck,
        /// <summary>
        /// Left Finger Slot (for rings)
        /// </summary>
        LeftFinger,
        /// <summary>
        /// Right Finger Slot (for rings)
        /// </summary>
        RightFinger,
        /// <summary>
        /// Accessory Slot (e.g. Relic, Charm)
        /// </summary>
        Accessory,
        /// <summary>
        /// Other Wearable Slot (for a wearable not covered by previously listed enumerators)
        /// </summary>
        OtherWearable
    }

    /// <summary>
    /// Weapon Slot Type Enumerators
    /// </summary>
    public enum WeaponEquipSlotType
    {
        /// <summary>
        /// Primary Weapon Slot (e.g. Longsword, Main Dagger, Greatsword, Wand)
        /// </summary>
        Primary,
        /// <summary>
        /// Secondary Weapon Slot (e.g. Off-hand Dagger, Shield, Focus)
        /// </summary>
        Secondary,
        /// <summary>
        /// Ammo Slot (e.g. Quiver)
        /// </summary>
        Ammo,
        /// <summary>
        /// Other Weapon Slot (Throwing Knives, Darts, Bombs)
        /// </summary>
        OtherWeapon
    }
}