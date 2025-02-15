//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Libsdl.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']"
	[global::Android.Runtime.Register ("org/libsdl/app/HIDDeviceManager", DoNotGenerateAcw=true)]
	public partial class HIDDeviceManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/libsdl/app/HIDDeviceManager", typeof (HIDDeviceManager));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected HIDDeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetContext));
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='acquire' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("acquire", "(Landroid/content/Context;)Lorg/libsdl/app/HIDDeviceManager;", "")]
		public static unsafe global::Org.Libsdl.App.HIDDeviceManager Acquire (global::Android.Content.Context context)
		{
			const string __id = "acquire.(Landroid/content/Context;)Lorg/libsdl/app/HIDDeviceManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_chromebookConnectionHandler;
#pragma warning disable 0169
		static Delegate GetChromebookConnectionHandlerHandler ()
		{
			if (cb_chromebookConnectionHandler == null)
				cb_chromebookConnectionHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ChromebookConnectionHandler));
			return cb_chromebookConnectionHandler;
		}

		static void n_ChromebookConnectionHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChromebookConnectionHandler ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='chromebookConnectionHandler' and count(parameter)=0]"
		[Register ("chromebookConnectionHandler", "()V", "GetChromebookConnectionHandlerHandler")]
		public virtual unsafe void ChromebookConnectionHandler ()
		{
			const string __id = "chromebookConnectionHandler.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_closeDevice_I;
#pragma warning disable 0169
		static Delegate GetCloseDevice_IHandler ()
		{
			if (cb_closeDevice_I == null)
				cb_closeDevice_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_CloseDevice_I));
			return cb_closeDevice_I;
		}

		static void n_CloseDevice_I (IntPtr jnienv, IntPtr native__this, int deviceID)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseDevice (deviceID);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='closeDevice' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("closeDevice", "(I)V", "GetCloseDevice_IHandler")]
		public virtual unsafe void CloseDevice (int deviceID)
		{
			const string __id = "closeDevice.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deviceID);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetConnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_connectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_connectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_ConnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_));
			return cb_connectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
		}

		static bool n_ConnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ConnectBluetoothDevice (bluetoothDevice);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='connectBluetoothDevice' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("connectBluetoothDevice", "(Landroid/bluetooth/BluetoothDevice;)Z", "GetConnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe bool ConnectBluetoothDevice (global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "connectBluetoothDevice.(Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

		static Delegate cb_disconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetDisconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_disconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_disconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DisconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_));
			return cb_disconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
		}

		static void n_DisconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectBluetoothDevice (bluetoothDevice);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='disconnectBluetoothDevice' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("disconnectBluetoothDevice", "(Landroid/bluetooth/BluetoothDevice;)V", "GetDisconnectBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe void DisconnectBluetoothDevice (global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "disconnectBluetoothDevice.(Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

		static Delegate cb_getDeviceIDForIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeviceIDForIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_getDeviceIDForIdentifier_Ljava_lang_String_ == null)
				cb_getDeviceIDForIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetDeviceIDForIdentifier_Ljava_lang_String_));
			return cb_getDeviceIDForIdentifier_Ljava_lang_String_;
		}

		static int n_GetDeviceIDForIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var identifier = JNIEnv.GetString (native_identifier, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDeviceIDForIdentifier (identifier);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='getDeviceIDForIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeviceIDForIdentifier", "(Ljava/lang/String;)I", "GetGetDeviceIDForIdentifier_Ljava_lang_String_Handler")]
		public virtual unsafe int GetDeviceIDForIdentifier (string identifier)
		{
			const string __id = "getDeviceIDForIdentifier.(Ljava/lang/String;)I";
			IntPtr native_identifier = JNIEnv.NewString ((string)identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifier);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static Delegate cb_getFeatureReport_IarrayB;
#pragma warning disable 0169
		static Delegate GetGetFeatureReport_IarrayBHandler ()
		{
			if (cb_getFeatureReport_IarrayB == null)
				cb_getFeatureReport_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_Z (n_GetFeatureReport_IarrayB));
			return cb_getFeatureReport_IarrayB;
		}

		static bool n_GetFeatureReport_IarrayB (IntPtr jnienv, IntPtr native__this, int deviceID, IntPtr native_report)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var report = (byte[]) JNIEnv.GetArray (native_report, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.GetFeatureReport (deviceID, report);
			if (report != null)
				JNIEnv.CopyArray (report, native_report);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='getFeatureReport' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getFeatureReport", "(I[B)Z", "GetGetFeatureReport_IarrayBHandler")]
		public virtual unsafe bool GetFeatureReport (int deviceID, byte[] report)
		{
			const string __id = "getFeatureReport.(I[B)Z";
			IntPtr native_report = JNIEnv.NewArray (report);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (deviceID);
				__args [1] = new JniArgumentValue (native_report);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (report != null) {
					JNIEnv.CopyArray (native_report, report);
					JNIEnv.DeleteLocalRef (native_report);
				}
				global::System.GC.KeepAlive (report);
			}
		}

		static Delegate cb_initialize_ZZ;
#pragma warning disable 0169
		static Delegate GetInitialize_ZZHandler ()
		{
			if (cb_initialize_ZZ == null)
				cb_initialize_ZZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZZ_Z (n_Initialize_ZZ));
			return cb_initialize_ZZ;
		}

		static bool n_Initialize_ZZ (IntPtr jnienv, IntPtr native__this, bool usb, bool bluetooth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Initialize (usb, bluetooth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("initialize", "(ZZ)Z", "GetInitialize_ZZHandler")]
		public virtual unsafe bool Initialize (bool usb, bool bluetooth)
		{
			const string __id = "initialize.(ZZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (usb);
				__args [1] = new JniArgumentValue (bluetooth);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isSteamController_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetIsSteamController_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_isSteamController_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_isSteamController_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsSteamController_Landroid_bluetooth_BluetoothDevice_));
			return cb_isSteamController_Landroid_bluetooth_BluetoothDevice_;
		}

		static bool n_IsSteamController_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSteamController (bluetoothDevice);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='isSteamController' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("isSteamController", "(Landroid/bluetooth/BluetoothDevice;)Z", "GetIsSteamController_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe bool IsSteamController (global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "isSteamController.(Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

		static Delegate cb_openDevice_I;
#pragma warning disable 0169
		static Delegate GetOpenDevice_IHandler ()
		{
			if (cb_openDevice_I == null)
				cb_openDevice_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_OpenDevice_I));
			return cb_openDevice_I;
		}

		static bool n_OpenDevice_I (IntPtr jnienv, IntPtr native__this, int deviceID)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenDevice (deviceID);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='openDevice' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openDevice", "(I)Z", "GetOpenDevice_IHandler")]
		public virtual unsafe bool OpenDevice (int deviceID)
		{
			const string __id = "openDevice.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deviceID);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='release' and count(parameter)=1 and parameter[1][@type='org.libsdl.app.HIDDeviceManager']]"
		[Register ("release", "(Lorg/libsdl/app/HIDDeviceManager;)V", "")]
		public static unsafe void Release (global::Org.Libsdl.App.HIDDeviceManager manager)
		{
			const string __id = "release.(Lorg/libsdl/app/HIDDeviceManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (manager);
			}
		}

		static Delegate cb_sendFeatureReport_IarrayB;
#pragma warning disable 0169
		static Delegate GetSendFeatureReport_IarrayBHandler ()
		{
			if (cb_sendFeatureReport_IarrayB == null)
				cb_sendFeatureReport_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_SendFeatureReport_IarrayB));
			return cb_sendFeatureReport_IarrayB;
		}

		static int n_SendFeatureReport_IarrayB (IntPtr jnienv, IntPtr native__this, int deviceID, IntPtr native_report)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var report = (byte[]) JNIEnv.GetArray (native_report, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SendFeatureReport (deviceID, report);
			if (report != null)
				JNIEnv.CopyArray (report, native_report);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='sendFeatureReport' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("sendFeatureReport", "(I[B)I", "GetSendFeatureReport_IarrayBHandler")]
		public virtual unsafe int SendFeatureReport (int deviceID, byte[] report)
		{
			const string __id = "sendFeatureReport.(I[B)I";
			IntPtr native_report = JNIEnv.NewArray (report);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (deviceID);
				__args [1] = new JniArgumentValue (native_report);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (report != null) {
					JNIEnv.CopyArray (native_report, report);
					JNIEnv.DeleteLocalRef (native_report);
				}
				global::System.GC.KeepAlive (report);
			}
		}

		static Delegate cb_sendOutputReport_IarrayB;
#pragma warning disable 0169
		static Delegate GetSendOutputReport_IarrayBHandler ()
		{
			if (cb_sendOutputReport_IarrayB == null)
				cb_sendOutputReport_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_SendOutputReport_IarrayB));
			return cb_sendOutputReport_IarrayB;
		}

		static int n_SendOutputReport_IarrayB (IntPtr jnienv, IntPtr native__this, int deviceID, IntPtr native_report)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var report = (byte[]) JNIEnv.GetArray (native_report, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SendOutputReport (deviceID, report);
			if (report != null)
				JNIEnv.CopyArray (report, native_report);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='sendOutputReport' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("sendOutputReport", "(I[B)I", "GetSendOutputReport_IarrayBHandler")]
		public virtual unsafe int SendOutputReport (int deviceID, byte[] report)
		{
			const string __id = "sendOutputReport.(I[B)I";
			IntPtr native_report = JNIEnv.NewArray (report);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (deviceID);
				__args [1] = new JniArgumentValue (native_report);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (report != null) {
					JNIEnv.CopyArray (native_report, report);
					JNIEnv.DeleteLocalRef (native_report);
				}
				global::System.GC.KeepAlive (report);
			}
		}

		static Delegate cb_setFrozen_Z;
#pragma warning disable 0169
		static Delegate GetSetFrozen_ZHandler ()
		{
			if (cb_setFrozen_Z == null)
				cb_setFrozen_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetFrozen_Z));
			return cb_setFrozen_Z;
		}

		static void n_SetFrozen_Z (IntPtr jnienv, IntPtr native__this, bool frozen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Libsdl.App.HIDDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFrozen (frozen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.libsdl.app']/class[@name='HIDDeviceManager']/method[@name='setFrozen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFrozen", "(Z)V", "GetSetFrozen_ZHandler")]
		public virtual unsafe void SetFrozen (bool frozen)
		{
			const string __id = "setFrozen.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (frozen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
