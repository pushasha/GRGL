// IQuestLog.cs
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

namespace Grgl.Quest
{
    /// <summary>
    /// Represents the player character's collection of acquired quests.
    /// </summary>
    public interface IQuestLog
    {
        /// <summary>
        /// A collection that represents the quests in this quest log
        /// </summary>
        IDictionary<string, IQuest> Quests { get; }

        /// <summary>
        /// A list of this quest log's incomplete quest RefIds
        /// </summary>
        IList<string> IncompleteQuestsList { get; }

        /// <summary>
        /// A list of this quest log's completed quest RefIds
        /// </summary>
        IList<string> CompleteQuestsList { get; }

        /// <summary>
        /// Method that adds a quest to this quest log.
        /// </summary>
        /// <param name="questArg">The quest to be added</param>
        /// <returns>False if quest cannot be added; True if successfully added.</returns>
        bool AddQuest(IQuest questArg);

        /// <summary>
        /// Method that completes a quest with the given RefId
        /// </summary>
        /// <param name="idArg">RefId of the completed quest</param>
        /// <returns>False if quest cannot be completed; True if completion successful.</returns>
        bool CompleteQuest(string idArg);
    }
}