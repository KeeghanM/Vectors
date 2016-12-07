# Vectors
a C# based, Vector object

Current Features:
 - Vector2D - Can be created at 0,0 by default, or a position can be passed, or a position and a magnitude
  - Add - Add's two vectors together
  - Sub - Subtracts one vector from another
  - Mult - Can either multiple one vector by a number, or multiply two vectors together
  - Div -  Can either divide one vector by a number, or dive two vectors by each other
  - Norm - Normalises the Vector
  - SetMag - Sets the magnitude of a Vector
  - GetMag - Gets the magnitude of a Vector
  - Limit - Will either set the magnitude to a max amount, or if less than that, leave as is
  - SetDir - Points the Vector a new location
  - GetDir - Gets the current direction
  - AngleTo - Calculates the angle to another vector
  - DistanceTo - Calculates the distance to another Cector
  - Clone - Creates an identical copy of the current Cector
  
Things to note:
 - All angles are in radians
 - Requires no extra libraries or anything, only reference is to System
 
TODO List:
  - Add Vector3D
  - Add methods for adding/subtracting etc that account for Magnitude
