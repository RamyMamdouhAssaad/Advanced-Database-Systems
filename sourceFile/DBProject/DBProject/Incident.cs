///////////////////////////////////////////////////////////
//  Incident.cs
//  Implementation of the Class Incident
//  Generated by Enterprise Architect
//  Created on:      04-Apr-2016 6:48:42 PM
//  Original author: ENVY
///////////////////////////////////////////////////////////
using System.Collections;
using Db4objects.Db4o;


public class Incident {

    public string city;
	public string dateTime;
    public string description;
	public int incidentID;
	public Location incidentLocation;
    public int riskDegree;
    public Complainant newComp;
	private string type;
    

  ~Incident(){

	}

	public virtual void Dispose(){

	}

	/// 
	/// <param name="type"></param>
	/// <param name="riskDegree"></param>
	/// <param name="incidentID"></param>
	/// <param name="city"></param>
	/// <param name="dateTime"></param>
	/// <param name="description"></param>
	/// <param name="incidentLocation"></param>
	public Incident(string type, int riskDegree, int incidentID, string city, string dateTime, string description, Location incidentLocation){
        this.type = type;
        this.riskDegree = riskDegree;
        this.incidentID = incidentID;
        this.city = city;
        this.dateTime = dateTime;
        this.description = description;
        this.incidentLocation = incidentLocation;

	}

    public void RecieveComplainant(Complainant comp)
    {
        this.newComp = comp;
    }
    public Complainant getComplainant()
    {
        return newComp;
    }

	public Incident(){

	}

	/// 
	/// <param name="type"></param>
	/// <param name="riskDegree"></param>
	/// <param name="incidentID"></param>
	/// <param name="city"></param>
	/// <param name="dateTime"></param>
	/// <param name="description"></param>
	/// <param name="incidentLocation"></param>
	public void InsertIncidentData(Incident incident){

        Complainant.db.Store(incident);
    }

	/// 
	/// <param name="incidentID"></param>
	public ArrayList[] RetrieveIncidentData(int incidentID){

		return null;
	}

	/// 
	/// <param name="incidentID"></param>
	public string UpdateIncidentData(int incidentID){

		return "";
	}

}//end Incident