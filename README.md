# Vectors
a C# based, Vector object

Current Features:
 - Vector2D - Can be created at 0,0 by default, or a position can be passed, or a position and a magnitude
  - Add - Add's two Vectors together
  - Sub - Subtracts one vector from another
  - Mult - Can either multiple one vector by a number, or multiply two Vectors together
  - Div -  Can either divide one vector by a number, or dive two Vectors by each other
  - Norm - Normalises the Vector
  - SetMag - Sets the magnitude of a Vector
  - GetMag - Gets the magnitude of a Vector
  - Limit - Will either set the magnitude to a max amount, or if less than that, leave as is
  - SetDir - Points the Vector a new location
  - GetDir - Gets the current direction
  - AngleTo - Calculates the angle to another Vector
  - DistanceTo - Calculates the distance to another Vector
  - Clone - Creates an identical copy of the current Vector
  
Things to note:
 - All angles are in radians
 - Requires no extra libraries or anything, only reference is to System
 
TODO List:
  - Add Vector3D
  - Add methods for adding/subtracting etc that account for Magnitude
  - Add some methods for converting between Radians and Degrees
  - Clean up SetDir
