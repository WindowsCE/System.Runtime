﻿#if DEBUG

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Text;
using System.Threading;

//  SYSTEM  -------------------------------------------------------------------
[assembly: TypeForwardedTo(typeof(Action))]                             // OK
[assembly: TypeForwardedTo(typeof(Action<>))]                           // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,>))]                 // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,>))]                // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,,>))]               // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,,,>))]              // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,,,,>))]             // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,,,,,>))]            // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,,,,,,,,>))]           // OK
[assembly: TypeForwardedTo(typeof(Action<,>))]                          // OK
[assembly: TypeForwardedTo(typeof(Action<,,>))]                         // OK
[assembly: TypeForwardedTo(typeof(Action<,,,>))]                        // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,>))]                      // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,>))]                     // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,>))]                    // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,>))]                   // OK
[assembly: TypeNotForwarded(typeof(Action<,,,,,,,,>))]                  // OK
[assembly: TypeForwardedTo(typeof(Activator))]                          // OK
[assembly: TypeNotForwarded(typeof(Activator2))]                        // OK
[assembly: TypeForwardedTo(typeof(ArgumentException))]                  // OK
[assembly: TypeNotForwarded(typeof(ArgumentException2))]                // OK
[assembly: TypeForwardedTo(typeof(ArgumentNullException))]              // OK
[assembly: TypeNotForwarded(typeof(ArgumentNullException2))]            // OK
[assembly: TypeForwardedTo(typeof(ArgumentOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(ArithmeticException))]
[assembly: TypeForwardedTo(typeof(Array))]
[assembly: TypeForwardedTo(typeof(ArraySegment<>))]
[assembly: TypeForwardedTo(typeof(ArrayTypeMismatchException))]
[assembly: TypeForwardedTo(typeof(AsyncCallback))]
[assembly: TypeForwardedTo(typeof(Attribute))]
[assembly: TypeForwardedTo(typeof(AttributeTargets))]
[assembly: TypeForwardedTo(typeof(AttributeUsageAttribute))]
[assembly: TypeForwardedTo(typeof(BadImageFormatException))]
[assembly: TypeForwardedTo(typeof(bool))]
[assembly: TypeForwardedTo(typeof(Buffer))]
[assembly: TypeForwardedTo(typeof(byte))]
[assembly: TypeForwardedTo(typeof(char))]
[assembly: TypeForwardedTo(typeof(CLSCompliantAttribute))]
[assembly: TypeForwardedTo(typeof(Comparison<>))]
[assembly: TypeForwardedTo(typeof(DateTime))]
[assembly: TypeForwardedTo(typeof(DateTimeKind))]
[assembly: TypeNotForwarded(typeof(DateTimeOffset))]                    // OK?
[assembly: TypeForwardedTo(typeof(DayOfWeek))]
[assembly: TypeForwardedTo(typeof(Decimal))]
[assembly: TypeForwardedTo(typeof(Delegate))]
[assembly: TypeForwardedTo(typeof(DivideByZeroException))]
[assembly: TypeForwardedTo(typeof(double))]
[assembly: TypeForwardedTo(typeof(Enum))]
[assembly: TypeForwardedTo(typeof(EventArgs))]
[assembly: TypeForwardedTo(typeof(EventHandler))]
[assembly: TypeForwardedTo(typeof(EventHandler<>))]
[assembly: TypeForwardedTo(typeof(Exception))]
[assembly: TypeForwardedTo(typeof(FlagsAttribute))]
[assembly: TypeForwardedTo(typeof(FormatException))]
[assembly: TypeForwardedTo(typeof(Func<>))]                             // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,>))]                   // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,>))]                  // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,>))]                 // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,,>))]                // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,,,>))]               // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,,,,>))]              // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,,,,,>))]             // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,,,,,,,,,>))]            // OK
[assembly: TypeForwardedTo(typeof(Func<,>))]                            // OK
[assembly: TypeForwardedTo(typeof(Func<,,>))]                           // OK
[assembly: TypeForwardedTo(typeof(Func<,,,>))]                          // OK
[assembly: TypeForwardedTo(typeof(Func<,,,,>))]                         // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,>))]                       // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,>))]                      // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,>))]                     // OK
[assembly: TypeNotForwarded(typeof(Func<,,,,,,,,>))]                    // OK
[assembly: TypeForwardedTo(typeof(GC))]                                 // OK
[assembly: TypeNotForwarded(typeof(GC2))]                               // OK
[assembly: TypeNotForwarded(typeof(GCCollectionMode))]                  // OK
[assembly: TypeForwardedTo(typeof(Guid))]
[assembly: TypeForwardedTo(typeof(IAsyncResult))]
[assembly: TypeForwardedTo(typeof(IComparable))]
[assembly: TypeForwardedTo(typeof(IComparable<>))]
[assembly: TypeForwardedTo(typeof(IConvertible))]
[assembly: TypeForwardedTo(typeof(ICustomFormatter))]
[assembly: TypeForwardedTo(typeof(IDisposable))]
[assembly: TypeForwardedTo(typeof(IEquatable<>))]
[assembly: TypeForwardedTo(typeof(IFormatProvider))]
[assembly: TypeForwardedTo(typeof(IFormattable))]
[assembly: TypeForwardedTo(typeof(IndexOutOfRangeException))]
[assembly: TypeForwardedTo(typeof(short))]
[assembly: TypeForwardedTo(typeof(int))]
[assembly: TypeForwardedTo(typeof(long))]
[assembly: TypeForwardedTo(typeof(IntPtr))]
[assembly: TypeForwardedTo(typeof(InvalidCastException))]
[assembly: TypeForwardedTo(typeof(InvalidOperationException))]
[assembly: TypeForwardedTo(typeof(InvalidProgramException))]
[assembly: TypeNotForwarded(typeof(InvalidTimeZoneException))]
[assembly: TypeNotForwarded(typeof(IObservable<>))]                     // OK
[assembly: TypeNotForwarded(typeof(IObserver<>))]                       // OK
[assembly: TypeNotForwarded(typeof(IProgress<>))]                       // OK
[assembly: TypeNotForwarded(typeof(Lazy<>))]                            // OK
[assembly: TypeForwardedTo(typeof(MemberAccessException))]
[assembly: TypeForwardedTo(typeof(MethodAccessException))]
[assembly: TypeForwardedTo(typeof(MissingFieldException))]
[assembly: TypeForwardedTo(typeof(MissingMemberException))]
[assembly: TypeForwardedTo(typeof(MissingMethodException))]
[assembly: TypeForwardedTo(typeof(MTAThreadAttribute))]
[assembly: TypeForwardedTo(typeof(MulticastDelegate))]
[assembly: TypeForwardedTo(typeof(NotImplementedException))]
[assembly: TypeForwardedTo(typeof(NotSupportedException))]
[assembly: TypeForwardedTo(typeof(Nullable))]
[assembly: TypeForwardedTo(typeof(Nullable<>))]
[assembly: TypeForwardedTo(typeof(NullReferenceException))]
[assembly: TypeForwardedTo(typeof(object))]
[assembly: TypeForwardedTo(typeof(ObjectDisposedException))]
[assembly: TypeForwardedTo(typeof(ObsoleteAttribute))]
[assembly: TypeForwardedTo(typeof(OutOfMemoryException))]
[assembly: TypeForwardedTo(typeof(OverflowException))]
[assembly: TypeForwardedTo(typeof(ParamArrayAttribute))]
[assembly: TypeForwardedTo(typeof(PlatformNotSupportedException))]
[assembly: TypeForwardedTo(typeof(Predicate<>))]
[assembly: TypeForwardedTo(typeof(RankException))]
//  SYSTEM.COLLECTIONS  -------------------------------------------------------
[assembly: TypeForwardedTo(typeof(DictionaryEntry))]
[assembly: TypeForwardedTo(typeof(ICollection))]
[assembly: TypeForwardedTo(typeof(IComparer))]
[assembly: TypeForwardedTo(typeof(IDictionary))]
[assembly: TypeForwardedTo(typeof(IDictionaryEnumerator))]
[assembly: TypeForwardedTo(typeof(IEnumerable))]
[assembly: TypeForwardedTo(typeof(IEnumerator))]
[assembly: TypeForwardedTo(typeof(IEqualityComparer))]
[assembly: TypeForwardedTo(typeof(IList))]
[assembly: TypeNotForwarded(typeof(IStructuralComparable))]             // OK
[assembly: TypeNotForwarded(typeof(IStructuralEquatable))]              // OK
//  SYSTEM.COLLECTIONS.GENERIC  -----------------------------------------------
[assembly: TypeForwardedTo(typeof(ICollection<>))]
[assembly: TypeForwardedTo(typeof(IComparer<>))]
[assembly: TypeForwardedTo(typeof(IDictionary<,>))]
[assembly: TypeForwardedTo(typeof(IEnumerable<>))]
[assembly: TypeForwardedTo(typeof(IEnumerator<>))]
[assembly: TypeForwardedTo(typeof(IEqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(IList<>))]
[assembly: TypeNotForwarded(typeof(IReadOnlyCollection<>))]             // OK
[assembly: TypeNotForwarded(typeof(IReadOnlyDictionary<,>))]            // OK
[assembly: TypeNotForwarded(typeof(IReadOnlyList<>))]                   // OK
[assembly: TypeNotForwarded(typeof(ISet<>))]                            // OK
[assembly: TypeForwardedTo(typeof(KeyNotFoundException))]
[assembly: TypeForwardedTo(typeof(KeyValuePair<,>))]
//  SYSTEM.COLLECTIONS.OBJECTMODEL  -------------------------------------------
[assembly: TypeForwardedTo(typeof(Collection<>))]
[assembly: TypeForwardedTo(typeof(ReadOnlyCollection<>))]
//  SYSTEM.COMPONENTMODEL   ---------------------------------------------------
[assembly: TypeForwardedTo(typeof(DefaultValueAttribute))]
[assembly: TypeForwardedTo(typeof(EditorBrowsableAttribute))]
[assembly: TypeForwardedTo(typeof(EditorBrowsableState))]
//  SYSTEM.DIAGNOSTICS  -------------------------------------------------------
[assembly: TypeForwardedTo(typeof(ConditionalAttribute))]
[assembly: TypeForwardedTo(typeof(DebuggableAttribute))]
//[assembly: TypeForwardedTo(typeof(DebuggableAttribute.DebuggingModes))]
//  SYSTEM.GLOBALIZATION    ---------------------------------------------------
[assembly: TypeForwardedTo(typeof(DateTimeStyles))]
[assembly: TypeForwardedTo(typeof(NumberStyles))]
[assembly: TypeNotForwarded(typeof(TimeSpanStyles))]
//  SYSTEM.IO   ---------------------------------------------------------------
[assembly: TypeForwardedTo(typeof(DirectoryNotFoundException))]
//[assembly: TypeForwardedTo(typeof(FileLoadException))]                // OK
[assembly: TypeForwardedTo(typeof(FileNotFoundException))]
[assembly: TypeForwardedTo(typeof(IOException))]
[assembly: TypeForwardedTo(typeof(PathTooLongException))]

//[assembly: TypeForwardedTo(typeof(FieldAccessException))]                 // NA
//[assembly: TypeForwardedTo(typeof(FormattableString))]                    // NA
//[assembly: TypeForwardedTo(typeof(InsufficientExecutionStackException))]  // NA

[assembly: TypeForwardedTo(typeof(Lazy<,>))]
[assembly: TypeForwardedTo(typeof(AssemblyCompanyAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyConfigurationAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyCopyrightAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyCultureAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDefaultAliasAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDelaySignAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyDescriptionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyFileVersionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyFlagsAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyInformationalVersionAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyKeyFileAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyKeyNameAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyMetadataAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyNameFlags))]
[assembly: TypeForwardedTo(typeof(AssemblyProductAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblySignatureKeyAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyTitleAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyTrademarkAttribute))]
[assembly: TypeForwardedTo(typeof(AssemblyVersionAttribute))]
[assembly: TypeForwardedTo(typeof(DefaultMemberAttribute))]
[assembly: TypeForwardedTo(typeof(ProcessorArchitecture))]
[assembly: TypeForwardedTo(typeof(AccessedThroughPropertyAttribute))]
[assembly: TypeForwardedTo(typeof(AsyncStateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(CallerFilePathAttribute))]
[assembly: TypeForwardedTo(typeof(CallerLineNumberAttribute))]
[assembly: TypeForwardedTo(typeof(CallerMemberNameAttribute))]
[assembly: TypeForwardedTo(typeof(CompilationRelaxationsAttribute))]
[assembly: TypeForwardedTo(typeof(CompilerGeneratedAttribute))]
[assembly: TypeForwardedTo(typeof(ConditionalWeakTable<,>))]
[assembly: TypeForwardedTo(typeof(ConditionalWeakTable<,>.CreateValueCallback))]
[assembly: TypeForwardedTo(typeof(CustomConstantAttribute))]
[assembly: TypeForwardedTo(typeof(DateTimeConstantAttribute))]
[assembly: TypeForwardedTo(typeof(DecimalConstantAttribute))]
[assembly: TypeForwardedTo(typeof(DisablePrivateReflectionAttribute))]
[assembly: TypeForwardedTo(typeof(ExtensionAttribute))]
[assembly: TypeForwardedTo(typeof(FixedBufferAttribute))]
[assembly: TypeForwardedTo(typeof(FormattableStringFactory))]
[assembly: TypeForwardedTo(typeof(IndexerNameAttribute))]
[assembly: TypeForwardedTo(typeof(InternalsVisibleToAttribute))]
[assembly: TypeForwardedTo(typeof(IsConst))]
[assembly: TypeForwardedTo(typeof(IStrongBox))]
[assembly: TypeForwardedTo(typeof(IsVolatile))]
[assembly: TypeForwardedTo(typeof(IteratorStateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(MethodImplAttribute))]
[assembly: TypeForwardedTo(typeof(MethodImplOptions))]
[assembly: TypeForwardedTo(typeof(ReferenceAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(RuntimeCompatibilityAttribute))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers.CleanupCode))]
[assembly: TypeForwardedTo(typeof(RuntimeHelpers.TryCode))]
[assembly: TypeForwardedTo(typeof(StateMachineAttribute))]
[assembly: TypeForwardedTo(typeof(StrongBox<>))]
[assembly: TypeForwardedTo(typeof(TypeForwardedFromAttribute))]
[assembly: TypeNotForwarded(typeof(TypeForwardedToAttribute))]          // OK
[assembly: TypeForwardedTo(typeof(UnsafeValueTypeAttribute))]
[assembly: TypeForwardedTo(typeof(ExceptionDispatchInfo))]
[assembly: TypeForwardedTo(typeof(GCLargeObjectHeapCompactionMode))]
[assembly: TypeForwardedTo(typeof(GCLatencyMode))]
[assembly: TypeForwardedTo(typeof(GCSettings))]
[assembly: TypeForwardedTo(typeof(CharSet))]
[assembly: TypeForwardedTo(typeof(ComVisibleAttribute))]
[assembly: TypeForwardedTo(typeof(FieldOffsetAttribute))]
[assembly: TypeForwardedTo(typeof(LayoutKind))]
[assembly: TypeForwardedTo(typeof(OutAttribute))]
[assembly: TypeForwardedTo(typeof(StructLayoutAttribute))]
[assembly: TypeForwardedTo(typeof(TargetFrameworkAttribute))]
[assembly: TypeForwardedTo(typeof(RuntimeFieldHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeMethodHandle))]
[assembly: TypeForwardedTo(typeof(RuntimeTypeHandle))]
[assembly: TypeForwardedTo(typeof(sbyte))]
[assembly: TypeForwardedTo(typeof(AllowPartiallyTrustedCallersAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityCriticalAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityException))]
[assembly: TypeForwardedTo(typeof(SecuritySafeCriticalAttribute))]
[assembly: TypeForwardedTo(typeof(SecurityTransparentAttribute))]
[assembly: TypeForwardedTo(typeof(VerificationException))]
[assembly: TypeForwardedTo(typeof(float))]
[assembly: TypeForwardedTo(typeof(STAThreadAttribute))]
[assembly: TypeForwardedTo(typeof(string))]
[assembly: TypeForwardedTo(typeof(StringComparison))]
[assembly: TypeForwardedTo(typeof(StringSplitOptions))]
[assembly: TypeForwardedTo(typeof(StringBuilder))]
[assembly: TypeForwardedTo(typeof(LazyThreadSafetyMode))]
[assembly: TypeForwardedTo(typeof(Timeout))]
[assembly: TypeForwardedTo(typeof(WaitHandle))]
[assembly: TypeForwardedTo(typeof(ThreadStaticAttribute))]
[assembly: TypeForwardedTo(typeof(TimeoutException))]
[assembly: TypeForwardedTo(typeof(TimeSpan))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo.AdjustmentRule))]
[assembly: TypeForwardedTo(typeof(TimeZoneInfo.TransitionTime))]
[assembly: TypeForwardedTo(typeof(Tuple))]
[assembly: TypeForwardedTo(typeof(Tuple<>))]
[assembly: TypeForwardedTo(typeof(Tuple<,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,,,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,,,,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,,,,,>))]
[assembly: TypeForwardedTo(typeof(Tuple<,,,,,,,>))]
[assembly: TypeForwardedTo(typeof(Type))]
[assembly: TypeForwardedTo(typeof(TypeAccessException))]
[assembly: TypeForwardedTo(typeof(TypeCode))]
[assembly: TypeForwardedTo(typeof(TypeInitializationException))]
[assembly: TypeForwardedTo(typeof(TypeLoadException))]
[assembly: TypeForwardedTo(typeof(ushort))]
[assembly: TypeForwardedTo(typeof(uint))]
[assembly: TypeForwardedTo(typeof(ulong))]
[assembly: TypeForwardedTo(typeof(UIntPtr))]
[assembly: TypeForwardedTo(typeof(UnauthorizedAccessException))]
[assembly: TypeForwardedTo(typeof(Uri))]
[assembly: TypeForwardedTo(typeof(UriComponents))]
[assembly: TypeForwardedTo(typeof(UriFormat))]
[assembly: TypeForwardedTo(typeof(UriFormatException))]
[assembly: TypeForwardedTo(typeof(UriHostNameType))]
[assembly: TypeForwardedTo(typeof(UriKind))]
[assembly: TypeForwardedTo(typeof(ValueType))]
[assembly: TypeForwardedTo(typeof(Version))]
[assembly: TypeForwardedTo(typeof(void))]
[assembly: TypeForwardedTo(typeof(WeakReference))]
[assembly: TypeForwardedTo(typeof(WeakReference<>))]

#endif
