using System;
using System.Runtime.CompilerServices;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;

namespace Mass.Game.Launcher.Extensions;

public static class RestResponseExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T EnsureSuccessStatusCode<T>(this RestResponse<EntityFeverResponse<T>> response)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
