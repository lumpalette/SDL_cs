using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_guid.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_guid.h
unsafe partial class SDL
{
	/// <summary>
	/// Get a string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">here</see>.
	/// </remarks>
	/// <param name="guid"> The <see cref="SDL_Guid"/> you wish to convert to string. </param>
	/// <param name="pszGuid"> Returns the converted string. </param>
	/// <param name="cbGuid"> The number of characters that <paramref name="pszGuid"/> should have. The minimum and default value is 33. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GuidToString(SDL_Guid guid, out string? pszGuid, int cbGuid = 33)
	{
		nint buffer = Marshal.AllocHGlobal(cbGuid);
		int result = _PInvoke(guid, (byte*)buffer, cbGuid);
		pszGuid = Marshal.PtrToStringUTF8(buffer);
		Marshal.FreeHGlobal(buffer);
		return result;

		[DllImport(LibraryName, EntryPoint = "SDL_GUIDToString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Guid guid, byte* pszGuid, int cbGuid);
	}

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDFromString">here</see>.
	/// </remarks>
	/// <param name="pchGuid"> String containing a representation of a GUID. </param>
	/// <returns> An <see cref="SDL_Guid"/> structure. </returns>
	public static SDL_Guid GuidFromString(string pchGuid)
	{
		fixed (byte* g = Encoding.UTF8.GetBytes(pchGuid))
		{
			return _PInvoke(g);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GUIDFromString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Guid _PInvoke(byte* pchGuid);
	}
}