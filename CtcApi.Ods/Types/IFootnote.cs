﻿//Copyright (C) 2011 Bellevue College and Peninsula College
//
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU Lesser General Public License as
//published by the Free Software Foundation, either version 3 of the
//License, or (at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License and GNU General Public License along with this program.
//If not, see <http://www.gnu.org/licenses/>.
namespace Ctc.Ods.Types
{
    ///<summary>
    /// Contains additional information about the associated <see cref="ISection"/>
    ///</summary>
    /// <remarks>
    /// This is where information such as pre-requisites, fees, etc. can be found.
    /// </remarks>
    public interface IFootnote
    {
        /// <summary>
        /// Unique field that maps to FootNoteID in Class
        /// </summary>
        /// <remarks>
        /// This field looks like its filled with gibberish, but seems to be unique
        /// </remarks>
        string FootnoteId { get; set; }

        /// <summary>
        /// Footnote text
        /// </summary>
        string FootnoteText { get; set; }
        /// <summary>
        /// College Code ID
        /// </summary>
        string ColCode { get; set; }
    }
}