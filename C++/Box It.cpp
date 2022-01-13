
//Implement the class Box
//l,b,h are integers representing the dimensions of the box

// The class should have the following functions :

// Constructors:
// Box();
// Box(int,int,int);
// Box(Box);

// int getLength(); // Return box's length
// int getBreadth (); // Return box's breadth
// int getHeight ();  //Return box's height
// long long CalculateVolume(); // Return the volume of the box

class Box
{
private:
    int l;
    int b;
    int h;

public:
    Box() : l(0), b(0), h(0){};
    Box(int _l, int _b, int _h) : l(_l), b(_b), h(_h){};
    Box(Box &_box)
    {
        l = _box.l;
        b = _box.b;
        h = _box.h;
    }
    int getLength()
    {
        return l;
    }
    int getBreadth()
    {
        return b;
    }
    int getHeight()
    {
        return h;
    }
    long long CalculateVolume()
    {
        return (long long)l * b * h;
    }
    bool operator<(Box &_box)
    {
        if ((this->l < _box.l) ||
            ((this->b < _box.b) && (this->l == _box.l)) ||
            ((this->h < _box.h) && (this->l == _box.l) && (this->b == _box.b)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    friend ostream &operator<<(ostream &output, const Box &B)
    {
        output << B.l << " " << B.b << " " << B.h;
        return output;
    }
};

//Overload operator < as specified
//bool operator<(Box& b)

//Overload operator << as specified
//ostream& operator<<(ostream& out, Box& B)
