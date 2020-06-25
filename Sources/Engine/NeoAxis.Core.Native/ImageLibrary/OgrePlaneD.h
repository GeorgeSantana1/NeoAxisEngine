/*
-----------------------------------------------------------------------------
This source file is part of OGRE
    (Object-oriented Graphics Rendering Engine)
For the latest info, see http://www.ogre3d.org/

Copyright (c) 2000-2009 Torus Knot Software Ltd

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
-----------------------------------------------------------------------------
*/
// This file is based on material originally from:
// Geometric Tools, LLC
// Copyright (c) 1998-2010
// Distributed under the Boost Software License, Version 1.0.
// http://www.boost.org/LICENSE_1_0.txt
// http://www.geometrictools.com/License/Boost/LICENSE_1_0.txt


#ifndef __PlaneD_H__
#define __PlaneD_H__

#include "OgrePrerequisites.h"

#include "OgreVector3D.h"

namespace Ogre {

	/** \addtogroup Core
	*  @{
	*/
	/** \addtogroup Math
	*  @{
	*/
    /** Defines a plane in 3D space.
        @remarks
            A plane is defined in 3D space by the equation
            Ax + By + Cz + D = 0
        @par
            This equates to a vector (the normal of the plane, whose x, y
            and z components equate to the coefficients A, B and C
            respectively), and a constant (D) which is the distance along
            the normal you have to go to move the plane back to the origin.
     */
    class _OgreExport PlaneD
    {
    public:
        /** Default constructor - sets everything to 0.
        */
        PlaneD ();
        PlaneD (const PlaneD& rhs);
        /** Construct a plane through a normal, and a distance to move the plane along the normal.*/
        PlaneD (const Vector3D& rkNormal, double fConstant);
		/** Construct a plane using the 4 constants directly **/
		PlaneD (double a, double b, double c, double d);
        PlaneD (const Vector3D& rkNormal, const Vector3D& rkPoint);
        PlaneD (const Vector3D& rkPoint0, const Vector3D& rkPoint1,
            const Vector3D& rkPoint2);

        /** The "positive side" of the plane is the half space to which the
            plane normal points. The "negative side" is the other half
            space. The flag "no side" indicates the plane itself.
        */
        enum Side
        {
            NO_SIDE,
            POSITIVE_SIDE,
            NEGATIVE_SIDE,
            BOTH_SIDE
        };

        Side getSide (const Vector3D& rkPoint) const;

        /**
        Returns the side where the alignedBox is. The flag BOTH_SIDE indicates an intersecting box.
        One corner ON the plane is sufficient to consider the box and the plane intersecting.
        */
        Side getSide (const AxisAlignedBoxD& rkBox) const;

        /** Returns which side of the plane that the given box lies on.
            The box is defined as centre/half-size pairs for effectively.
        @param centre The centre of the box.
        @param halfSize The half-size of the box.
        @returns
            POSITIVE_SIDE if the box complete lies on the "positive side" of the plane,
            NEGATIVE_SIDE if the box complete lies on the "negative side" of the plane,
            and BOTH_SIDE if the box intersects the plane.
        */
        Side getSide (const Vector3D& centre, const Vector3D& halfSize) const;

        /** This is a pseudodistance. The sign of the return value is
            positive if the point is on the positive side of the plane,
            negative if the point is on the negative side, and zero if the
            point is on the plane.
            @par
            The absolute value of the return value is the true distance only
            when the plane normal is a unit length vector.
        */
        double getDistance (const Vector3D& rkPoint) const;

        /** Redefine this plane based on 3 points. */
        void redefine(const Vector3D& rkPoint0, const Vector3D& rkPoint1,
            const Vector3D& rkPoint2);

		/** Redefine this plane based on a normal and a point. */
		void redefine(const Vector3D& rkNormal, const Vector3D& rkPoint);

		/** Project a vector onto the plane. 
		@remarks This gives you the element of the input vector that is perpendicular 
			to the normal of the plane. You can get the element which is parallel
			to the normal of the plane by subtracting the result of this method
			from the original vector, since parallel + perpendicular = original.
		@param v The input vector
		*/
		Vector3D projectVector(const Vector3D& v) const;

        /** Normalises the plane.
            @remarks
                This method normalises the plane's normal and the length scale of d
                is as well.
            @note
                This function will not crash for zero-sized vectors, but there
                will be no changes made to their components.
            @returns The previous length of the plane's normal.
        */
        double normalise(void);

		Vector3D normal;
        double d;

        /// Comparison operator
        bool operator==(const PlaneD& rhs) const
        {
            return (rhs.d == d && rhs.normal == normal);
        }
        bool operator!=(const PlaneD& rhs) const
        {
            return (rhs.d != d || rhs.normal != normal);
        }

        _OgreExport friend std::ostream& operator<< (std::ostream& o, const PlaneD& p);
    };

    typedef vector<PlaneD> PlaneDList;
	/** @} */
	/** @} */

} // namespace Ogre

#endif
