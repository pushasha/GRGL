// IQuest.cs
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
using Grgl.Global;

namespace Grgl.Quest
{
    /// <summary>
    /// Represents a quest for the player character.
    /// </summary>
    public interface IQuest : IGameObject
    {
        /// <summary>
        /// Flag representing whether this quest has been completed or not.
        /// </summary>
        bool IsComplete { get; set; }

        /// <summary>
        /// The stage at which this quest begins
        /// </summary>
        string StartStage { get; }

        /// <summary>
        /// A collection of stages that comprise this quest
        /// </summary>
        IDictionary<string, IQuestStage> Stages { get; }
    }
}