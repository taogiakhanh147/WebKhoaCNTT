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

namespace Web_CNTT_DHTNMT.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KhoaCNTT-DHTNMT")]
	public partial class Web_CNTT_DHTNMTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcomment(comment instance);
    partial void Updatecomment(comment instance);
    partial void Deletecomment(comment instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertnew(@new instance);
    partial void Updatenew(@new instance);
    partial void Deletenew(@new instance);
    partial void Insertnews_group(news_group instance);
    partial void Updatenews_group(news_group instance);
    partial void Deletenews_group(news_group instance);
    partial void Insertuser_group(user_group instance);
    partial void Updateuser_group(user_group instance);
    partial void Deleteuser_group(user_group instance);
    #endregion
		
		public Web_CNTT_DHTNMTDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["KhoaCNTT_DHTNMTConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Web_CNTT_DHTNMTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Web_CNTT_DHTNMTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Web_CNTT_DHTNMTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Web_CNTT_DHTNMTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<comment> comments
		{
			get
			{
				return this.GetTable<comment>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<@new> news
		{
			get
			{
				return this.GetTable<@new>();
			}
		}
		
		public System.Data.Linq.Table<news_group> news_groups
		{
			get
			{
				return this.GetTable<news_group>();
			}
		}
		
		public System.Data.Linq.Table<user_group> user_groups
		{
			get
			{
				return this.GetTable<user_group>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comments")]
	public partial class comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<long> _user_id;
		
		private System.Nullable<int> _news_id;
		
		private System.Nullable<System.DateTime> _date;
		
		private string _comment_text;
		
		private EntityRef<user> _user;
		
		private EntityRef<@new> _new;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onuser_idChanging(System.Nullable<long> value);
    partial void Onuser_idChanged();
    partial void Onnews_idChanging(System.Nullable<int> value);
    partial void Onnews_idChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void Oncomment_textChanging(string value);
    partial void Oncomment_textChanged();
    #endregion
		
		public comment()
		{
			this._user = default(EntityRef<user>);
			this._new = default(EntityRef<@new>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="BigInt")]
		public System.Nullable<long> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_news_id", DbType="Int")]
		public System.Nullable<int> news_id
		{
			get
			{
				return this._news_id;
			}
			set
			{
				if ((this._news_id != value))
				{
					if (this._new.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onnews_idChanging(value);
					this.SendPropertyChanging();
					this._news_id = value;
					this.SendPropertyChanged("news_id");
					this.Onnews_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment_text", DbType="NVarChar(1000)")]
		public string comment_text
		{
			get
			{
				return this._comment_text;
			}
			set
			{
				if ((this._comment_text != value))
				{
					this.Oncomment_textChanging(value);
					this.SendPropertyChanging();
					this._comment_text = value;
					this.SendPropertyChanged("comment_text");
					this.Oncomment_textChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_comment", Storage="_user", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.comments.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.comments.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<long>);
					}
					this.SendPropertyChanged("user");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="new_comment", Storage="_new", ThisKey="news_id", OtherKey="id", IsForeignKey=true)]
		public @new @new
		{
			get
			{
				return this._new.Entity;
			}
			set
			{
				@new previousValue = this._new.Entity;
				if (((previousValue != value) 
							|| (this._new.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._new.Entity = null;
						previousValue.comments.Remove(this);
					}
					this._new.Entity = value;
					if ((value != null))
					{
						value.comments.Add(this);
						this._news_id = value.id;
					}
					else
					{
						this._news_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("@new");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _name;
		
		private string _email;
		
		private string _password;
		
		private System.Nullable<System.DateTime> _created_at;
		
		private System.Nullable<System.DateTime> _updated_at;
		
		private System.Nullable<byte> _usergroup_id;
		
		private EntitySet<comment> _comments;
		
		private EntitySet<@new> _news;
		
		private EntityRef<user_group> _user_group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Oncreated_atChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.Nullable<System.DateTime> value);
    partial void Onupdated_atChanged();
    partial void Onusergroup_idChanging(System.Nullable<byte> value);
    partial void Onusergroup_idChanged();
    #endregion
		
		public user()
		{
			this._comments = new EntitySet<comment>(new Action<comment>(this.attach_comments), new Action<comment>(this.detach_comments));
			this._news = new EntitySet<@new>(new Action<@new>(this.attach_news), new Action<@new>(this.detach_news));
			this._user_group = default(EntityRef<user_group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(30)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usergroup_id", DbType="TinyInt")]
		public System.Nullable<byte> usergroup_id
		{
			get
			{
				return this._usergroup_id;
			}
			set
			{
				if ((this._usergroup_id != value))
				{
					if (this._user_group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onusergroup_idChanging(value);
					this.SendPropertyChanging();
					this._usergroup_id = value;
					this.SendPropertyChanged("usergroup_id");
					this.Onusergroup_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_comment", Storage="_comments", ThisKey="id", OtherKey="user_id")]
		public EntitySet<comment> comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				this._comments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_new", Storage="_news", ThisKey="id", OtherKey="user_id")]
		public EntitySet<@new> news
		{
			get
			{
				return this._news;
			}
			set
			{
				this._news.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_group_user", Storage="_user_group", ThisKey="usergroup_id", OtherKey="id", IsForeignKey=true)]
		public user_group user_group
		{
			get
			{
				return this._user_group.Entity;
			}
			set
			{
				user_group previousValue = this._user_group.Entity;
				if (((previousValue != value) 
							|| (this._user_group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_group.Entity = null;
						previousValue.users.Remove(this);
					}
					this._user_group.Entity = value;
					if ((value != null))
					{
						value.users.Add(this);
						this._usergroup_id = value.id;
					}
					else
					{
						this._usergroup_id = default(Nullable<byte>);
					}
					this.SendPropertyChanged("user_group");
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
		
		private void attach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
		
		private void attach_news(@new entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_news(@new entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.news")]
	public partial class @new : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _title;
		
		private string _slug;
		
		private string _content;
		
		private System.Nullable<System.DateTime> _created_at;
		
		private System.Nullable<System.DateTime> _updated_at;
		
		private System.Nullable<bool> _status;
		
		private System.Nullable<long> _user_id;
		
		private System.Nullable<int> _newsgroup_id;
		
		private EntitySet<comment> _comments;
		
		private EntityRef<user> _user;
		
		private EntityRef<news_group> _news_group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnslugChanging(string value);
    partial void OnslugChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void Oncreated_atChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.Nullable<System.DateTime> value);
    partial void Onupdated_atChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    partial void Onuser_idChanging(System.Nullable<long> value);
    partial void Onuser_idChanged();
    partial void Onnewsgroup_idChanging(System.Nullable<int> value);
    partial void Onnewsgroup_idChanged();
    #endregion
		
		public @new()
		{
			this._comments = new EntitySet<comment>(new Action<comment>(this.attach_comments), new Action<comment>(this.detach_comments));
			this._user = default(EntityRef<user>);
			this._news_group = default(EntityRef<news_group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_slug", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string slug
		{
			get
			{
				return this._slug;
			}
			set
			{
				if ((this._slug != value))
				{
					this.OnslugChanging(value);
					this.SendPropertyChanging();
					this._slug = value;
					this.SendPropertyChanged("slug");
					this.OnslugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="NVarChar(MAX)")]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="BigInt")]
		public System.Nullable<long> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_newsgroup_id", DbType="Int")]
		public System.Nullable<int> newsgroup_id
		{
			get
			{
				return this._newsgroup_id;
			}
			set
			{
				if ((this._newsgroup_id != value))
				{
					if (this._news_group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onnewsgroup_idChanging(value);
					this.SendPropertyChanging();
					this._newsgroup_id = value;
					this.SendPropertyChanged("newsgroup_id");
					this.Onnewsgroup_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="new_comment", Storage="_comments", ThisKey="id", OtherKey="news_id")]
		public EntitySet<comment> comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				this._comments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_new", Storage="_user", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.news.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.news.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<long>);
					}
					this.SendPropertyChanged("user");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="news_group_new", Storage="_news_group", ThisKey="newsgroup_id", OtherKey="id", IsForeignKey=true)]
		public news_group news_group
		{
			get
			{
				return this._news_group.Entity;
			}
			set
			{
				news_group previousValue = this._news_group.Entity;
				if (((previousValue != value) 
							|| (this._news_group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._news_group.Entity = null;
						previousValue.news.Remove(this);
					}
					this._news_group.Entity = value;
					if ((value != null))
					{
						value.news.Add(this);
						this._newsgroup_id = value.id;
					}
					else
					{
						this._newsgroup_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("news_group");
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
		
		private void attach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.@new = this;
		}
		
		private void detach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.@new = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.news_groups")]
	public partial class news_group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<@new> _news;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public news_group()
		{
			this._news = new EntitySet<@new>(new Action<@new>(this.attach_news), new Action<@new>(this.detach_news));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="news_group_new", Storage="_news", ThisKey="id", OtherKey="newsgroup_id")]
		public EntitySet<@new> news
		{
			get
			{
				return this._news;
			}
			set
			{
				this._news.Assign(value);
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
		
		private void attach_news(@new entity)
		{
			this.SendPropertyChanging();
			entity.news_group = this;
		}
		
		private void detach_news(@new entity)
		{
			this.SendPropertyChanging();
			entity.news_group = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_groups")]
	public partial class user_group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _id;
		
		private string _name;
		
		private EntitySet<user> _users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(byte value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public user_group()
		{
			this._users = new EntitySet<user>(new Action<user>(this.attach_users), new Action<user>(this.detach_users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="TinyInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public byte id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_group_user", Storage="_users", ThisKey="id", OtherKey="usergroup_id")]
		public EntitySet<user> users
		{
			get
			{
				return this._users;
			}
			set
			{
				this._users.Assign(value);
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
		
		private void attach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.user_group = this;
		}
		
		private void detach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.user_group = null;
		}
	}
}
#pragma warning restore 1591
