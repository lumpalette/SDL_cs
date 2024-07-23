using System;

namespace SDL_cs;

/// <summary>
/// Indicates that a field or return value of some method can be claimed using <see cref="SDL.Claim_RaworaryMemory(nint)"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
public class ClaimableAttribute : Attribute;