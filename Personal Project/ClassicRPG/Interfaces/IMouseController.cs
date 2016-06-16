namespace ClassicRPG.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// Used for getting/setting the mouse/keyboard state
    /// </summary>
    public static class IMouseController
    {
        public static Vector2 position => new Vector2(currentMouseState.X, currentMouseState.Y);

        public static KeyboardState currentKeyboardState;
        public static KeyboardState previousKeyboardState;

        public static MouseState currentMouseState;
        public static MouseState previousMouseState;

        public static bool MouseRightButtonClicked()
        {
            return currentMouseState.RightButton == ButtonState.Pressed && previousMouseState.RightButton == ButtonState.Released;
        }

        public static bool KeyPressed(Keys key)
        {
            return previousKeyboardState.IsKeyDown(key) && currentKeyboardState.IsKeyUp(key);
        }
    }
}
