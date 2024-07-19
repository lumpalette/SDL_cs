using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

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
	/// <param name="pszGuid">The converted string.</param>
	/// <param name="cbGuid">The number of characters that <paramref name="pszGuid"/> should have. The minimum and default value is 33.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GuidToString(SDL_Guid guid, out string? pszGuid, int cbGuid = 33)
	{
		byte* buffer = stackalloc byte[cbGuid];
		int result = SDL_GUIDToString(guid, buffer, cbGuid);
		pszGuid = Utf8StringMarshaller.ConvertToManaged(buffer);
		return result;

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_GUIDToString(SDL_Guid guid, byte* pszGUID, int cbGUID);
	}

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="pchGuid">String containing a representation of a GUID.</param>
	/// <returns>An <see cref="SDL_Guid"/> structure.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GUIDFromString", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Guid GuidFromString(string pchGuid);
}