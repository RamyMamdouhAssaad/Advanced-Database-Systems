///////////////////////////////////////////////////////////
//  Police.cs
//  Implementation of the Class Police
//  Generated by Enterprise Architect
//  Created on:      04-Apr-2016 6:48:44 PM
//  Original author: ENVY
///////////////////////////////////////////////////////////
using System.Collections;



public class Police {

	public Address address;
    public int badegNumber;
    public int ID;
    public Name name;
    public Shift newShift;
    public ArrayList phoneNumber;
    public double salary;
    
	//public Shift m_Shift;

	public Police(){

	}

	~Police(){

	}

	public virtual void Dispose(){

	}

	/// 
	/// <param name="salary"></param>
	/// <param name="badgeNumber"></param>
	/// <param name="phoneNumber"></param>
	/// <param name="name"></param>
	/// <param name="ID"></param>
	/// <param name="address"></param>
	//public Police()//double salary, int badgeNumber, string[] phoneNumber, Name name, int ID, Address address, Shift newshift)
    //{
       /* this.salary = salary;
        this.badegNumber = badgeNumber;
        this.phoneNumber= phoneNumber;
        this.name= name;
        this.ID= ID;
        this.address= address;
        this.newShift = newshift;
        */
	//}

}//end Police