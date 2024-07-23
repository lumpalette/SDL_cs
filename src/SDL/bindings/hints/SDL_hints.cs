using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

// SDL_hints.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_hints.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Set a hint with a specific priority.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetHintWithPriority">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <param name="priority">The <see cref="SDL_HintPriority"/> level for the hint.</param>
	/// <returns>True if the hint was set, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetHintWithPriority", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetHintWithPriority(string name, string value, SDL_HintPriority priority);

	/// <summary>
	/// Set a hint with normal priority.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetHint">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to set.</param>
	/// <param name="value">The value of the hint variable.</param>
	/// <returns>True if the hint was set, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetHint(string name, string value);

	/// <summary>
	/// Reset a hint to the default value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResetHint">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to set.</param>
	/// <returns>True if the hint was set, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ResetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ResetHint(string name);

	/// <summary>
	/// Reset all hints to the default values.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResetHints">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ResetHints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ResetHints();

	/// <summary>
	/// Get the value of a hint.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetHint">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to query.</param>
	/// <returns>The string value of a hint or <see langword="null"/> if the hint isn't set.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(GetStringRuleStringMarshaller))]
	public static partial string? GetHint(string name);

	/// <summary>
	/// Get the value of a hint.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetHint">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to query.</param>
	/// <returns>The string value of a hint or <see langword="null"/> if the hint isn't set.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetHint", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte* GetHintTemp(string name);

	/// <summary>
	/// Add a function to watch a particular hint.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddHintCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint to watch.</param>
	/// <param name="callback">An <see cref="SDL_HintCallback"/> function that will be called when the hint value changes.</param>
	/// <param name="userData">A pointer to pass to the callback function.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddHintCallback", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int AddHintCallback(string name, SDL_HintCallback callback, nint userData);

	/// <summary>
	/// Remove a function watching a particular hint.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DelHintCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The hint being watched.</param>
	/// <param name="callback">An <see cref="SDL_HintCallback"/> function that will be called when the hint value changes.</param>
	/// <param name="userData">A pointer being passed to the callback function.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DelHintCallback", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DelHintCallback(string name, SDL_HintCallback callback, nint userData);
}