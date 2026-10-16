using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;
using CommunityToolkit.WinUI.Controls;
using Mass.WinUI.Controls;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
public sealed class MainWindow : Window, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginOverlay;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HideTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginNotificationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginSegmented;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	private static object ReflectResponsiveCollection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWindow()
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCallVirt(CallVirt inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7667
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2211
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
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
	public void SwitchToMainMode()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTitleBarPreferredTheme(FrameworkElement fe)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00挀(fe);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppWindowClosing(object sender, object args)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00椀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00怀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00栀((uint)connectionId, target);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PlayAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainWindow ReflectCombinedChooser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775714, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀()
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
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775715, new IntPtr(2737323020556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00崀()
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775712, new IntPtr(2737323019516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00怀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008f: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					return;
				}
				obj2 = 2;
				break;
			case 5:
				return;
			case 4:
				return;
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = 1;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = new MarshalInspectable<object>((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_008a: Stack underflow*/, (uint)/*Error near IL_008a: Stack underflow*/, (nint)/*Error near IL_008a: Stack underflow*/, (uint*)/*Error near IL_008a: Stack underflow*/));
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)0);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775713, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00戀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775726, new IntPtr(2737323036156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00挀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_015b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 4:
				if ((nint)obj != 2)
				{
					obj2 = 9;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
					{
						obj2 = 7;
					}
					continue;
				}
				goto case 7;
			case 2:
				/*Error near IL_0089: Member reference must be method, but was: Field*/;
			case 3:
				/*Error near IL_00b3: Stack underflow*/((object[])/*Error near IL_00b3: Stack underflow*/, (nint)this);
				((ValueTuple<int, nint>*)/*Error near IL_00b8: Stack underflow*/)->_002Ector((int)/*Error near IL_00b8: Stack underflow*/, (nint)/*Error near IL_00b8: Stack underflow*/);
				obj = (object)/*Error near IL_00ba: Stack underflow*/;
				obj2 = 2;
				continue;
			case 9:
			case 11:
				obj = 1;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				continue;
			case 7:
				obj = 3;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 10;
				}
				continue;
			case 5:
				if ((nint)obj != 1)
				{
					obj2 = 4;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)obj);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 0;
				}
				continue;
			case 6:
				break;
			}
			obj = 2;
			obj2 = 8;
			if (IEnumerable_object.ReflectSetAttribute != null)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775727, new IntPtr(2737323026796L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00攀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775724, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00最(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775725, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00栀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_018e: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0198->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0177->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
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
			case 9:
				((AsyncVoidMethodBuilder*)/*Error near IL_0089: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_008e: Stack underflow*/;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				continue;
			case 5:
				goto IL_00ad;
			case 3:
				goto IL_00e5;
			case 10:
				goto IL_00fb;
			case 2:
				switch (P_0)
				{
				case 5u:
					break;
				case 3u:
					goto IL_00ad;
				case 6u:
					goto IL_00e5;
				case 2u:
					goto IL_00fb;
				default:
					goto IL_013c;
				case 4u:
					goto end_IL_0026;
				}
				goto case 9;
			case 6:
				return;
			default:
				IEnumerator_System_IDisposable._initialized = 1;
				obj2 = 6;
				if (IEnumerable_System_IDisposable._initialized == 0)
				{
					obj2 = 4;
				}
				continue;
			case 4:
				break;
				IL_00ad:
				IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_1);
				obj2 = 8;
				continue;
				IL_013c:
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 0;
				}
				continue;
				IL_00fb:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = CastExtensions.As<Segmented>(P_1);
				obj2 = 11;
				continue;
				IL_00e5:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = CastExtensions.As<NotificationPanel>(P_1);
				obj2 = 7;
				continue;
				end_IL_0026:
				break;
			}
			IEnumerable_object._initialized = (nint)((XamlUserType)this).BoxType<DateTime>(P_1);
			obj2 = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00椀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0059->IL0026: Incompatible stack heights: 6 vs 1
		//IL_0064->IL0026: Incompatible stack heights: 6 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				_ = IEnumerator_object.Initialized;
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
