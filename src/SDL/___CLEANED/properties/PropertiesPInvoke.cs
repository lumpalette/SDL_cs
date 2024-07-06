using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertiesId SDL_GetGlobalProperties();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertiesId SDL_CreateProperties();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_CopyProperties(SDL_PropertiesId src, SDL_PropertiesId dst);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_LockProperties(SDL_PropertiesId props);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UnlockProperties(SDL_PropertiesId props);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetPropertyWithCleanup(SDL_PropertiesId props, byte* name, void* value, SDL_CleanupPropertyCallback cleanup, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetProperty(SDL_PropertiesId props, byte* name, void* value);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetStringProperty(SDL_PropertiesId props, byte* name, byte* value);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetNumberProperty(SDL_PropertiesId props, byte* name, long value);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetFloatProperty(SDL_PropertiesId props, byte* name, float value);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetBooleanProperty(SDL_PropertiesId props, byte* name, int value);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasProperty(SDL_PropertiesId props, byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertyType SDL_GetPropertyType(SDL_PropertiesId props, byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void* SDL_GetProperty(SDL_PropertiesId props, byte* name, void* defaultValue);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetStringProperty(SDL_PropertiesId props, byte* name, byte* defaultValue);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern long SDL_GetNumberProperty(SDL_PropertiesId props, byte* name, long defaultValue);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern float SDL_GetFloatProperty(SDL_PropertiesId props, byte* name, float defaultValue);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetBooleanProperty(SDL_PropertiesId props, byte* name, int defaultValue);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ClearProperty(SDL_PropertiesId props, byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_EnumerateProperties(SDL_PropertiesId props, SDL_EnumeratePropertiesCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DestroyProperties(SDL_PropertiesId props);
}