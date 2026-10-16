using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Java;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Values;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Paths;

public class ComponentPath : GamePath
{
	public readonly bool IsDirectory;

	public readonly string Target;

	public readonly string Source;

	public readonly string ComponentName;

	public readonly string ComponentZip;

	public readonly string ComponentMd5;

	public readonly string ComponentCache;

	public readonly string ComponentExtension;

	public readonly EntitySubItemDownload Item;

	public readonly bool IsShaderPack;

	public readonly bool IsResourcePack;

	internal static ComponentPath ReflectEfficientVerifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ComponentPath(string @base, EntityItemDownload download, EntitySubItemDownload subItem)
	{
		//IL_0570: Expected Obj, but got Ref
		//IL_0365: Expected Obj, but got I4
		//IL_062f: Expected native int or pointer, but got Obj
		//IL_0263: Expected Obj, but got Ref
		//IL_0268: Expected I4, but got Obj
		//IL_0268: Expected I4, but got Obj
		//IL_0271: Expected Obj, but got I4
		//IL_0405: Expected native int or pointer, but got Obj
		//IL_0485: Expected I4, but got Obj
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected I4, but got Unknown
		//IL_03c8: Expected native int or pointer, but got Obj
		//IL_0209: Expected Obj, but got Ref
		//IL_0450: Expected Obj, but got VT
		//IL_04e6: Expected native int or pointer, but got Obj
		//IL_04f6: Expected Ref, but got VT
		//IL_04fb: Expected VT, but got Obj
		//IL_04f6: Expected native int or pointer, but got Obj
		//IL_0505: Expected native int or pointer, but got Obj
		//IL_0160: Expected native int or pointer, but got Obj
		//IL_016a: Expected native int or pointer, but got Obj
		//IL_045f: Expected I4, but got Obj
		//IL_0521: Expected VT, but got Obj
		//IL_051c: Expected native int or pointer, but got Obj
		//IL_052b: Expected native int or pointer, but got Obj
		//IL_05a2: Expected I4, but got Obj
		//IL_05a2: Expected VT, but got Obj
		//IL_05ae: Expected native int or pointer, but got Obj
		//IL_03e4: Expected Obj, but got I4
		//IL_03ee: Expected native int or pointer, but got Obj
		//IL_0114: Expected native int or pointer, but got Obj
		//IL_0123: Expected VT, but got Obj
		//IL_011e: Expected native int or pointer, but got Obj
		//IL_012c: Expected Obj, but got I4
		//IL_0134: Expected native int or pointer, but got Obj
		//IL_0143: Expected VT, but got Obj
		//IL_013e: Expected native int or pointer, but got Obj
		//IL_0671: Expected Ref, but got VT
		//IL_04a3: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I4
		//IL_0554: Expected native int or pointer, but got Obj
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected I4, but got Unknown
		//IL_0212: Expected native int or pointer, but got Obj
		//IL_0583: Expected Obj, but got I4
		//IL_019c: Expected native int or pointer, but got Obj
		//IL_06d3: Expected I4, but got Obj
		//IL_0612: Expected Obj, but got I4
		//IL_02d9: Expected native int or pointer, but got Obj
		//IL_06a8: Expected I, but got Obj
		//IL_06aa: Invalid comparison between Unknown and I4
		//IL_01e0->IL0042: Incompatible stack heights: 1 vs 2
		//IL_063e->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0276->IL003e: Incompatible stack heights: 1 vs 0
		//IL_0659->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0491->IL0042: Incompatible stack heights: 1 vs 2
		//IL_050f->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0179->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0475->IL0042: Incompatible stack heights: 1 vs 2
		//IL_030a->IL0042: Incompatible stack heights: 1 vs 2
		//IL_05b8->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0131->IL003e: Incompatible stack heights: 1 vs 0
		//IL_067b->IL0042: Incompatible stack heights: 1 vs 2
		//IL_05f5->IL0042: Incompatible stack heights: 1 vs 2
		//IL_04ad->IL0042: Incompatible stack heights: 1 vs 2
		//IL_02bb->IL0042: Incompatible stack heights: 1 vs 2
		//IL_055e->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0042->IL0042: Incompatible stack heights: 1 vs 2
		//IL_01eb->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0664->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0588->IL003e: Incompatible stack heights: 1 vs 0
		//IL_051a->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0480->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0315->IL0042: Incompatible stack heights: 1 vs 2
		//IL_05c3->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0600->IL0042: Incompatible stack heights: 1 vs 2
		//IL_02c6->IL0042: Incompatible stack heights: 1 vs 2
		//IL_0617->IL003e: Incompatible stack heights: 1 vs 0
		//IL_0569->IL0042: Incompatible stack heights: 3 vs 2
		//IL_0696->IL06b1: Incompatible stack heights: 2 vs 1
		//IL_06e8->IL06e9: Incompatible stack heights: 2 vs 3
		//IL_06b1->IL06b2: Incompatible stack heights: 1 vs 2
		//IL_06c1->IL0042: Incompatible stack heights: 1 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = ((Authenticator)(object)this).Listener;
		int num = 4;
		if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
		{
			num = 4;
		}
		object awaiter = default;
		while (true)
		{
			switch (num)
			{
			case 36:
				((TcpListener)(object)download).Start();
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task);
				awaiter = 40;
				break;
			case 37:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener.Dispose();
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<TcpClient>)@base);
				num = 8;
				break;
			case 29:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)awaiter)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter());
				_ = 33;
				break;
			case 20:
				switch (awaiter - 3)
				{
				case 0:
					goto IL_02ef;
				case 2:
					goto IL_03a3;
				case 1:
					goto IL_0448;
				case 3:
					goto IL_063e;
				}
				num = 5;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
				{
					num = 2;
				}
				break;
			case 7:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&awaiter))->MoveNext();
				((AsyncTaskMethodBuilder*)obj)->SetResult();
				_ = 23;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 42;
				}
				break;
			case 19:
				obj = RestRequestExtensions.AddQueryParameter<int>((RestRequest)/*Error near IL_01f8: Stack underflow*/, (string)obj, (int)(&awaiter), ((TaskAwaiter<TcpClient>*)download)->IsCompleted);
				num = 22;
				break;
			case 22:
				((Task<TcpClient>)(&awaiter)).GetAwaiter();
				throw new TaskAwaiter<TcpClient>();
			case 6:
			case 13:
			case 28:
				Unsafe.Write(&Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway, awaiter);
				num = 34;
				if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP == null)
				{
					num = 9;
				}
				break;
			case 12:
				awaiter = Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.HandleNotifier();
				num = 17;
				if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
				{
					num = 28;
				}
				break;
			case 9:
				((Stream)/*Error near IL_0268: Stack underflow*/).Read((byte[])/*Error near IL_0268: Stack underflow*/, (int)obj, (int)((FeverInstaller)(&awaiter)).Client);
				awaiter = 19;
				break;
			case 42:
				((RestClientOptions)download)._002Ector();
				((AsyncTaskMethodBuilder*)obj)->Start(ref *(Rpc._003CListenControlConnectAsync_003Ed__35*)(&awaiter));
				_ = 0;
				if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 0;
				}
				break;
			case 46:
				if ((nint)awaiter != 18)
				{
					num = 6;
					if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						num = 43;
					}
					break;
				}
				goto case 30;
			case 2:
				return;
			case 32:
				goto IL_02ef;
			case 15:
				throw new AsyncTaskMethodBuilder<EntityFeverManifestInfo>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&awaiter))->Task);
			case 1:
			case 16:
				awaiter = awaiter;
				num = 17;
				if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter == null)
				{
					num = 15;
				}
				break;
			case 4:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)obj)->Start<TStateMachine>(ref *(TStateMachine*)download);
				awaiter = (object)/*Error near IL_035c: Stack underflow*/;
				awaiter = 45;
				break;
			case 14:
				((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(&awaiter))->MoveNext();
				/*Error near IL_0371: Member reference must be method, but was: Field*/;
			case 45:
				switch (awaiter - 3)
				{
				case 0:
					break;
				default:
					goto IL_0399;
				case 3:
					goto IL_03b7;
				case 1:
					goto IL_03dd;
				case 2:
					goto IL_0540;
				}
				goto case 12;
			case 5:
			case 24:
				goto IL_03a3;
			case 21:
				goto IL_03b7;
			case 35:
				goto IL_03dd;
			case 10:
				_ = ((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)this)->_003C_003Eu__2;
				/*Error near IL_040b: Member reference must be method, but was: Field*/;
			case 26:
				goto IL_0448;
			case 30:
				((Rpc)/*Error near IL_045f: Stack underflow*/).NeedCha = (byte)(int)obj != 0;
				awaiter = (object)/*Error near IL_0461: Stack underflow*/;
				_ = 0;
				if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField == null)
				{
					_ = 1;
				}
				break;
			case 18:
				((Rpc)/*Error near IL_0485: Stack underflow*/)._002Ector((ILogger)/*Error near IL_0485: Stack underflow*/, (byte)(int)obj != 0);
				awaiter = (object)/*Error near IL_0487: Stack underflow*/;
				_ = 16;
				break;
			case 40:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)obj)->SetResult((EntityFeverAppVersion)(object)download);
				((Rpc)/*Error near IL_049c: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_049c: Stack underflow*/, (object[])/*Error near IL_049c: Stack underflow*/);
				awaiter = ((TaskAwaiter<EntityFeverApp>*)/*Error near IL_04a1: Stack underflow*/)->IsCompleted;
				_ = 47;
				break;
			case 27:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((Rpc._003CListenAsync_003Ed__34*)(nint)this)->_003C_003Eu__1)->SetException((Exception)(object)((TaskAwaiter<EntityFeverApp>*)subItem)->GetResult());
				Unsafe.Write(&((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)obj)->_003C_003Et__builder, (AsyncTaskMethodBuilder)this);
				_ = 2;
				if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this == null)
				{
					_ = 2;
				}
				break;
			case 33:
				Unsafe.Write(&((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<TcpClient>)subItem);
				num = 37;
				if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator)->_003C_003E1__state == 0)
				{
					num = 14;
				}
				break;
			case 25:
			case 44:
				goto IL_0540;
			default:
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)obj)->SetResult((EntityFeverManifestInfo)(&awaiter));
				throw new TaskAwaiter<EntityFeverManifestInfo>();
			case 17:
			case 23:
			case 31:
				awaiter = awaiter;
				awaiter = 36;
				break;
			case 3:
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&awaiter))->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)11, ref *(TStateMachine*)1);
				num = 14;
				break;
			case 34:
				awaiter = RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_05a2: Stack underflow*/, (string)/*Error near IL_05a2: Stack underflow*/, (_0021_00210)obj, (byte)(int)download != 0);
				_ = 20;
				if ((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.callBack)->_003C_003Eu__1 == 0)
				{
					_ = 8;
				}
				break;
			case 39:
				((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)/*Error near IL_05e1: Stack underflow*/)->_003C_003E1__state = (((nint)((string)obj).Replace((string)(object)this, (string?)(object)download) == 6) ? 1 : 0);
				_ = 29;
				if (((Rpc._003CSyncChaChaAsync_003Ed__38)Rpc._003CSyncChaChaAsync_003Ed__38._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 2;
				}
				break;
			case 43:
				if ((nint)awaiter == 19)
				{
					awaiter = 18;
					break;
				}
				goto case 3;
			case 8:
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)@base)->SetStateMachine((IAsyncStateMachine)awaiter);
				Unsafe.Write(&Rpc._003CSyncChaChaAsync_003Ed__38.RateStack, this);
				_ = 10;
				break;
			case 11:
				goto IL_063e;
			case 38:
				((AsyncTaskMethodBuilder*)obj)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityAuthItem>*)(&awaiter), ref *(JavaGame._003CPrepareComponentsAsync_003Ed__28*)((Task<EntityFeverManifest>)(object)download).GetAwaiter());
				_ = 15;
				break;
			case 47:
				if (download != null)
				{
					((Dictionary<ushort, Func<RpcCallBack, Task>>)(object)download)._002Ector();
					if ((nint)this == 4)
					{
						((Func<RpcCallBack, Task>)/*Error near IL_06a8: Stack underflow*/)._002Ector(obj, (nint)download);
						_ = (int)/*Error near IL_06ac: Stack underflow*/ == 18;
						goto IL_06b2;
					}
				}
				goto IL_06b2;
			case 41:
				{
					if (download != null && (nint)BitConverter.GetBytes((ushort)(int)download) == 4)
					{
						_ = (nint)Enumerable.Concat<TSource>((IEnumerable<TSource>)this, (IEnumerable<TSource>)download) == 19;
					}
					else
					{
					}
					((JavaGameValue)(object)this).GuiScale__BackingField = 0;
					num = 39;
					break;
				}
				IL_0448:
				awaiter = ((Task<RestResponse<EntityFeverResponse<_00210>>>)(object)download).GetAwaiter();
				num = 46;
				break;
				IL_063e:
				((Rpc._003CRemoteCallBackAsync_003Ed__21*)obj)->MoveNext();
				awaiter = (object)/*Error near IL_0645: Stack underflow*/;
				_ = 18;
				if (((GameValue)CppGameValue.DecorateAlphabeticList).MaxConcurrency__BackingField == 0)
				{
					_ = 31;
				}
				break;
				IL_03a3:
				_ = ref awaiter;
				_ = 9;
				_ = 1;
				/*Error near IL_03a8: Member reference must be method, but was: Field*/;
				IL_06b2:
				((JavaGameValue)obj).SaveOptions__BackingField = 0;
				_ = 41;
				break;
				IL_02ef:
				((FeverInstaller._003CFeverRequest_003Ed__15<>*)obj)->MoveNext();
				awaiter = (object)/*Error near IL_02f6: Stack underflow*/;
				_ = 2;
				if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 23;
				}
				break;
				IL_0540:
				_ = ref awaiter;
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)9)->SetException((Exception)1);
				_ = 6;
				if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CReceiveAsync_003Ed__28.client)->_003C_003E4__this != null)
				{
					_ = 9;
				}
				break;
				IL_03dd:
				awaiter = FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CallGateway();
				num = 6;
				if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					num = 1;
				}
				break;
				IL_03b7:
				awaiter = FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator();
				num = 13;
				if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state != 0)
				{
					num = 2;
				}
				break;
				IL_0399:
				num = 25;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CloseRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ComponentPath DecorateGlobalComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00爀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00笀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
