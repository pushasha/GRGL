// IQuestStage.cs
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
    /// Represents a stage in a quest.
    /// </summary>
    public interface IQuestStage : IGameObject
    {

        /// <summary>
        /// Flag representing whether this stage has been completed or not
        /// </summary>
        bool IsComplete { get; set; }

        /// <summary>
        /// Flag representing whether the completion of this stage should complete the entire parent quest
        /// </summary>
        bool IsEndStage { get; }

        /// <summary>
        /// The stage with which this quest was completed, if applicable
        /// </summary>
        string CompletedWithStage { get; set; }

        /// <summary>
        /// List of the unique identifiers for the quest stages that follow this stage.
        /// </summary>
        IList<string> ChildStages { get;} 
    }
}