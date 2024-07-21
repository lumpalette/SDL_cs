using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

// SDL_properties.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_properties.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Get the global SDL properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalProperties">documentation</see> for more details.
	/// </remarks>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetGlobalProperties();

	/// <summary>
	/// Create a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProperties">documentation</see> for more details.
	/// </remarks>
	/// <returns>An ID for a new group of properties, or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId CreateProperties();

	/// <summary>
	/// Copy a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CopyProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The properties to copy.</param>
	/// <param name="dst">The destionation properties.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CopyProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int CopyProperties(SDL_PropertiesId src, SDL_PropertiesId dst);

	/// <summary>
	/// Lock a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to lock.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int LockProperties(SDL_PropertiesId props);

	/// <summary>
	/// Unlock a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to unlock.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnlockProperties(SDL_PropertiesId props);

	/// <summary>
	/// Set a property on a group of properties with a cleanup function that is called when the property is deleted.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPointerPropertyWithCleanup">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see cref="nint.Zero"/> to delete the property.</param>
	/// <param name="cleanup">The function to call when this property is deleted, or <see langword="null"/> if no cleanup is necessary.</param>
	/// <param name="userData">A pointer that is passed to the cleanup function.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPointerPropertyWithCleanup", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetPointerPropertyWithCleanup(SDL_PropertiesId props, string name, nint value, SDL_CleanupPropertyCallback cleanup, nint userData);

	/// <summary>
	/// Set a property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPointerProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see cref="nint.Zero"/> to delete the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPointerProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetPointerProperty(SDL_PropertiesId props, string name, nint value);

	/// <summary>
	/// Set a string property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetStringProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property, or <see langword="null"/> to delete the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetStringProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetStringProperty(SDL_PropertiesId props, string name, string? value);

	/// <summary>
	/// Set an integer property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetNumberProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetNumberProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetNumberProperty(SDL_PropertiesId props, string name, long value);

	/// <summary>
	/// Set a floating point property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetFloatProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetFloatProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetFloatProperty(SDL_PropertiesId props, string name, float value);

	/// <summary>
	/// Set a boolean property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetBooleanProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to modify.</param>
	/// <param name="value">The new value of the property.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetBooleanProperty(SDL_PropertiesId props, string name, [MarshalAs(NativeBool)] bool value);

	/// <summary>
	/// Return whether a property exists in a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <returns>True if the property exists, or false if it doesn't.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasProperty(SDL_PropertiesId props, string name);

	/// <summary>
	/// Get the type of a property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPropertyType">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <returns>The type of the property, or <see cref="SDL_PropertyType.Invalid"/> if it is not set.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPropertyType", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertyType GetPropertyType(SDL_PropertiesId props, string name);

	/// <summary>
	/// Get a property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to <see cref="nint.Zero"/>.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a pointer property.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GetProperty(SDL_PropertiesId props, string name, nint defaultValue = 0);

	/// <summary>
	/// Get a string property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetStringProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to an empty string.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a string property.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetStringProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDLManagedStringMarshaller))]
	public static partial string? GetStringProperty(SDL_PropertiesId props, string name, string defaultValue = "");

	/// <summary>
	/// Get a number property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumberProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to 0.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a number property.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumberProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial long GetNumberProperty(SDL_PropertiesId props, string name, long defaultValue = 0L);

	/// <summary>
	/// Get a floating point property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetFloatProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue"> The default value of the property. Defaults to 0.0f. </param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a float property.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetFloatProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetFloatProperty(SDL_PropertiesId props, string name, float defaultValue = 0f);

	/// <summary>
	/// Get a boolean property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetBooleanProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="name">The name of the property to query.</param>
	/// <param name="defaultValue">The default value of the property. Defaults to false.</param>
	/// <returns>The value of the property, or <paramref name="defaultValue"/> if it is not set or not a boolean property.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetBooleanProperty(SDL_PropertiesId props, string name, [MarshalAs(NativeBool)] bool defaultValue = false);

	/// <summary>
	/// Clear a property on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearProperty">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to modify.</param>
	/// <param name="name">The name of the property to clear.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearProperty", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ClearProperty(SDL_PropertiesId props, string name);

	/// <summary>
	/// Enumerate the properties on a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnumerateProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to query.</param>
	/// <param name="callback">The function to call for each property.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int EnumerateProperties(SDL_PropertiesId props, SDL_EnumeratePropertiesCallback callback, nint userData);

	/// <summary>
	/// Destroy a group of properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to destroy.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyProperties(SDL_PropertiesId props);
}