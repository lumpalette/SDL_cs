using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_rect.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_rect.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Determine whether a point resides inside a rectangle.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PointInRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="p">The point to test.</param>
	/// <param name="r">The rectangle to test.</param>
	/// <returns>True if <paramref name="p"/> is contained by <paramref name="r"/>, false otherwise.</returns>
	public static bool PointInRect(in SDL_Point p, in SDL_Rect r)
	{
		return (p.X >= r.X) && (p.X < (r.X + r.Width)) && (p.Y >= r.Y) && (p.Y < (r.Y + r.Height));
	}

	/// <summary>
	/// Determine whether a point resides inside a floating point rectangle.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PointInRectFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="p">The point to test.</param>
	/// <param name="r">The rectangle to test.</param>
	/// <returns>True if <paramref name="p"/> is contained by <paramref name="r"/>, false otherwise.</returns>
	public static bool PointInRectFloat(in SDL_FPoint p, in SDL_FRect r)
	{
		return (p.X >= r.X) && (p.X <= (r.X + r.Width)) && (p.Y >= r.Y) && (p.Y <= (r.Y + r.Height));
	}

	/// <summary>
	/// Determine whether a rectangle has no area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectEmpty">documentation</see>
	/// for more details.
	/// </remarks>
	/// <param name="r">The rectangle to test.</param>
	/// <returns>True if the rectangle is "empty" (has zero or negative area), false otherwise.</returns>
	public static bool RectEmpty(in SDL_Rect r)
	{
		return (r.Width <= 0) && (r.Height <= 0);
	}

	/// <summary>
	/// Determine whether a floating point rectangle has no area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectEmptyFloat">documentation</see>
	/// for more details.
	/// </remarks>
	/// <param name="r">The rectangle to test.</param>
	/// <returns>True if the rectangle is "empty", false otherwise.</returns>
	public static bool RectEmptyFloat(in SDL_FRect r)
	{
		return (r.Width < 0f) && (r.Height < 0f);
	}

	/// <summary>
	/// Determine whether two rectangles are equal.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectsEqual">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first rectangle to test.</param>
	/// <param name="b">The second rectangle to test.</param>
	/// <returns>True if the rectangles are equal, false otherwise.</returns>
	public static bool RectsEqual(in SDL_Rect a, in SDL_Rect b)
	{
		return (a.X == b.X) && (a.Y == b.Y) && (a.Width == b.Width) && (a.Height == b.Height);
	}

	/// <summary>
	/// Determine whether two floating point rectangles are equal, within a default epsilon.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectsEqualFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first rectangle to test.</param>
	/// <param name="b">The second rectangle to test.</param>
	/// <returns>True if the rectangles are equal, false otherwise.</returns>
	public static bool RectsEqualFloat(in SDL_FRect a, in SDL_FRect b)
	{
		return RectsEqualEpsilon(a, b, FloatEpsilon);
	}

	/// <summary>
	/// Determine whether two floating point rectangles are equal, within some given epsilon.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectsEqualEpsilon">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first rectangle to test.</param>
	/// <param name="b">The second rectangle to test.</param>
	/// <param name="epsilon">The epsilon value for comparison. Defaults to <see cref="FloatEpsilon"/>.</param>
	/// <returns>True if the rectangles are equal, false otherwise.</returns>
	public static bool RectsEqualEpsilon(in SDL_FRect a, in SDL_FRect b, float epsilon = FloatEpsilon)
	{
		return (Math.Abs(a.X - b.X) <= epsilon) && (Math.Abs(a.Y - b.Y) <= epsilon)
			&& (Math.Abs(a.Width - b.Width) <= epsilon) && (Math.Abs(a.Height - b.Height) <= epsilon);
	}

	/// <summary>
	/// Determine whether two rectangles intersect.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasRectIntersection">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_Rect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_Rect"/> structure representing the second rectangle.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasRectIntersection")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasRectIntersection(in SDL_Rect a, in SDL_Rect b);

	/// <summary>
	/// Determine whether two rectangles intersect with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasRectIntersectionFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_FRect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_FRect"/> structure representing the second rectangle.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasRectIntersectionFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasRectIntersectionFloat(in SDL_FRect a, in SDL_FRect b);

	/// <summary>
	/// Calculate the intersection of two rectangles.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectIntersection">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_Rect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_Rect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the intersection of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectIntersection")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectIntersection(in SDL_Rect a, in SDL_Rect b, out SDL_Rect result);

	/// <summary>
	/// Calculate the intersection of two rectangles with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectIntersectionFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_FRect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_FRect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_FRect"/> structure filled in with the intersection of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectIntersectionFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectIntersectionFloat(in SDL_FRect a, in SDL_FRect b, out SDL_FRect result);

	/// <summary>
	/// Calculate the union of two rectangles.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectUnion">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_Rect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_Rect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the union of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnion", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetRectUnion(in SDL_Rect a, in SDL_Rect b, out SDL_Rect result);

	/// <summary>
	/// Calculate the union of two rectangles with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectUnionFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_FRect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_FRect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_FRect"/> structure filled in with the union of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnionFloat", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetRectUnionFloat(in SDL_FRect a, in SDL_FRect b, out SDL_FRect result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPoints">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_Point"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array. Corresponds to <paramref name="points"/>.Length.</param>
	/// <param name="clip">An <see cref="SDL_Rect"/> used for clipping or <see cref="nint.Zero"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPoints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPoints([In] SDL_Point[] points, int count, in SDL_Rect clip, out SDL_Rect result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPoints">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_Point"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array. Corresponds to <paramref name="points"/>.Length.</param>
	/// <param name="clip">An <see cref="SDL_Rect"/> used for clipping or <see cref="nint.Zero"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPoints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPoints([In] SDL_Point[] points, int count, nint clip, out SDL_Rect result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPointsFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_FPoint"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array. Corresponds to <paramref name="points"/>.Length.</param>
	/// <param name="clip">An <see cref="SDL_FRect"/> used for clipping or <see cref="nint.Zero"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPointsFloat([In] SDL_FPoint[] points, int count, in SDL_FRect clip, out SDL_FRect result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPointsFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_FPoint"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array. Corresponds to <paramref name="points"/>.Length.</param>
	/// <param name="clip">An <see cref="SDL_FRect"/> used for clipping or <see cref="nint.Zero"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPointsFloat([In] SDL_FPoint[] points, int count, nint clip, out SDL_FRect result);

	/// <summary>
	/// Calculate the intersection of a rectangle and line segment.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectAndLineIntersection">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the rectangle to intersect.</param>
	/// <param name="x1">A pointer to the starting X-coordinate of the line.</param>
	/// <param name="y1">A pointer to the starting Y-coordinate of the line.</param>
	/// <param name="x2">A pointer to the ending X-coordinate of the line.</param>
	/// <param name="y2">A pointer to the ending Y-coordinate of the line.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersection")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectAndLineIntersection(in SDL_Rect rect, ref int x1, ref int y1, ref int x2, ref int y2);

	/// <summary>
	/// Calculate the intersection of a rectangle and line segment with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectAndLineIntersectionFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect">An <see cref="SDL_FRect"/> structure representing the rectangle to intersect.</param>
	/// <param name="x1">A pointer to the starting X-coordinate of the line.</param>
	/// <param name="y1">A pointer to the starting Y-coordinate of the line.</param>
	/// <param name="x2">A pointer to the ending X-coordinate of the line.</param>
	/// <param name="y2">A pointer to the ending Y-coordinate of the line.</param>
	/// <returns>True if there is an intersection, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersection")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectAndLineIntersectionFloat(in SDL_FRect rect, ref float x1, ref float y1, ref float x2, ref float y2);
}