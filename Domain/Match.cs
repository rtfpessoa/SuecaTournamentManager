﻿/*
 * Sueca Tournament Manager - Simple Sueca tournament manager
 * Copyright (C) 2013  rtfpessoa
 *
 * Sueca Tournament Manager is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Sueca Tournament Manager is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Sueca Tournament Manager.  If not, see <http://www.gnu.org/licenses/>.
 *
 */

using System;
using System.Collections.Generic;

namespace SuecaTournamentManager.Domain
{
    /// <summary>
    /// Description of Match.
    /// </summary>
    public class Match
    {
        public Match()
        {
        }

        public virtual int Id { get; set; }
        public virtual Result Result1 { get; set; }
        public virtual Result Result2 { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual Tournament Tournament { get; set; }

        public override string ToString()
        {
            return Phase + " => " + Team1 + " x " + Team2;
        }
    }
}
