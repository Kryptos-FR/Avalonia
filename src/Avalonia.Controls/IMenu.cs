using System;
using Avalonia.Controls.Platform;

namespace Avalonia.Controls
{
    /// <summary>
    /// Represents a menu control.
    /// </summary>
    public interface IMenu : IMenuElement
    {
        /// <summary>
        /// Gets the menu interaction handler.
        /// </summary>
        IMenuInteractionHandler InteractionHandler { get; }

        bool IsOpen { get; }
    }
}
