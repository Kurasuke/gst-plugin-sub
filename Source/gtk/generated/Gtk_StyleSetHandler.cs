// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void StyleSetHandler(object o, StyleSetArgs args);

	public class StyleSetArgs : GLib.SignalArgs {
		public Gtk.Style PreviousStyle{
			get {
				return (Gtk.Style) Args [0];
			}
		}

	}
}
