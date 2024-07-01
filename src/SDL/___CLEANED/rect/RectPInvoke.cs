using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasRectIntersection(SDL_Rect* a, SDL_Rect* b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasRectIntersectionFloat(SDL_FRect* a, SDL_FRect* b);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectIntersection(SDL_Rect* a, SDL_Rect* b, SDL_Rect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectIntersectionFloat(SDL_FRect* a, SDL_FRect* b, SDL_FRect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectUnion(SDL_Rect* a, SDL_Rect* b, SDL_Rect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectUnionFloat(SDL_FRect* a, SDL_FRect* b, SDL_FRect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectEnclosingPoints(SDL_Point* points, int count, SDL_Rect* clip, SDL_Rect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectEnclosingPointsFloat(SDL_FPoint* points, int count, SDL_FRect* clip, SDL_FRect* result);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectAndLineIntersection(SDL_Rect* rect, int* x1, int* y1, int* x2, int* y2);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetRectAndLineIntersectionFloat(SDL_FRect* rect, float* x1, float* y1, float* x2, float* y2);
}