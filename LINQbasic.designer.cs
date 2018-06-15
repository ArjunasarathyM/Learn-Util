﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasicUtil
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Practice1")]
	public partial class LINQbasicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertITEM(ITEM instance);
    partial void UpdateITEM(ITEM instance);
    partial void DeleteITEM(ITEM instance);
    partial void InserttestForPKFK(testForPKFK instance);
    partial void UpdatetestForPKFK(testForPKFK instance);
    partial void DeletetestForPKFK(testForPKFK instance);
    #endregion
		
		public LINQbasicDataContext() : 
				base(global::BasicUtil.Properties.Settings.Default.Practice1ConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public LINQbasicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQbasicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQbasicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQbasicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ITEM> ITEMs
		{
			get
			{
				return this.GetTable<ITEM>();
			}
		}
		
		public System.Data.Linq.Table<testForPKFK> testForPKFKs
		{
			get
			{
				return this.GetTable<testForPKFK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITEM")]
	public partial class ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<decimal> _Price;
		
		private long _phone;
		
		private EntityRef<testForPKFK> _testForPKFK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnphoneChanging(long value);
    partial void OnphoneChanged();
    #endregion
		
		public ITEM()
		{
			this._testForPKFK = default(EntityRef<testForPKFK>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(9,3)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="BigInt NOT NULL")]
		public long phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_testForPKFK", Storage="_testForPKFK", ThisKey="ID", OtherKey="num", IsUnique=true, IsForeignKey=false)]
		public testForPKFK testForPKFK
		{
			get
			{
				return this._testForPKFK.Entity;
			}
			set
			{
				testForPKFK previousValue = this._testForPKFK.Entity;
				if (((previousValue != value) 
							|| (this._testForPKFK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._testForPKFK.Entity = null;
						previousValue.ITEM = null;
					}
					this._testForPKFK.Entity = value;
					if ((value != null))
					{
						value.ITEM = this;
					}
					this.SendPropertyChanged("testForPKFK");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.testForPKFK")]
	public partial class testForPKFK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _num;
		
		private int _ID;
		
		private string _name;
		
		private bool _stat;
		
		private EntityRef<ITEM> _ITEM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnumChanging(int value);
    partial void OnnumChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnstatChanging(bool value);
    partial void OnstatChanged();
    #endregion
		
		public testForPKFK()
		{
			this._ITEM = default(EntityRef<ITEM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_num", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int num
		{
			get
			{
				return this._num;
			}
			set
			{
				if ((this._num != value))
				{
					if (this._ITEM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnnumChanging(value);
					this.SendPropertyChanging();
					this._num = value;
					this.SendPropertyChanged("num");
					this.OnnumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stat", DbType="Bit NOT NULL")]
		public bool stat
		{
			get
			{
				return this._stat;
			}
			set
			{
				if ((this._stat != value))
				{
					this.OnstatChanging(value);
					this.SendPropertyChanging();
					this._stat = value;
					this.SendPropertyChanged("stat");
					this.OnstatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_testForPKFK", Storage="_ITEM", ThisKey="num", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public ITEM ITEM
		{
			get
			{
				return this._ITEM.Entity;
			}
			set
			{
				ITEM previousValue = this._ITEM.Entity;
				if (((previousValue != value) 
							|| (this._ITEM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ITEM.Entity = null;
						previousValue.testForPKFK = null;
					}
					this._ITEM.Entity = value;
					if ((value != null))
					{
						value.testForPKFK = this;
						this._num = value.ID;
					}
					else
					{
						this._num = default(int);
					}
					this.SendPropertyChanged("ITEM");
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
