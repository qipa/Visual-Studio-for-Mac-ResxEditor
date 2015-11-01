﻿using Gtk;

namespace ResxEditor.Core.Interfaces
{
	public interface IResourceListStore
	{
		void AppendValues (IResourceModel item);

		bool SetName (string path, string nextName);

		bool SetValue (string path, string nextValue);

		#region ListStore
		TreeIter Prepend ();

		TreePath GetPath (TreeIter iter);

		bool Remove (ref TreeIter iter);
		#endregion
	}
}
