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
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalProperties">documentation</see> for more details.
	/// </remarks>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PropertiesId GetGlobalProperties()
	{
		return SDL_PInvoke.SDL_GetGlobalProperties();
	}

	/// <summary>
	/// Create a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProperties">documentation</see> for more details.
	/// </remarks>
	/// <returns>An ID for a new set of properties, or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PropertiesId CreateProperties()
	{
		return SDL_PInvoke.SDL_CreateProperties();
	}

	/// <summary>
	/// Copy a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CopyProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The properties to copy.</param>
	/// <param name="dst">The destionation properties.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int CopyProperties(SDL_PropertiesId src, SDL_PropertiesId dst)
	{
		return SDL_PInvoke.SDL_CopyProperties(src, dst);
	}

	/// <summary>
	/// Lock a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to lock.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int LockProperties(SDL_PropertiesId props)
	{
		return SDL_PInvoke.SDL_LockProperties(props);
	}

	/// <summary>
	/// Unlock a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to unlock. </param>
	public static void UnlockProperties(SDL_PropertiesId props)
	{
		SDL_PInvoke.SDL_UnlockProperties(props);
	}

	/// <summary>
	/// Set a property on a set of properties with a cleanup function that is called when the property is deleted.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPropertyWithCleanup">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see langword="null"/> to delete the property.</param>
	/// <param name="cleanup">The function to call when this property is deleted, or <see langword="null"/> if no cleanup is necessary.</param>
	/// <param name="userData">A pointer that is passed to the cleanup function.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, void* value, SDL_CleanupPropertyCallback cleanup, void* userData)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_SetPropertyWithCleanup(props, namePtr, value, cleanup, userData);
		}
	}

	/// <summary>
	/// Set a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see langword="null"/> to delete the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, void* value)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_SetProperty(props, namePtr, value);
		}
	}

	/// <summary>
	/// Set a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetStringProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see langword="null"/> to delete the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, string? value)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name), valuePtr = (value is not null) ? Encoding.UTF8.GetBytes(value) : null)
		{
			return SDL_PInvoke.SDL_SetStringProperty(props, namePtr, valuePtr);
		}
	}

	/// <summary>
	/// Set an integer property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetNumberProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, long value)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_SetNumberProperty(props, namePtr, value);
		}
	}

	/// <summary>
	/// Set a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetFloatProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, float value)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_SetFloatProperty(props, namePtr, value);
		}
	}

	/// <summary>
	/// Set a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetBooleanProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetProperty(SDL_PropertiesId props, string name, bool value)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_SetBooleanProperty(props, namePtr, value ? 1 : 0);
		}
	}

	/// <summary>
	/// Return whether a property exists in a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <returns>True if the property exists, or false if it doesn't.</returns>
	public static bool HasProperty(SDL_PropertiesId props, string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_HasProperty(props, namePtr) == 1;
		}
	}

	/// <summary>
	/// Get the type of a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPropertyType">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <returns>The type of the property, or <see cref="SDL_PropertyType.Invalid"/> if it is not set.</returns>
	public static SDL_PropertyType GetPropertyType(SDL_PropertiesId props, string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_GetPropertyType(props, namePtr);
		}
	}

	/// <summary>
	/// Get a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to <see langword="null"/>.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a pointer property.</returns>
	public static void* GetProperty(SDL_PropertiesId props, string name, void* defaultValue = null)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_GetProperty(props, namePtr, defaultValue);
		}
	}

	/// <summary>
	/// Get a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetStringProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to an empty string.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a string property.</returns>
	public static string GetProperty(SDL_PropertiesId props, string name, string defaultValue = "")
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name), defaultValuePtr = Encoding.UTF8.GetBytes(defaultValue))
		{
			return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetStringProperty(props, namePtr, defaultValuePtr))!;
		}
	}

	/// <summary>
	/// Get a number property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumberProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to 0.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a number property.</returns>
	public static long GetNumberProperty(SDL_PropertiesId props, string name, long defaultValue = 0)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_GetNumberProperty(props, namePtr, defaultValue);
		}
	}

	/// <summary>
	/// Get a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetFloatProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0.0f. </param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a float property.</returns>
	public static float GetProperty(SDL_PropertiesId props, string name, float defaultValue = 0f)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_GetFloatProperty(props, namePtr, defaultValue);
		}
	}

	/// <summary>
	/// Get a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetBooleanProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to false.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a boolean property.</returns>
	public static bool GetProperty(SDL_PropertiesId props, string name, bool defaultValue = false)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_GetBooleanProperty(props, namePtr, defaultValue ? 1 : 0) == 1;
		}
	}

	/// <summary>
	/// Clear a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to clear.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ClearProperty(SDL_PropertiesId props, string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return SDL_PInvoke.SDL_ClearProperty(props, namePtr);
		}
	}

	/// <summary>
	/// Enumerate the properties on a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnumerateProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="callback">The function to call for each property.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int EnumerateProperties(SDL_PropertiesId props, SDL_EnumeratePropertiesCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_EnumerateProperties(props, callback, userData);
	}

	/// <summary>
	/// Destroy a set of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to destroy.</param>
	public static void DestroyProperties(SDL_PropertiesId props)
	{
		SDL_PInvoke.SDL_DestroyProperties(props);
	}
}