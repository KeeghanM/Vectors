using System;

class Vector2D
{
    float X;
    float Y;
    float Mag;

    // If no X or Y info is passed at creation
    // we want to create the Vector at 0,0
    Vector2D()
    {
        this.X = 0;
        this.Y = 0;
        this.Mag = 0;
    }

    // Passing an X and Y?? Lets use them!
    Vector2D(float x, float y)
    {
        this.X = x;
        this.Y = y;
        this.Mag = 0;
    }

    // Oooor you could pass in a Magnitude!
    Vector2D(float x, float y, float mag)
    {
        this.X = x;
        this.Y = y;
        this.Mag = mag;
    }

    // Got two Vectors and want to combine them?
    // This will add another vector to the current
    // vector and then return the combined one.
    // Ignores Magnitude
    public Vector2D Add(Vector2D vectorToAdd)
    {
        this.X += vectorToAdd.X;
        this.Y += vectorToAdd.Y;
        return this;
    }

    // Got two Vectors and want to subtract one from the other?
    // This will remove a vector from the current
    // vector and then return the result.
    // Ignores Magnitude
    public Vector2D Sub(Vector2D vectorToSub)
    {
        this.X -= vectorToSub.X;
        this.Y -= vectorToSub.Y;
        return this;
    }

    // Got two Vectors and want to Multipy them together?
    // You Rebel.
    // This will do just that to the X and Y
    // Ignores Magnitude
    public Vector2D Mult(Vector2D vectorToMult)
    {
        this.X *= vectorToMult.X;
        this.Y *= vectorToMult.Y;
        return this;
    }

    // Want to multiply a Vector by just a 
    // flat amount, not another vector.
    // You Can!
    // This will do just that to the X and Y
    // Ignores Magnitude
    public Vector2D Mult(float amountToMult)
    {
        this.X *= amountToMult;
        this.Y *= amountToMult;
        return this;
    }

    // Got two Vectors and divide one by the other?
    // Apparently So.
    // This will do just that to the X and Y
    // Ignores Magnitude
    public Vector2D Div(Vector2D vectorToDiv)
    {
        this.X /= vectorToDiv.X;
        this.Y /= vectorToDiv.Y;
        return this;
    }

    // Got a Vector (yup) and wish to divide
    // it by some number?
    // You've come to the right place
    // This will do just that to the X and Y
    // Ignores Magnitude
    public Vector2D Div(float vectorToDiv)
    {
        this.X /= vectorToDiv;
        this.Y /= vectorToDiv;
        return this;
    }
    //TODO: Perhaps add in Add / Subtract etc methods to include Mag?

    // Sometimes you just have to normalise
    // that Vector... this simple method
    // will do just that!
    public Vector2D Norm()
    {
        this.Div(this.GetMag());
        return this;
    }

    // Want this vector to have a specific magnitude??
    // Quite likely.
    // So use this, it will even normalise the Vector
    public Vector2D SetMag(float magToSet)
    {
        this.Norm();
        this.Mult(magToSet);
        return this;
    }

    // You need to find out what the magnitude
    // of the Vector is at some point... well this
    // is where that gets done!
    public float GetMag()
    {
        float mag = (float)Math.Sqrt((this.X * this.X) + (this.Y * this.Y)); ;
        return mag;
    }

    // Sometimes you just really need to ensure that
    // a vector doesn't go over a certain magnitude.
    // This. Does. That.
    public Vector2D Limit(float max)
    {
        if(this.GetMag() > max)
        {
            this.SetMag(max);
        }
        return this;
    }

    // Wanna know the direction this Vector is
    // pointing in? Wanna know it in Radians? CCW?
    // Good.
    // Dir returns an angle in radians, CCW, for this
    // vector.
    // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math/atan2 -- I know its a JS reference but seriously. it helps!
    public float GetDir()
    {
        float direction = (float) Math.Atan2(this.Y, this.X);
        return direction;
    }

    // Want the Vector to point in a new direction?
    // Pass this method a direction in Radians and...
    // TADA!!
    public Vector2D SetDir(float amountToRotate)
    {
        var newDirection = this.GetDir() + amountToRotate;
        var mag = this.GetMag();

        this.X = (float) Math.Cos(amountToRotate) * mag;
        this.Y = (float) Math.Sin(amountToRotate) * mag;

        return this;
    }

    // Sometimes you just wanna know what angle
    // another Vector is from this vector.
    // So you run this handy wee Method and it'll tell you!
    // Cute.
    public float AngleTo(Vector2D target)
    {
        float angle = (float) Math.Atan2(target.X - this.X, target.Y - this.Y);
        return angle;
    }
        
    // Gotta know how far away a thing is at some point!
    // This will tell you through some clever mathematicalatics ;)
    public float DistanceTo(Vector2D target)
    {
        float distance = (float)Math.Sqrt(Math.Pow(target.X - this.X, 2) + Math.Pow(target.Y - this.Y, 2));
        return distance;
    }

    // Cloning is fun. So I built this method.
    // Now you can have an exact duplicate of the 
    // original vector!
    public Vector2D Clone()
    {
        return new Vector2D(this.X, this.Y);
    }
}