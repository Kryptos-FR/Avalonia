using System;

namespace Avalonia.Controls
{
    public interface IMenuItem : IMenuElement
    {
        bool HasSubMenu { get; }
        bool IsPointerOverSubMenu { get; }
        bool IsSubMenuOpen { get; set; }
        bool IsTopLevel { get; }
        new IMenuElement Parent { get; }
        void RaiseClick();
    }
}
