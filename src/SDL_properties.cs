using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_properties.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_properties.h.
unsafe partial class SDL
{
	/// <summary>
	/// A collection of strings for properties' names used by various SDL systems.
	/// </summary>
	public static partial class PropNames { }

	/// <summary>
	/// An ID of a set of properties. This structure serves as a wrapper for an unsigned 32-bit integer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_PropertiesID">here</see>.
	/// </remarks>
	public readonly struct PropertiesId
	{
		internal PropertiesId(uint value)
		{
			Id = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is PropertiesId props)
			{
				return Id == props.Id;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, base.GetHashCode());
		}

		public static bool operator ==(PropertiesId a, PropertiesId b) => a.Id == b.Id;
		public static bool operator !=(PropertiesId a, PropertiesId b) => a.Id != b.Id;

		/// <summary>
		/// An ID to an invalid set of properties.
		/// </summary>
		/// <remarks>
		/// Use this whenever you need to tell SDL that a set of properties is not required. This is also used when a function that
		/// returns a <see cref="PropertiesId"/> instance fails.
		/// </remarks>
		public static PropertiesId Invalid => new();

		/// <summary>
		/// The id value, as an unsigned 32-bit integer.
		/// </summary>
		public readonly uint Id;
	}

	/// <summary>
	/// SDL property type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_PropertyType">here</see>.
	/// </remarks>
	public enum PropertyType
	{
		/// <summary>
		/// The property is not valid.
		/// </summary>
		Invalid,

		/// <summary>
		/// The property is an arbitrary object.
		/// </summary>
		Pointer,

		/// <summary>
		/// The property is a string.
		/// </summary>
		String,

		/// <summary>
		/// The property is a signed 64-bit integer.
		/// </summary>
		Number,

		/// <summary>
		/// The property is a floating point number.
		/// </summary>
		Float,

		/// <summary>
		/// The property is a boolean.
		/// </summary>
		Boolean
	}

	/// <summary>
	/// Get the global SDL properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalProperties">here</see>.
	/// </remarks>
	/// <returns> A valid property ID on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetGlobalProperties()
	{
		return _PInvokeGetGlobalProperties();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeGetGlobalProperties();

	/// <summary>
	/// Create a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProperties">here</see>.
	/// </remarks>
	/// <returns> An ID for a new set of properties, or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId CreateProperties()
	{
		return _PInvokeCreateProperties();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeCreateProperties();

	/// <summary>
	/// Copy a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CopyProperties">here</see>.
	/// </remarks>
	/// <param name="src"> The properties to copy. </param>
	/// <param name="dst"> The destionation properties. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int CopyProperties(PropertiesId src, PropertiesId dst)
	{
		return _PInvokeCopyProperties(src, dst);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CopyProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeCopyProperties(PropertiesId src, PropertiesId dst);

	/// <summary>
	/// Lock a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_LockProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to lock. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockProperties(PropertiesId props)
	{
		return _PInvokeLockProperties(props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_LockProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeLockProperties(PropertiesId props);

	/// <summary>
	/// Unlock a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to unlock. </param>
	public static void UnlockProperties(PropertiesId props)
	{
		_PInvokeUnlockProperties(props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeUnlockProperties(PropertiesId props);

	// ADDME:SDL_SetPropertyWithCleanup()

	// ADDME:SDL_SetProperty()

	/// <summary>
	/// Set a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetStringProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property, or null to delete the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetStringProperty(PropertiesId props, string name, string? value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name), v = (value is not null) ? Encoding.UTF8.GetBytes(value) : null)
		{
			return _PInvokeSetStringProperty(props, n, v);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetStringProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetStringProperty(PropertiesId props, byte* name, byte* value);

	/// <summary>
	/// Set an integer property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetNumberProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetNumberProperty(PropertiesId props, string name, long value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeSetNumberProperty(props, n, value);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetNumberProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetNumberProperty(PropertiesId props, byte* name, long value);

	/// <summary>
	/// Set a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetFloatProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetFloatProperty(PropertiesId props, string name, float value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeSetFloatProperty(props, n, value);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetFloatProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetFloatProperty(PropertiesId props, byte* name, float value);

	/// <summary>
	/// Set a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetBooleanProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to modify. </param>
	/// <param name="value"> The new value of the property. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetBooleanProperty(PropertiesId props, string name, bool value)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeSetBooleanProperty(props, n, value ? 1 : 0);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetBooleanProperty(PropertiesId props, byte* name, int value);

	/// <summary>
	/// Return whether a property exists in a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HasProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <returns> True if the property exists, or false if it doesn't. </returns>
	public static bool HasProperty(PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeHasProperty(props, n) == 1;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_HasProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeHasProperty(PropertiesId props, byte* name);

	/// <summary>
	/// Get the type of a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetPropertyType">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <returns> The type of the property, or <see cref="PropertyType.Invalid"/> if it is not set. </returns>
	public static PropertyType GetPropertyType(PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return (PropertyType)_PInvokeGetPropertyType(props, n);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPropertyType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetPropertyType(PropertiesId props, byte* name);

	// ADDME:SDL_GetProperty()

	/// <summary>
	/// Get a string property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetStringProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to an empty string. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a string property. </returns>
	public static string GetStringProperty(PropertiesId props, string name, string defaultValue = "")
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name), v = Encoding.UTF8.GetBytes(defaultValue))
		{
			return Marshal.PtrToStringUTF8((nint)_PInvokeGetStringProperty(props, n, v))!;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetStringProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetStringProperty(PropertiesId props, byte* name, byte* defaultValue);

	/// <summary>
	/// Get a number property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumberProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a number property. </returns>
	public static long GetNumberProperty(PropertiesId props, string name, long defaultValue = 0)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeGetNumberProperty(props, n, defaultValue);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumberProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial long _PInvokeGetNumberProperty(PropertiesId props, byte* name, long defaultValue);

	/// <summary>
	/// Get a floating point property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetFloatProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a float property. </returns>
	public static float GetFloatProperty(PropertiesId props, string name, float defaultValue = 0f)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeGetFloatProperty(props, n, defaultValue);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetFloatProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial float _PInvokeGetFloatProperty(PropertiesId props, byte* name, float defaultValue);

	/// <summary>
	/// Get a boolean property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetBooleanProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to query. </param>
	/// <param name="name"> The name of the property to query. </param>
	/// <param name="defaultValue"> The default value of the property. Defaults to false. </param>
	/// <returns> The value of the property, or <paramref name="defaultValue"/> if it is not set or not a boolean property. </returns>
	public static bool GetBooleanProperty(PropertiesId props, string name, bool defaultValue = false)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeGetBooleanProperty(props, n, defaultValue ? 1 : 0) == 1;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetBooleanProperty(PropertiesId props, byte* name, int defaultValue);

	/// <summary>
	/// Clear a property on a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ClearProperty">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to modify. </param>
	/// <param name="name"> The name of the property to clear. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ClearProperty(PropertiesId props, string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvokeClearProperty(props, n);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeClearProperty(PropertiesId props, byte* name);

	// ADDME:SDL_EnumerateProperties()

	/// <summary>
	/// Destroy a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to destroy. </param>
	public static void DestroyProperties(PropertiesId props)
	{
		_PInvokeDestroyProperties(props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyProperty")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeDestroyProperties(PropertiesId props);
}