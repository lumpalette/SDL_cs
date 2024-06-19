using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_properties.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_properties.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get the global SDL properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalProperties">here</see> for more details.
	/// </remarks>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetGlobalProperties()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke();
	}

	/// <summary>
	/// Create a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProperties">here</see> for more details.
	/// </remarks>
	/// <returns> An ID for a new set of properties, or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId CreateProperties()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_CreateProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke();
	}

	/// <summary>
	/// Copy a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CopyProperties">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The properties to copy. </param>
	/// <param name="dst"> The destionation properties. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int CopyProperties(SDL_PropertiesId src, SDL_PropertiesId dst)
	{
		return _PInvoke(src, dst);

		[DllImport(LibraryName, EntryPoint = "SDL_CopyProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId src, SDL_PropertiesId dst);
	}

	/// <summary>
	/// Lock a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LockProperties">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to lock. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockProperties(SDL_PropertiesId props)
	{
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_LockProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props);
	}

	/// <summary>
	/// Unlock a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockProperties">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to unlock. </param>
	public static void UnlockProperties(SDL_PropertiesId props)
	{
		_PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_PropertiesId props);
	}

	// FIXME: implement SDL_SetPropertyWithCleanup()
	// FIXME: implement SDL_SetProperty()

	/// <summary>
	/// Set a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetStringProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property, or null to delete the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetStringProperty(SDL_PropertiesId props, string name, string? value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name), v = (value is not null) ? Encoding.UTF8.GetBytes(value) : null)
		{
			return _PInvoke(props, n, v);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetStringProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name, byte* value);
	}

	/// <summary>
	/// Set an integer property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetNumberProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetNumberProperty(SDL_PropertiesId props, string name, long value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, value);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetNumberProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name, long value);
	}

	/// <summary>
	/// Set a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetFloatProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetFloatProperty(SDL_PropertiesId props, string name, float value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, value);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetFloatProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name, float value);
	}

	/// <summary>
	/// Set a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetBooleanProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetBooleanProperty(SDL_PropertiesId props, string name, bool value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, value ? 1 : 0);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name, int value);
	}

	/// <summary>
	/// Return whether a property exists in a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_HasProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <returns> True if the property exists, or false if it doesn't. </returns>
	public static bool HasProperty(SDL_PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n) == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_HasProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name);
	}

	/// <summary>
	/// Get the type of a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPropertyType">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <returns> The type of the property, or <see cref="SDL_PropertyType.Invalid"/> if it is not set. </returns>
	public static SDL_PropertyType GetPropertyType(SDL_PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPropertyType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertyType _PInvoke(SDL_PropertiesId props, byte* name);
	}

	// FIXME: implement SDL_GetProperty()

	/// <summary>
	/// Get a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetStringProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to an empty string. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a string property. </returns>
	public static string GetStringProperty(SDL_PropertiesId props, string name, string defaultValue = "")
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name), v = Encoding.UTF8.GetBytes(defaultValue))
		{
			return Marshal.PtrToStringUTF8((nint)_PInvoke(props, n, v))!;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetStringProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_PropertiesId props, byte* name, byte* defaultValue);
	}

	/// <summary>
	/// Get a number property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumberProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a number property. </returns>
	public static long GetNumberProperty(SDL_PropertiesId props, string name, long defaultValue = 0)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, defaultValue);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumberProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern long _PInvoke(SDL_PropertiesId props, byte* name, long defaultValue);
	}

	/// <summary>
	/// Get a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetFloatProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a float property. </returns>
	public static float GetFloatProperty(SDL_PropertiesId props, string name, float defaultValue = 0f)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, defaultValue);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetFloatProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(SDL_PropertiesId props, byte* name, float defaultValue);
	}

	/// <summary>
	/// Get a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetBooleanProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to false. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a boolean property. </returns>
	public static bool GetBooleanProperty(SDL_PropertiesId props, string name, bool defaultValue = false)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n, defaultValue ? 1 : 0) == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name, int defaultValue);
	}

	/// <summary>
	/// Clear a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ClearProperty">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to clear. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ClearProperty(SDL_PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(props, n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ClearProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_PropertiesId props, byte* name);
	}

	// FIXME: implement SDL_EnumerateProperties()

	/// <summary>
	/// Destroy a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyProperties">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to destroy. </param>
	public static void DestroyProperties(SDL_PropertiesId props)
	{
		_PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_PropertiesId props);
	}
}