namespace MainMap
open Mob
type Texture = Texture //TODO: Убрать сие говно
type Tile =
    | Space
    | Some of Texture * Item option



