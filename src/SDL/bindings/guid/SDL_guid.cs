using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_guid.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_guid.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Get a string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_Guid"/> you wish to convert to string.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GUIDToString", StringMarshallingCustomType = typeof(GetStringRuleStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GuidToString(SDL_Guid guid);

	/// <summary>
	/// Get an ASCII string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_Guid"/> you wish to convert to string.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GUIDToString")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte* GuidToStringTemporary(SDL_Guid guid);

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StringToGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="pchGuid">String containing a representation of a GUID.</param>
	/// <returns>An <see cref="SDL_Guid"/> structure.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_StringToGUID", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Guid StringToGuid(string pchGuid);

	void X()
	{
		SDL.FreeTemporaryMemory
	}
}