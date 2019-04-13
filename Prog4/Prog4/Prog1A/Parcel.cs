﻿// D3894
// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    // Precondition:  None
    // Postcondition: When this < p1, method returns negative #
    //                When this == p1, method returns zero
    //                When this > p1, method returns positive #
    public int CompareTo(Parcel parcel1)
    {
        if (this == null && parcel1 == null) // Both null?
            return 0;                   // Equal

        if (this == null) // only this is null?
            return -1;    // null is less than any actual time

        if (parcel1 == null) // only t2 is null?
            return 1;   // Any actual time is greater than null

        return (this.CalcCost()).CompareTo(parcel1.CalcCost()); //returns cost
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }
}
