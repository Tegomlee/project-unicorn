using UnityEngine;


/**
 * File: IInteractable.cs
 * Description: Create a universal API for all interactables in the game.
 * Author: Bryan Sanchez (Tegomlee)
 * Date: 2024-09-20
 */
namespace ProjectUnicorn.InteractionSystem
{
    /// <summary>
    /// Defines a universal API for all interactables in the game.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// This method is called when the interactable object is interacted with.
        /// </summary>
        public void Interact();
    }
}
