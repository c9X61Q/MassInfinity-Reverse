using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class ModIdData : FmlHandshakeMessage
{
	internal static ModIdData ReflectRemoteFilter;

	public List<RegistryData.IdEntity> Mapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00攀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00洀(value);
		}
	}

	public List<string> BlockSubstitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00栀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00挀(value);
		}
	}

	public List<string> ItemSubstitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00愀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00樀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00琀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00漀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ModIdData()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001f: Expected VT, but got Obj
		//IL_002f: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_001f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)new object();
		/*Error near IL_0035: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateActiveStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModIdData DecorateJoinedSubscriber()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779356, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00愀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00戀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779359, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00挀(List<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00搀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779358, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<RegistryData.IdEntity> _FF00_FF00攀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<RegistryData.IdEntity>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<RegistryData.IdEntity> _FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779353, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<RegistryData.IdEntity>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779352, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00栀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779355, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00樀(List<string> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00欀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779354, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00氀(List<RegistryData.IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779349, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00洀(List<RegistryData.IdEntity> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00渀(List<RegistryData.IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779348, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00漀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0447: Expected Obj, but got Ref
		//IL_019c: Expected VT, but got Obj
		//IL_019c: Expected VT, but got Obj
		//IL_019c: Expected VT, but got Ref
		//IL_01a6: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got Ref
		//IL_02a1: Expected VT, but got Ref
		//IL_03b7: Expected Obj, but got Ref
		//IL_03b7: Expected Obj, but got Ref
		//IL_025d: Expected Obj, but got Ref
		//IL_038f: Expected Obj, but got Ref
		//IL_03cb: Expected Obj, but got I4
		//IL_02c2: Expected VT, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got VT
		//IL_03e8: Expected Obj, but got I4
		//IL_0458->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01b1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_047e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0489->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0251->IL029a: Incompatible stack heights: 0 vs 1
		//IL_0096->IL00f0: Incompatible stack heights: 2 vs 1
		//IL_0383->IL03b0: Incompatible stack heights: 0 vs 1
		//IL_02d7->IL0238: Incompatible stack heights: 2 vs 1
		//IL_02e7->IL0195: Incompatible stack heights: 0 vs 1
		//IL_00bd->IL0081: Incompatible stack heights: 5 vs 3
		//IL_010b->IL01de: Incompatible stack heights: 0 vs 1
		//IL_03f3->IL036e: Incompatible stack heights: 2 vs 1
		//IL_03f8->IL01dd: Incompatible stack heights: 0 vs 1
		//IL_02e2->IL0238: Incompatible stack heights: 2 vs 1
		//IL_0238->IL0238: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0081: Incompatible stack heights: 5 vs 3
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				while (true)
				{
					IL_00f0:
					_ = ref obj;
					if (EqualityComparer<_00212>.Default == null)
					{
						while (true)
						{
							switch (2)
							{
							default:
								((_003C_003Ef__AnonymousType0<>)32767).GetHashCode();
								_ = 3;
								if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
								{
									_ = 0;
								}
								continue;
							case 1:
								break;
							case 3:
								goto IL_00f0;
							case 2:
								goto end_IL_00f0;
							}
							break;
						}
					}
					_ = ref obj;
					/*Error near IL_00ca: Member reference must be method, but was: Field*/;
					continue;
					end_IL_00f0:
					break;
				}
				goto case 4;
			case 1:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)this).url;
				/*Error near IL_016f: Member reference must be method, but was: Field*/;
			case 6:
				((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_019c: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_019c: Stack underflow*/, (_003Cpayload_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Ccontext_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)this);
				((_003C_003Ef__AnonymousType2<, , , >)((EqualityComparer<_00213>)/*Error near IL_01a1: Stack underflow*/).Equals((_00213?)/*Error near IL_01a1: Stack underflow*/, (_00213?)/*Error near IL_01a1: Stack underflow*/)).GetHashCode();
				_ = 5;
				break;
			case 7:
				((_003C_003Ef__AnonymousType2<, , , >)(object)this).ToString();
				/*Error near IL_01b7: Member reference must be method, but was: Field*/;
			case 3:
				return;
			case 4:
				_ = ((_003C_003Ef__AnonymousType3<, >)(object)this).sid;
				/*Error near IL_01e5: Member reference must be method, but was: Field*/;
			default:
				while (true)
				{
					IL_029a:
					int num2;
					if (MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (SearchValues<T>)(&obj)) == 0)
					{
						num2 = 4;
						goto IL_0238;
					}
					goto IL_0256;
					IL_0238:
					while (true)
					{
						switch (num2)
						{
						case 4:
							break;
						case 3:
							goto IL_0256;
						case 1:
							((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)EntityLaunchGameProxy.ReflectAlphabeticProcessor).CreateInstance();
							obj = 2;
							continue;
						case 2:
							goto IL_029a;
						default:
							((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)((GameProxy)obj)._pinger).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)32767);
							_ = 0;
							if (((GameProxy)(object)GameProxy.OnlineClients).Name__BackingField == null)
							{
								_ = 1;
							}
							continue;
						}
						break;
					}
					break;
					IL_0256:
					((RegexRunnerFactory)(&obj))._002Ector();
					obj = (object)/*Error near IL_025f: Stack underflow*/;
					num2 = 0;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField == 0)
					{
						num2 = 0;
					}
					goto IL_0238;
				}
				goto case 6;
			case 9:
				while (true)
				{
					IL_03b0:
					int num;
					if (((EqualityComparer<Type>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((Type)(&obj)) == 0)
					{
						num = 2;
						if (((GameProxy)GameProxy.BlockIrcMessages).WorkerGroup__BackingField != null)
						{
							num = 3;
						}
						goto IL_036e;
					}
					goto IL_0388;
					IL_0388:
					obj = ((StringBuilder)/*Error near IL_038f: Stack underflow*/).Append((object?)(&obj));
					num = 1;
					if ((object)((GameProxy)GameProxy.Section__BackingField).Socks5 == null)
					{
						num = 1;
					}
					goto IL_036e;
					IL_036e:
					while (true)
					{
						switch (num)
						{
						case 3:
							return;
						case 2:
							goto IL_03b0;
						case 1:
							_ = (EntitySocks5Account?)obj == (EntitySocks5Account?)32767;
							_ = 2;
							continue;
						}
						break;
					}
					goto IL_0388;
				}
			case 5:
				((EntitySocks5Account)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((EntitySocks5Account)(object)this);
				obj = EqualityComparer<int>.Default;
				_ = 2;
				break;
			case 8:
				((EntitySocks5)P_0)._002Ector((string)(object)this, EntitySocks5Account.ReflectScopePolicy() ? 1 : 0, (EntitySocks5Account?)(object)EqualityComparer<EntitySocks5Account>.Default);
				_ = 1;
				if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this != null)
				{
					_ = 7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00瀀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779351, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00爀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779350, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00琀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_0209: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got Ref
		//IL_012e: Expected Obj, but got I4
		//IL_0133: Expected VT, but got I4
		//IL_015a: Expected Obj, but got VT
		//IL_022b: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got VT
		//IL_0185: Expected Obj, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0147->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0164->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_026c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0228->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0152->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01af->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 18;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj = ((_003C_003Ef__AnonymousType0<>)P_0).GetHashCode();
					obj2 = 8;
					continue;
				case 12:
				case 15:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 16;
						continue;
					}
					goto case 13;
				case 13:
					((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
					_ = 32767;
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = new { };
					/*Error near IL_00e9: Member reference must be method, but was: Field*/;
				case 2:
					obj++;
					obj2 = 11;
					continue;
				case 7:
				case 10:
					((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this);
					((EqualityComparer<_00211>)P_0).GetHashCode((_00211)((_003C_003Ef__AnonymousType1<, , >)32767).GetHashCode());
					_ = 2;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						_ = 0;
					}
					continue;
				case 16:
					obj = ((_003C_003Ef__AnonymousType2<, , , >)P_0).url;
					obj2 = 9;
					continue;
				case 19:
					return;
				case 18:
					break;
				case 20:
					obj++;
					obj2 = 0;
					if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField != null)
					{
						obj2 = 0;
					}
					continue;
				case 1:
				case 11:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						return;
					}
					obj2 = 7;
					continue;
				case 9:
					obj = 0;
					obj2 = 14;
					continue;
				case 8:
					obj = 0;
					obj2 = 1;
					if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
					{
						obj2 = 1;
					}
					continue;
				case 17:
					obj = 0;
					obj2 = 12;
					if (EntitySocks5.DecorateDynamicModule != null)
					{
						obj2 = 15;
					}
					continue;
				default:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 3;
						continue;
					}
					goto case 4;
				case 3:
				case 5:
					_ = ((_003C_003Ef__AnonymousType3<, >)(object)this).entry;
					_ = ((_003C_003Ef__AnonymousType3<, >)32767).sid;
					/*Error near IL_027d: Member reference must be method, but was: Field*/;
				case 6:
					obj++;
					obj2 = 12;
					continue;
				}
				break;
			}
			obj = ((_003C_003Ef__AnonymousType2<, , , >)P_0).payload;
			obj = 17;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00甀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779345, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
