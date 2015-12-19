//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace CardFlight {
	[Protocol (Name = "customEntryDelegate", WrapperType = typeof (customEntryDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextField", Selector = "customTextField:shouldChangeCharactersInRange:replacementString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextFieldDidBeginEditing", Selector = "customTextFieldDidBeginEditing:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextFieldDidEndEditing", Selector = "customTextFieldDidEndEditing:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextFieldShouldBeginEditing", Selector = "customTextFieldShouldBeginEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextFieldShouldClear", Selector = "customTextFieldShouldClear:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomTextFieldShouldReturn", Selector = "customTextFieldShouldReturn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	public interface IcustomEntryDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class customEntryDelegate_Extensions {
		[CompilerGenerated]
		public static bool CustomTextField (this IcustomEntryDelegate This, global::System.nint textFieldTag, NSRange range, string @string)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			var nsstring = NSString.CreateNative (@string);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_nint_NSRange_IntPtr (This.Handle, Selector.GetHandle ("customTextField:shouldChangeCharactersInRange:replacementString:"), textFieldTag, range, nsstring);
			NSString.ReleaseNative (nsstring);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void CustomTextFieldDidBeginEditing (this IcustomEntryDelegate This, global::System.nint textFieldTag)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("customTextFieldDidBeginEditing:"), textFieldTag);
		}
		
		[CompilerGenerated]
		public static void CustomTextFieldDidEndEditing (this IcustomEntryDelegate This, global::System.nint textFieldTag)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("customTextFieldDidEndEditing:"), textFieldTag);
		}
		
		[CompilerGenerated]
		public static bool CustomTextFieldShouldBeginEditing (this IcustomEntryDelegate This, global::System.nint textFieldTag)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (This.Handle, Selector.GetHandle ("customTextFieldShouldBeginEditing:"), textFieldTag);
		}
		
		[CompilerGenerated]
		public static bool CustomTextFieldShouldClear (this IcustomEntryDelegate This, global::System.nint textFieldTag)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (This.Handle, Selector.GetHandle ("customTextFieldShouldClear:"), textFieldTag);
		}
		
		[CompilerGenerated]
		public static bool CustomTextFieldShouldReturn (this IcustomEntryDelegate This, global::System.nint textFieldTag)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (This.Handle, Selector.GetHandle ("customTextFieldShouldReturn:"), textFieldTag);
		}
		
	}
	
	internal sealed class customEntryDelegateWrapper : BaseWrapper, IcustomEntryDelegate {
		public customEntryDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public customEntryDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardFlight {
	[Protocol]
	[Register("customEntryDelegate", false)]
	[Model]
	public unsafe partial class customEntryDelegate : NSObject, IcustomEntryDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public customEntryDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected customEntryDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal customEntryDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("customTextField:shouldChangeCharactersInRange:replacementString:")]
		[CompilerGenerated]
		public virtual bool CustomTextField (global::System.nint textFieldTag, NSRange range, string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customTextFieldDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void CustomTextFieldDidBeginEditing (global::System.nint textFieldTag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customTextFieldDidEndEditing:")]
		[CompilerGenerated]
		public virtual void CustomTextFieldDidEndEditing (global::System.nint textFieldTag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customTextFieldShouldBeginEditing:")]
		[CompilerGenerated]
		public virtual bool CustomTextFieldShouldBeginEditing (global::System.nint textFieldTag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customTextFieldShouldClear:")]
		[CompilerGenerated]
		public virtual bool CustomTextFieldShouldClear (global::System.nint textFieldTag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customTextFieldShouldReturn:")]
		[CompilerGenerated]
		public virtual bool CustomTextFieldShouldReturn (global::System.nint textFieldTag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class customEntryDelegate */
}
