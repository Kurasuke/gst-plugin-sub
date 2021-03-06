// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Print {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_print_action_and_target(IntPtr action_namespace, IntPtr action_name, IntPtr target);

		public static string ActionAndTarget(string action_namespace, string action_name, GLib.Variant target) {
			IntPtr native_action_namespace = GLib.Marshaller.StringToPtrGStrdup (action_namespace);
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr raw_ret = gtk_print_action_and_target(native_action_namespace, native_action_name, target == null ? IntPtr.Zero : target.Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_action_namespace);
			GLib.Marshaller.Free (native_action_name);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_print_error_quark();

		public static int ErrorQuark() {
			int raw_ret = gtk_print_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_print_run_page_setup_dialog(IntPtr parent, IntPtr page_setup, IntPtr settings);

		public static Gtk.PageSetup RunPageSetupDialog(Gtk.Window parent, Gtk.PageSetup page_setup, Gtk.PrintSettings settings) {
			IntPtr raw_ret = gtk_print_run_page_setup_dialog(parent == null ? IntPtr.Zero : parent.Handle, page_setup == null ? IntPtr.Zero : page_setup.Handle, settings == null ? IntPtr.Zero : settings.Handle);
			Gtk.PageSetup ret = GLib.Object.GetObject(raw_ret) as Gtk.PageSetup;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_print_run_page_setup_dialog_async(IntPtr parent, IntPtr page_setup, IntPtr settings, GtkSharp.PageSetupDoneFuncNative done_cb, IntPtr data);

		public static void RunPageSetupDialogAsync(Gtk.Window parent, Gtk.PageSetup page_setup, Gtk.PrintSettings settings, Gtk.PageSetupDoneFunc done_cb) {
			GtkSharp.PageSetupDoneFuncWrapper done_cb_wrapper = new GtkSharp.PageSetupDoneFuncWrapper (done_cb);
			done_cb_wrapper.PersistUntilCalled ();
			gtk_print_run_page_setup_dialog_async(parent == null ? IntPtr.Zero : parent.Handle, page_setup == null ? IntPtr.Zero : page_setup.Handle, settings == null ? IntPtr.Zero : settings.Handle, done_cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

#endregion
	}
}
