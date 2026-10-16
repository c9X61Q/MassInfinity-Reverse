using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IReadOnlyList_object
{
	private static readonly nint _initialized = (int)Init();

	private static object ReflectLogicalAttribute;

	internal static bool Initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte Init()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetAt_0(nint thisPtr, uint index, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ꘀ(thisPtr, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_IndexOf_2(nint thisPtr, nint value, uint* index, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00관(thisPtr, value, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint startIndex, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(thisPtr, startIndex, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Size_1(nint thisPtr, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_AB00(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSimpleAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IReadOnlyList_object DecorateControllableAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775445, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3166
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775442, new IntPtr(2737316771052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꌀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775443, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		//IL_00d3: Expected I4, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_01a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010f->IL00b8: Incompatible stack heights: 2 vs 1
		//IL_011a->IL00b8: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				*P_4 = 0u;
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = 0;
				obj2 = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 4:
			{
				*((int, nint)*)P_0 = ((int)P_1, (nint)(&obj));
				obj = (object)/*Error near IL_0095: Stack underflow*/;
				int num = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						*P_4 = (uint)(int)obj;
						num = 1;
						if (IReadOnlyList_System_IDisposable._initialized != 0)
						{
							num = 2;
						}
						continue;
					case 1:
						IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)obj, (uint)P_3);
						_ = 0;
						if (IEnumerator_System_IDisposable._initialized == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				goto case 1;
			}
			case 1:
				return 0u;
			default:
				obj = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0197: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_2, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)new IEnumerableMethods<INotifyPropertyChanged>((IntPtr)P_3));
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775440, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꘀ(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_0144->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = null;
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				/*Error near IL_0065: Member reference must be method, but was: Field*/;
			default:
				return 0u;
			case 1:
				*P_2 = 0;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775441, new IntPtr(2737316772092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00꤀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775454, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00_AB00(nint P_0, uint* P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		//IL_00cb: Expected I4, but got Obj
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return 0u;
			case 2:
				*P_1 = 0u;
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = 0;
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					obj2 = 2;
				}
				break;
			default:
			{
				*((int, nint)*)(nint)/*Error near IL_0090: Stack underflow*/ = ((int)/*Error near IL_0090: Stack underflow*/, P_0);
				obj = (object)/*Error near IL_0092: Stack underflow*/;
				int num = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						*P_1 = (uint)(int)obj;
						num = 1;
						if (IReadOnlyList_System_IDisposable._initialized == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
				goto case 1;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00가(nint P_0, uint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775455, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00관(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0055->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0177->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016a->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				*P_2 = 0u;
				obj2 = 5;
				break;
			case 1:
				obj = 0;
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				/*Error near IL_007a: Member reference must be method, but was: Field*/;
			case 4:
				obj = 0;
				obj2 = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					obj2 = 2;
				}
				break;
			case 5:
				*P_3 = 0;
				obj2 = 4;
				break;
			case 3:
				return 0u;
			}
		}
	}
}
