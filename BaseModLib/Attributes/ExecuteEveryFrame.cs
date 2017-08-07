﻿/*  
 *  ModAPI
 *  Copyright (C) 2015 FluffyFish / Philipp Mohrenstecher
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *  
 *  To contact me you can e-mail me at info@fluffyfish.de
 */

using System;

namespace ModAPI.Attributes
{
    /// <summary>
    /// This attribute marks a method to be executed every frame. First parameter defines if this method should only be called while in-game. [static methods only]
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class ExecuteEveryFrame : ConfigurationAttribute, IStaticAttribute, INoParametersAttribute
    {
        protected bool OnlyInGame;

        public ExecuteEveryFrame(bool OnlyInGame = true)
        {
            this.OnlyInGame = OnlyInGame;
        }
    }
}
