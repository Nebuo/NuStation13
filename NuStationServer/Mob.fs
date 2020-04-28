module Mob
type Item = Item
type Inventory =
    { mutable rhand : Item option
      mutable lhand : Item option
      mutable head : Item option
      mutable body : Item option
      mutable legs : Item option }
type Mob =
    | Person 
    | NPC

