﻿// CharacterStateType.cs
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
    /// Character State Type Enumerators
    /// </summary>
    public enum CharacterStateType
    {
        /// <summary>
        /// Character is in a conversation
        /// </summary>
        Dialog,
        
        /// <summary>
        /// Character is in combat
        /// </summary>
        Combat,
        
        /// <summary>
        /// Character is sleeping
        /// </summary>
        Sleep,
        
        /// <summary>
        /// Character is disabled
        /// </summary>
        Disabled
    }
}