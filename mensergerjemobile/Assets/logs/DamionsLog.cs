using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamionsLog : MonoBehaviour {

    /// <summary>
    /// 
    /// Damion's Update Log V1.3
    /// 
    /// Scripts edited:
    /// > ButtonManager.cs -> Added functions to switch between main menu and options
    /// 
    /// Added options menu -> Extra canvas that is toggled by a button press
    /// Added a background to the main and options menu
    /// 
    /// To Do List:
    /// - Grid snapping -> Probably for Daan
    /// - Cone kicking -> Probably for Daan
    /// - Dice rolling -> Daan is working on this
    /// 
    /// Time to sit back and enjoy some goddamn peace and quiet :þ
    /// 
    /// Next Update Log will be rolling out ASAP.
    /// 
    /// ----------------------------------------------------------------------------------------------------
    /// 
    /// Damion's Update Log V1.2
    /// 
    /// Scripts edited:
    /// > ButtonManager.cs -> (previously known as UI_Manager.cs) Renamed to prevent confusion with GameUI.cs made the buttons recolour once they are selected
    /// > PlayerTurn.cs -> now checks for current scene to separate 2 parts of code and enable/disable the game's UI canvas
    /// 
    /// Optimized Game UI
    /// Built fixed version of the main game
    /// Main menu expanded:
    /// + Working buttons for player selection
    /// + Working start button
    /// Moved the camera center point to the menu scene to directly store game data
    /// Added some summaries to scripts
    /// 
    /// To Do List:
    /// - Options menu -> Working on it
    /// - Give the main menu a makeover -> Working on it
    /// - Grid snapping -> Probably for Daan
    /// - Cone kicking -> Probably for Daan
    /// - Dice rolling -> Daan is working on this
    /// 
    /// Next Update Log will be rolling out ASAP.
    /// 
    /// ----------------------------------------------------------------------------------------------------
    /// 
    /// Damion's Update Log V1.1
    /// 
    /// Scripts created:
    /// + GameUI.cs
    /// + PlayerTurn.cs
    /// 
    /// Scripts edited:
    /// > CameraBehaviour.cs -> zooming limited, working on camera rotation and added debug controls for pc
    /// > BeardCone.cs -> entire script created, apparently touch and mousebutton 0 are the same
    /// 
    /// Built several tests for camera rotation -> Finally working
    /// Built a few tests for cone movement -> Successful and optimized
    /// Cones are now placed on invisible planes, which you can move around by dragging them
    /// Turn system is up and running
    /// UI has a panel showing the current player's turn and a button to move to the next turn
    /// Build first test for turn system -> Buttons might be bigger
    /// 
    /// To Do List:
    /// - A main menu -> Daan is working on this
    /// - Option to choose an amount of players
    /// - Grid snapping
    /// - Cone kicking
    /// - Dice rolling
    /// 
    /// Next Update Log will be rolling out ASAP.
    /// 
    /// ----------------------------------------------------------------------------------------------------
    /// 
    /// Damion's Update Log V1.0
    /// Scripts created:
    /// + InputManager.cs
    /// + CameraBehaviour.cs
    /// 
    /// Created, imported and placed the game board
    /// Created, imported and placed multiple instances of a cone and coloured, grouped, tagged and positioned them
    /// Created and imported a die
    /// Made the camera child to an empty placed at the center of the board for rotation and zoom
    /// Calculated a snap distance for placement (3.6875f)
    /// Built a test for camera zoom -> Result: zooming works
    /// 
    /// To Do List:
    /// - Make the camera rotate around the board
    /// - A main menu
    /// - UI
    /// - Option to choose an amount of players
    /// - Turn system
    /// - Cone movement
    /// - Grid snapping
    /// - Cone kicking
    /// - Dice rolling
    /// 
    /// Next Update Log will be rolling out ASAP.
    /// 
    /// </summary>

}
