﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestLib
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="test")]
	public partial class DBContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    partial void InsertFrequentDriver(FrequentDriver instance);
    partial void UpdateFrequentDriver(FrequentDriver instance);
    partial void DeleteFrequentDriver(FrequentDriver instance);
    #endregion
		
		public DBContext() : 
				base(global::TestLib.Properties.Settings.Default.testConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<Person> Persons
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
		
		public System.Data.Linq.Table<FrequentDriver> FrequentDrivers
		{
			get
			{
				return this.GetTable<FrequentDriver>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cars")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Brand;
		
		private string _RegistrationNumber;
		
		private string _MadeIn;
		
		private EntitySet<FrequentDriver> _FrequentDrivers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnRegistrationNumberChanging(string value);
    partial void OnRegistrationNumberChanged();
    partial void OnMadeInChanging(string value);
    partial void OnMadeInChanged();
    #endregion
		
		public Car()
		{
			this._FrequentDrivers = new EntitySet<FrequentDriver>(new Action<FrequentDriver>(this.attach_FrequentDrivers), new Action<FrequentDriver>(this.detach_FrequentDrivers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationNumber", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string RegistrationNumber
		{
			get
			{
				return this._RegistrationNumber;
			}
			set
			{
				if ((this._RegistrationNumber != value))
				{
					this.OnRegistrationNumberChanging(value);
					this.SendPropertyChanging();
					this._RegistrationNumber = value;
					this.SendPropertyChanged("RegistrationNumber");
					this.OnRegistrationNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MadeIn", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MadeIn
		{
			get
			{
				return this._MadeIn;
			}
			set
			{
				if ((this._MadeIn != value))
				{
					this.OnMadeInChanging(value);
					this.SendPropertyChanging();
					this._MadeIn = value;
					this.SendPropertyChanged("MadeIn");
					this.OnMadeInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_FrequentDriver", Storage="_FrequentDrivers", ThisKey="ID", OtherKey="CarID")]
		public EntitySet<FrequentDriver> FrequentDrivers
		{
			get
			{
				return this._FrequentDrivers;
			}
			set
			{
				this._FrequentDrivers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_FrequentDrivers(FrequentDriver entity)
		{
			this.SendPropertyChanging();
			entity.Car = this;
		}
		
		private void detach_FrequentDrivers(FrequentDriver entity)
		{
			this.SendPropertyChanging();
			entity.Car = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persons")]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _SSN;
		
		private string _PersonKey;
		
		private byte _SexID;
		
		private string _DisplayName;
		
		private PersonStatus _PersonStatus;
		
		private EntitySet<FrequentDriver> _FrequentDrivers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnSSNChanging(string value);
    partial void OnSSNChanged();
    partial void OnPersonKeyChanging(string value);
    partial void OnPersonKeyChanged();
    partial void OnSexIDChanging(byte value);
    partial void OnSexIDChanged();
    partial void OnDisplayNameChanging(string value);
    partial void OnDisplayNameChanged();
    partial void OnPersonStatusChanging(PersonStatus value);
    partial void OnPersonStatusChanged();
    #endregion
		
		public Person()
		{
			this._FrequentDrivers = new EntitySet<FrequentDriver>(new Action<FrequentDriver>(this.attach_FrequentDrivers), new Action<FrequentDriver>(this.detach_FrequentDrivers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSN", DbType="Char(12) NOT NULL", CanBeNull=false)]
		public string SSN
		{
			get
			{
				return this._SSN;
			}
			set
			{
				if ((this._SSN != value))
				{
					this.OnSSNChanging(value);
					this.SendPropertyChanging();
					this._SSN = value;
					this.SendPropertyChanged("SSN");
					this.OnSSNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonKey", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string PersonKey
		{
			get
			{
				return this._PersonKey;
			}
			set
			{
				if ((this._PersonKey != value))
				{
					this.OnPersonKeyChanging(value);
					this.SendPropertyChanging();
					this._PersonKey = value;
					this.SendPropertyChanged("PersonKey");
					this.OnPersonKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SexID", DbType="TinyInt NOT NULL")]
		public byte SexID
		{
			get
			{
				return this._SexID;
			}
			set
			{
				if ((this._SexID != value))
				{
					this.OnSexIDChanging(value);
					this.SendPropertyChanging();
					this._SexID = value;
					this.SendPropertyChanged("SexID");
					this.OnSexIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this.OnDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._DisplayName = value;
					this.SendPropertyChanged("DisplayName");
					this.OnDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonStatus", DbType="TinyInt", CanBeNull=true)]
		public PersonStatus PersonStatus
		{
			get
			{
				return this._PersonStatus;
			}
			set
			{
				if ((this._PersonStatus != value))
				{
					this.OnPersonStatusChanging(value);
					this.SendPropertyChanging();
					this._PersonStatus = value;
					this.SendPropertyChanged("PersonStatus");
					this.OnPersonStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_FrequentDriver", Storage="_FrequentDrivers", ThisKey="ID", OtherKey="PersonID")]
		public EntitySet<FrequentDriver> FrequentDrivers
		{
			get
			{
				return this._FrequentDrivers;
			}
			set
			{
				this._FrequentDrivers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_FrequentDrivers(FrequentDriver entity)
		{
			this.SendPropertyChanging();
			entity.Person = this;
		}
		
		private void detach_FrequentDrivers(FrequentDriver entity)
		{
			this.SendPropertyChanging();
			entity.Person = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FrequentDrivers")]
	public partial class FrequentDriver : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CarID;
		
		private int _PersonID;
		
		private EntityRef<Car> _Car;
		
		private EntityRef<Person> _Person;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarIDChanging(int value);
    partial void OnCarIDChanged();
    partial void OnPersonIDChanging(int value);
    partial void OnPersonIDChanged();
    #endregion
		
		public FrequentDriver()
		{
			this._Car = default(EntityRef<Car>);
			this._Person = default(EntityRef<Person>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CarID
		{
			get
			{
				return this._CarID;
			}
			set
			{
				if ((this._CarID != value))
				{
					if (this._Car.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCarIDChanging(value);
					this.SendPropertyChanging();
					this._CarID = value;
					this.SendPropertyChanged("CarID");
					this.OnCarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					if (this._Person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPersonIDChanging(value);
					this.SendPropertyChanging();
					this._PersonID = value;
					this.SendPropertyChanged("PersonID");
					this.OnPersonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_FrequentDriver", Storage="_Car", ThisKey="CarID", OtherKey="ID", IsForeignKey=true)]
		public Car Car
		{
			get
			{
				return this._Car.Entity;
			}
			set
			{
				Car previousValue = this._Car.Entity;
				if (((previousValue != value) 
							|| (this._Car.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Car.Entity = null;
						previousValue.FrequentDrivers.Remove(this);
					}
					this._Car.Entity = value;
					if ((value != null))
					{
						value.FrequentDrivers.Add(this);
						this._CarID = value.ID;
					}
					else
					{
						this._CarID = default(int);
					}
					this.SendPropertyChanged("Car");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_FrequentDriver", Storage="_Person", ThisKey="PersonID", OtherKey="ID", IsForeignKey=true)]
		public Person Person
		{
			get
			{
				return this._Person.Entity;
			}
			set
			{
				Person previousValue = this._Person.Entity;
				if (((previousValue != value) 
							|| (this._Person.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Person.Entity = null;
						previousValue.FrequentDrivers.Remove(this);
					}
					this._Person.Entity = value;
					if ((value != null))
					{
						value.FrequentDrivers.Add(this);
						this._PersonID = value.ID;
					}
					else
					{
						this._PersonID = default(int);
					}
					this.SendPropertyChanged("Person");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
