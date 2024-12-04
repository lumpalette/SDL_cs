using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_rect.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_rect.h.
namespace SDL3;

/// <summary>
/// The structure that defines a point (using integers).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Point">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate.</param>
/// <param name="y">The y coordinate.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Point(int x, int y)
{
	/// <summary>
	/// The x coordinate of this point.
	/// </summary>
	public int X = x;

	/// <summary>
	/// The y coordinate of this point.
	/// </summary>
	public int Y = y;
}

/// <summary>
/// The structure that defines a point (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FPoint">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate.</param>
/// <param name="y">The y coordinate.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FPoint(float x, float y)
{
	/// <summary>
	/// The x coordinate of this point.
	/// </summary>
	public float X = x;

	/// <summary>
	/// The y coordinate of this point.
	/// </summary>
	public float Y = y;
}

/// <summary>
/// A rectangle, with the origin at the upper (left using integers).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Rect">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate of the origin.</param>
/// <param name="y">The y coordinate of the origin.</param>
/// <param name="width">The width of this rectangle.</param>
/// <param name="height">The height of this rectangle.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Rect(int x, int y, int width, int height)
{
	/// <summary>
	/// The x coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public int X = x;

	/// <summary>
	/// The y coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public int Y = y;

	/// <summary>
	/// The width of this rectangle.
	/// </summary>
	public int Width = width;

	/// <summary>
	/// The height of this rectangle.
	/// </summary>
	public int Height = height;
}

/// <summary>
/// A rectangle, with the origin at the upper left (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FRect">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate of the origin.</param>
/// <param name="y">The y coordinate of the origin.</param>
/// <param name="width">The width of this rectangle.</param>
/// <param name="height">The height of this rectangle.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FRect(float x, float y, float width, float height)
{
	/// <summary>
	/// The x coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public float X = x;

	/// <summary>
	/// The y coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public float Y = y;

	/// <summary>
	/// The width of this rectangle.
	/// </summary>
	public float Width = width;

	/// <summary>
	/// The height of this rectangle.
	/// </summary>
	public float Height = height;
}

unsafe partial class SDL
{
	/// <summary>
	/// Convert an <see cref="SDL_Rect"/> to <see cref="SDL_FRect"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectToFRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect">A pointer to an <see cref="SDL_Rect"/>.</param>
	/// <param name="frect">A pointer filled in with the floating point representation of <paramref name="rect"/>.</param>
	public static void RectToFRect([Const] SDL_Rect* rect, SDL_FRect* frect)
	{
		frect->X = rect->X;
		frect->Y = rect->Y;
		frect->Width = rect->Width;
		frect->Height = rect->Height;
	}

	/// <summary>
	/// Determine whether a point resides inside a rectangle.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PointInRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="p">The point to test.</param>
	/// <param name="r">The rectangle to test.</param>
	/// <returns>True if <paramref name="p"/> is contained by <paramref name="r"/>, false otherwise.</returns>
	public static bool PointInRect([Const] SDL_Point* p, [Const] SDL_Rect* r)
	{
		return (p is not null) && (r is not null) && (p->X >= r->X) && (p->X < (r->X + r->Width)) && (p->Y >= r->Y) && (p->Y < (r->Y + r->Height));
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
	public static bool RectEmpty([Const] SDL_Rect* r)
	{
		return (r is null) || (r->Width <= 0) || (r->Height <= 0);
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
	public static bool RectsEqual([Const] SDL_Rect* a, [Const] SDL_Rect* b)
	{
		return (a is not null) && (b is not null) && (a->X == b->X) && (a->Y == b->Y) && (a->Width == b->Width) && (a->Height == b->Height);
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
	public static partial bool HasRectIntersection([Const] SDL_Rect* a, [Const] SDL_Rect* b);

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
	public static partial bool GetRectIntersection([Const] SDL_Rect* a, [Const] SDL_Rect* b, SDL_Rect* result);

	/// <summary>
	/// Calculate the union of two rectangles.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectUnion">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_Rect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_Rect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the union of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnion", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectUnion([Const] SDL_Rect* a, [Const] SDL_Rect* b, SDL_Rect* result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPoints">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_Point"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array.</param>
	/// <param name="clip">An <see cref="SDL_Rect"/> used for clipping or <see langword="null"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPoints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPoints([Const] SDL_Point* points, int count, [Const] SDL_Rect* clip, SDL_Rect result);

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
	public static partial bool GetRectAndLineIntersection([Const] SDL_Rect* rect, int* x1, int* y1, int* x2, int* y2);

	/// <summary>
	/// Convert an <see cref="SDL_FRect"/> to <see cref="SDL_Rect"/>.
	/// </summary>
	/// <param name="rect">A pointer to an <see cref="SDL_FRect"/>.</param>
	/// <param name="frect">A pointer filled in with the integer representation of <paramref name="frect"/>.</param>
	public static void FRectToRect([Const] SDL_FRect* frect, SDL_Rect* rect)
	{
		rect->X = (int)frect->X;
		rect->Y = (int)frect->Y;
		rect->Width = (int)frect->Width;
		rect->Height = (int)frect->Height;
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
	public static bool PointInRectFloat([Const] SDL_FPoint* p, [Const] SDL_FRect* r)
	{
		return (p is not null) && (r is not null) && (p->X >= r->X) && (p->X <= (r->X + r->Width)) && (p->Y >= r->Y) && (p->Y <= (r->Y + r->Height));
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
	public static bool RectEmptyFloat([Const] SDL_FRect* r)
	{
		return (r is null) || (r->Width < 0f) || (r->Height < 0f);
	}

	/// <summary>
	/// Determine whether two floating point rectangles are equal, within some given epsilon.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectsEqualEpsilon">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first rectangle to test.</param>
	/// <param name="b">The second rectangle to test.</param>
	/// <param name="epsilon">The epsilon value for comparison..</param>
	/// <returns>True if the rectangles are equal, false otherwise.</returns>
	public static bool RectsEqualEpsilon([Const] SDL_FRect* a, [Const] SDL_FRect* b, float epsilon)
	{
		return (a is not null) && (b is not null) && ((a == b) ||
			((Math.Abs(a->X - b->X) <= epsilon) &&
			(Math.Abs(a->Y - b->Y) <= epsilon) &&
			(Math.Abs(a->Width - b->Width) <= epsilon) &&
			(Math.Abs(a->Height - b->Height) <= epsilon)));
	}

	/// <summary>
	/// Determine whether two floating point rectangles are equal, within a default epsilon (<see cref="SDL.FloatEpsilon"/>).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RectsEqualFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first rectangle to test.</param>
	/// <param name="b">The second rectangle to test.</param>
	/// <returns>True if the rectangles are equal, false otherwise.</returns>
	public static bool RectsEqualFloat([Const] SDL_FRect* a, [Const] SDL_FRect* b)
	{
		return RectsEqualEpsilon(a, b, FloatEpsilon);
	}

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
	public static partial bool HasRectIntersectionFloat([Const] SDL_FRect* a, [Const] SDL_FRect* b);
	
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
	public static partial bool GetRectIntersectionFloat([Const] SDL_FRect* a, [Const] SDL_FRect* b, SDL_FRect* result);

	/// <summary>
	/// Calculate the union of two rectangles with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectUnionFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">An <see cref="SDL_FRect"/> structure representing the first rectangle.</param>
	/// <param name="b">An <see cref="SDL_FRect"/> structure representing the second rectangle.</param>
	/// <param name="result">An <see cref="SDL_FRect"/> structure filled in with the union of rectangles <paramref name="a"/> and <paramref name="b"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnionFloat", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectUnionFloat([Const] SDL_FRect* a, [Const] SDL_FRect* b, SDL_FRect* result);

	/// <summary>
	/// Calculate a minimal rectangle enclosing a set of points with float precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRectEnclosingPointsFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="points">An array of <see cref="SDL_FPoint"/> structures representing points to be enclosed.</param>
	/// <param name="count">The number of structures in the <paramref name="points"/> array. Corresponds to <paramref name="points"/>.Length.</param>
	/// <param name="clip">An <see cref="SDL_FRect"/> used for clipping or <see langword="null"/> to enclose all points.</param>
	/// <param name="result">An <see cref="SDL_Rect"/> structure filled in with the minimal enclosing rectangle.</param>
	/// <returns>True if any points were enclosed or false if all the points were outside of the clipping rectangle.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRectEnclosingPointsFloat([Const] SDL_FPoint* points, int count, [Const] SDL_FRect* clip, SDL_FRect* result);

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
	public static partial bool GetRectAndLineIntersectionFloat([Const] SDL_FRect* rect, float* x1, float* y1, float* x2, float* y2);
}