// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.TreeViewGridLinesGType))]
	public enum TreeViewGridLines {

		None,
		Horizontal,
		Vertical,
		Both,
	}

	internal class TreeViewGridLinesGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_view_grid_lines_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_tree_view_grid_lines_get_type ());
			}
		}
	}
#endregion
}
