# SORSE
# Streets of Rogue Sprite Editor

## Description

This is a utility that will allow you to replace the Sprites (graphics) in Streets of Rogue. It does not include replacement graphics on its own. You will need a SpritePack to load with it. Once installed, it's as easy as editing and saving images in a folder, then running the game.

## Installation

* Install BepInEx. 
  * Instructions here: https://steamcommunity.com/sharedfiles/filedetails/?id=2271959380
* Add the SORSE.dll file to your mod folder as in the instructions.
* Load your SpritePack. [TODO: Verify SpritePack folder target directory]
  * SOR Community 32x32 High-Res Overhaul SpritePack: [TODO: Add link when release created]

## Making your own SpritePack

A SpritePack is simply a folder structure with a collection of .png image files. If you have the images in the right folders, SORSE will detect them and replace the original images automatically.

The easiest method is to start with the Vanilla SpritePack as a template. This is simply all the game's existing sprites, extracted and placed into the appropriate folders - simply edit or replace the existing files in those folders. If you intend to release a SpritePack, you should delete any vanilla sprites you haven't replaced; leaving all the vanilla sprites in there will make your SP load slowly, and will make it unclear to users which files you have replaced. You can download the SOR Vanilla Spritepack here: [TODO: Add link when release created]

Alternatively, you can create the folders yourself according to filelist.txt. [TODO: verify name and add file when finalized]
