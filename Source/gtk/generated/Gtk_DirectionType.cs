// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.DirectionTypeGType))]
	public enum DirectionType {

		TabForward,
		TabBackward,
		Up,
		Down,
		Left,
		Right,
	}

	internal class DirectionTypeGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_direction_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_direction_type_get_type ());
			}
		}
	}
#endregion
}
