using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Bread.Models
{
    /// <summary>岗位</summary>
    [Serializable]
    [DataObject]
    [Description("岗位")]
    [BindTable("JobInfo", Description = "岗位", ConnName = "bread", DbType = DatabaseType.SqlServer)]
    public partial class JobInfo
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private Int32 _JobCategoryID;
        /// <summary>岗位分类</summary>
        [DisplayName("岗位分类")]
        [Description("岗位分类")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("JobCategoryID", "岗位分类", "")]
        public Int32 JobCategoryID { get => _JobCategoryID; set { if (OnPropertyChanging("JobCategoryID", value)) { _JobCategoryID = value; OnPropertyChanged("JobCategoryID"); } } }

        private String _Name;
        /// <summary>岗位名称</summary>
        [DisplayName("岗位名称")]
        [Description("岗位名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "岗位名称", "")]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private String _Address;
        /// <summary>岗位地点</summary>
        [DisplayName("岗位地点")]
        [Description("岗位地点")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Address", "岗位地点", "")]
        public String Address { get => _Address; set { if (OnPropertyChanging("Address", value)) { _Address = value; OnPropertyChanged("Address"); } } }

        private DateTime _PublishTime;
        /// <summary>发布时间</summary>
        [DisplayName("发布时间")]
        [Description("发布时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("PublishTime", "发布时间", "")]
        public DateTime PublishTime { get => _PublishTime; set { if (OnPropertyChanging("PublishTime", value)) { _PublishTime = value; OnPropertyChanged("PublishTime"); } } }

        private Boolean _IsUrgent;
        /// <summary>是否加急</summary>
        [DisplayName("是否加急")]
        [Description("是否加急")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsUrgent", "是否加急", "")]
        public Boolean IsUrgent { get => _IsUrgent; set { if (OnPropertyChanging("IsUrgent", value)) { _IsUrgent = value; OnPropertyChanged("IsUrgent"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateTime", "创建时间", "", Master = true)]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateTime", "更新时间", "", Master = true)]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private String _CreateUserID;
        /// <summary>创建人</summary>
        [DisplayName("创建人")]
        [Description("创建人")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("CreateUserID", "创建人", "", Master = true)]
        public String CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private String _UpdateUserID;
        /// <summary>更新人</summary>
        [DisplayName("更新人")]
        [Description("更新人")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("UpdateUserID", "更新人", "", Master = true)]
        public String UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID": return _ID;
                    case "JobCategoryID": return _JobCategoryID;
                    case "Name": return _Name;
                    case "Address": return _Address;
                    case "PublishTime": return _PublishTime;
                    case "IsUrgent": return _IsUrgent;
                    case "CreateTime": return _CreateTime;
                    case "UpdateTime": return _UpdateTime;
                    case "CreateUserID": return _CreateUserID;
                    case "UpdateUserID": return _UpdateUserID;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "JobCategoryID": _JobCategoryID = value.ToInt(); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "Address": _Address = Convert.ToString(value); break;
                    case "PublishTime": _PublishTime = value.ToDateTime(); break;
                    case "IsUrgent": _IsUrgent = value.ToBoolean(); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "CreateUserID": _CreateUserID = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得岗位字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>岗位分类</summary>
            public static readonly Field JobCategoryID = FindByName("JobCategoryID");

            /// <summary>岗位名称</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>岗位地点</summary>
            public static readonly Field Address = FindByName("Address");

            /// <summary>发布时间</summary>
            public static readonly Field PublishTime = FindByName("PublishTime");

            /// <summary>是否加急</summary>
            public static readonly Field IsUrgent = FindByName("IsUrgent");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>创建人</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>更新人</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得岗位字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>岗位分类</summary>
            public const String JobCategoryID = "JobCategoryID";

            /// <summary>岗位名称</summary>
            public const String Name = "Name";

            /// <summary>岗位地点</summary>
            public const String Address = "Address";

            /// <summary>发布时间</summary>
            public const String PublishTime = "PublishTime";

            /// <summary>是否加急</summary>
            public const String IsUrgent = "IsUrgent";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>创建人</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>更新人</summary>
            public const String UpdateUserID = "UpdateUserID";
        }
        #endregion
    }
}