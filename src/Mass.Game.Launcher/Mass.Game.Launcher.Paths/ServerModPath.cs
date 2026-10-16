using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Game.Launcher.Java;

namespace Mass.Game.Launcher.Paths;

public class ServerModPath : GamePath
{
	public readonly string Resource;

	public readonly string ResourceMd5;

	public readonly string Mods;

	public readonly MinecraftPath Minecraft;

	public readonly EntitySubItemDownload Item;

	internal static ServerModPath DecorateExternalAggregator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerModPath(EntityLaunchJavaGame args, string gameBase, EntityItemDownload download, EntitySubItemDownload subItem)
	{
		//IL_00ea: Expected native int or pointer, but got Obj
		//IL_0097: Expected native int or pointer, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got VT
		//IL_00b1: Expected native int or pointer, but got Obj
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_013f: Expected Obj, but got VT
		//IL_013f: Expected Obj, but got I4
		//IL_0076: Expected I4, but got Obj
		//IL_011d->IL0042: Incompatible stack heights: 1 vs 2
		//IL_00c0->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0149->IL0042: Incompatible stack heights: 4 vs 2
		//IL_008a->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0128->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0095->IL0042: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		TcpListener? listener = ((Authenticator)(object)this).Listener;
		int num = 0;
		if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				((TcpListener)(object)download).Start();
				((AsyncTaskMethodBuilder*)this)->Start<TStateMachine>(ref *(TStateMachine*)gameBase);
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0076: Stack underflow*/)->_003C_003E1__state = (int)listener;
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					_ = 0;
				}
				break;
			case 2:
			{
				Authenticator authenticator = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
				bool isCompleted = (Authenticator.ReflectMonoObject() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->IsCompleted;
				((Authenticator._003CListenAsync_003Ed__7*)args)->MoveNext();
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)authenticator)->_003C_003E4__this, (Authenticator)new Authenticator._003CListenAsync_003Ed__7((IAsyncStateMachine)isCompleted));
				_ = 3;
				break;
			}
			case 1:
				return;
			case 3:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client, subItem);
				num = 0;
				if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
				{
					num = 1;
				}
				break;
			default:
				((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state)->SetStateMachine((IAsyncStateMachine)download);
				((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_0109: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter<string>)listener.AcceptTcpClientAsync().GetAwaiter());
				_ = 4;
				if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
				{
					_ = 3;
				}
				break;
			case 4:
				((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler()).Client__BackingField = ((Task<string>)(object)((TcpClient)(object)download).GetStream()).GetAwaiter();
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdaptCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerModPath CheckVirtualDefinition()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ꠀ()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00ꨀ()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
