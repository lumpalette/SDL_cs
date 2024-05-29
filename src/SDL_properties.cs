using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_properties.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_properties.h.
unsafe partial class SDL
{
	/// <summary>
	/// A collection of strings for properties' names used by various SDL systems.
	/// </summary>
	public static partial class PropConsts { }

	/// <summary>
	/// An id of a set of properties. This structure serves as a wrapper for an unsigned 32-bit integer.
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
		/// An id to an invalid set of properties.
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
	/// <returns> A valid property id on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetGlobalProperties()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PropertiesId _PInvoke();
	}

	/// <summary>
	/// Create a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProperties">here</see>.
	/// </remarks>
	/// <returns> An id for a new set of properties, or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId CreateProperties()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_CreateProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PropertiesId _PInvoke();
	}

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
		return _PInvoke(src, dst);

		[DllImport(LibraryName, EntryPoint = "SDL_CopyProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId src, PropertiesId dst);
	}

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
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_LockProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props);
	}

	/// <summary>
	/// Unlock a set of properties.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to unlock. </param>
	public static void UnlockProperties(PropertiesId props)
	{
		_PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(PropertiesId props);
	}

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
			return _PInvoke(props, n, v);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetStringProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name, byte* value);
	}

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
			return _PInvoke(props, n, value);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetNumberProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name, long value);
	}

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
			return _PInvoke(props, n, value);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetFloatProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name, float value);
	}

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
			return _PInvoke(props, n, value ? 1 : 0);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name, int value);
	}

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
			return _PInvoke(props, n) == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_HasProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name);
	}

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
			return (PropertyType)_PInvoke(props, n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPropertyType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name);
	}

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
			return Marshal.PtrToStringUTF8((nint)_PInvoke(props, n, v))!;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetStringProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(PropertiesId props, byte* name, byte* defaultValue);
	}

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
			return _PInvoke(props, n, defaultValue);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumberProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern long _PInvoke(PropertiesId props, byte* name, long defaultValue);
	}

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
			return _PInvoke(props, n, defaultValue);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetFloatProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(PropertiesId props, byte* name, float defaultValue);
	}

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
			return _PInvoke(props, n, defaultValue ? 1 : 0) == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name, int defaultValue);
	}

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
			return _PInvoke(props, n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ClearProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PropertiesId props, byte* name);
	}

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
		_PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(PropertiesId props);
	}
}