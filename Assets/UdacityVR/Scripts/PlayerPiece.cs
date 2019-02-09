using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour {
    public bool hasBeenPlayed = false;

    public void playPiece() {
        //If the player has selected a grid area
        //Animate the piece into position
        hasBeenPlayed = true;

        //Tell our GameLogic script to occupy the game board array at the right location with a player piece
    }
}
