﻿/*************************************************************************
 *     This file & class is part of the MIConvexHull Library Project. 
 *     Copyright 2006, 2008 Matthew Ira Campbell, PhD.
 *
 *     MIConvexHull is free software: you can redistribute it and/or modify
 *     it under the terms of the GNU General Public License as published by
 *     the Free Software Foundation, either version 3 of the License, or
 *     (at your option) any later version.
 *  
 *     MIConvexHull is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU General Public License for more details.
 *  
 *     You should have received a copy of the GNU General Public License
 *     along with MIConvexHull.  If not, see <http://www.gnu.org/licenses/>.
 *     
 *     Please find further details and contact information on GraphSynth
 *     at http://miconvexhull.codeplex.com
 *************************************************************************/
namespace MIConvexHull
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// functions called from Find for the 2D case. 
    /// </summary>
    public static partial class ConvexHull
    {
        /// <summary>
        /// A quick cross-product of 2-D vectors. The result can be a single double since it
        /// is just the value in the z-direction.
        /// </summary>
        /// <param name="aX">X-component of the A vector.</param>
        /// <param name="aY">Y-component of the A vector..</param>
        /// <param name="bX">X-component of the B vector.</param>
        /// <param name="bY">Y-component of the B vector.</param>
        /// <returns></returns>
        private static double crossProduct(double aX, double aY, double bX, double bY)
        {
            return (aX * bY - bX * aY);
        }
        /// <summary>
        /// The "positionAlong" is the orthogonal distance to "signedDistance". Instead of
        /// being perpendicular to the line, it is parallel. While it can be both positive
        /// and negative, only positive values should be created by the arguments. 
        /// </summary>
        /// <param name="aX">X-component of the A vector.</param>
        /// <param name="aY">Y-component of the A vector..</param>
        /// <param name="bX">X-component of the B vector.</param>
        /// <param name="bY">Y-component of the B vector.</param>
        /// <param name="aMag">magnitude of A vector.</param>
        /// <returns></returns>
        private static double dotProduct(double aX, double aY, double bX, double bY)
        {
            return (aX * bX + aY * bY);
        }
    }
}