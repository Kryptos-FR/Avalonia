using System;
using System.Collections.Generic;
using Avalonia.Input;

namespace Avalonia.Controls
{
    /// <summary>
    /// Represents an <see cref="IMenu"/> or <see cref="IMenuItem"/>.
    /// </summary>
    public interface IMenuElement : IControl
    {
        IMenuItem SelectedItem { get; set; }
        IEnumerable<IMenuItem> SubItems { get; }
        void Open();
        void Close();
        bool MoveSelection(NavigationDirection direction, bool wrap);
    }
}
