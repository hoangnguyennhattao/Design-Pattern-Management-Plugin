﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DesignPattern", "PatternModelPatternInstance", "PatternModel", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(BusinessModel.PatternModel), "PatternInstance", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BusinessModel.PatternInstance))]
[assembly: EdmRelationshipAttribute("DesignPattern", "PatternInstancePatternLocation", "PatternInstance", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BusinessModel.PatternInstance), "PatternLocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BusinessModel.PatternLocation))]

#endregion

namespace BusinessModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DesignPatternContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DesignPatternContainer object using the connection string found in the 'DesignPatternContainer' section of the application configuration file.
        /// </summary>
        public DesignPatternContainer() : base("name=DesignPatternContainer", "DesignPatternContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DesignPatternContainer object.
        /// </summary>
        public DesignPatternContainer(string connectionString) : base(connectionString, "DesignPatternContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DesignPatternContainer object.
        /// </summary>
        public DesignPatternContainer(EntityConnection connection) : base(connection, "DesignPatternContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PatternModel> PatternModels
        {
            get
            {
                if ((_PatternModels == null))
                {
                    _PatternModels = base.CreateObjectSet<PatternModel>("PatternModels");
                }
                return _PatternModels;
            }
        }
        private ObjectSet<PatternModel> _PatternModels;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PatternInstance> PatternInstances
        {
            get
            {
                if ((_PatternInstances == null))
                {
                    _PatternInstances = base.CreateObjectSet<PatternInstance>("PatternInstances");
                }
                return _PatternInstances;
            }
        }
        private ObjectSet<PatternInstance> _PatternInstances;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PatternLocation> PatternLocations
        {
            get
            {
                if ((_PatternLocations == null))
                {
                    _PatternLocations = base.CreateObjectSet<PatternLocation>("PatternLocations");
                }
                return _PatternLocations;
            }
        }
        private ObjectSet<PatternLocation> _PatternLocations;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PatternModels EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPatternModels(PatternModel patternModel)
        {
            base.AddObject("PatternModels", patternModel);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PatternInstances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPatternInstances(PatternInstance patternInstance)
        {
            base.AddObject("PatternInstances", patternInstance);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PatternLocations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPatternLocations(PatternLocation patternLocation)
        {
            base.AddObject("PatternLocations", patternLocation);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DesignPattern", Name="PatternInstance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PatternInstance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PatternInstance object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="sPCFilePath">Initial value of the SPCFilePath property.</param>
        /// <param name="codeFilePath">Initial value of the CodeFilePath property.</param>
        /// <param name="designerFilePath">Initial value of the DesignerFilePath property.</param>
        public static PatternInstance CreatePatternInstance(global::System.Int32 id, global::System.String name, global::System.String sPCFilePath, global::System.String codeFilePath, global::System.String designerFilePath)
        {
            PatternInstance patternInstance = new PatternInstance();
            patternInstance.ID = id;
            patternInstance.Name = name;
            patternInstance.SPCFilePath = sPCFilePath;
            patternInstance.CodeFilePath = codeFilePath;
            patternInstance.DesignerFilePath = designerFilePath;
            return patternInstance;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SPCFilePath
        {
            get
            {
                return _SPCFilePath;
            }
            set
            {
                OnSPCFilePathChanging(value);
                ReportPropertyChanging("SPCFilePath");
                _SPCFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SPCFilePath");
                OnSPCFilePathChanged();
            }
        }
        private global::System.String _SPCFilePath;
        partial void OnSPCFilePathChanging(global::System.String value);
        partial void OnSPCFilePathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CodeFilePath
        {
            get
            {
                return _CodeFilePath;
            }
            set
            {
                OnCodeFilePathChanging(value);
                ReportPropertyChanging("CodeFilePath");
                _CodeFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CodeFilePath");
                OnCodeFilePathChanged();
            }
        }
        private global::System.String _CodeFilePath;
        partial void OnCodeFilePathChanging(global::System.String value);
        partial void OnCodeFilePathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DesignerFilePath
        {
            get
            {
                return _DesignerFilePath;
            }
            set
            {
                OnDesignerFilePathChanging(value);
                ReportPropertyChanging("DesignerFilePath");
                _DesignerFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DesignerFilePath");
                OnDesignerFilePathChanged();
            }
        }
        private global::System.String _DesignerFilePath;
        partial void OnDesignerFilePathChanging(global::System.String value);
        partial void OnDesignerFilePathChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DesignPattern", "PatternModelPatternInstance", "PatternModel")]
        public PatternModel PatternModel
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PatternModel>("DesignPattern.PatternModelPatternInstance", "PatternModel").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PatternModel>("DesignPattern.PatternModelPatternInstance", "PatternModel").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<PatternModel> PatternModelReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PatternModel>("DesignPattern.PatternModelPatternInstance", "PatternModel");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PatternModel>("DesignPattern.PatternModelPatternInstance", "PatternModel", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DesignPattern", "PatternInstancePatternLocation", "PatternLocation")]
        public EntityCollection<PatternLocation> PatternLocations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PatternLocation>("DesignPattern.PatternInstancePatternLocation", "PatternLocation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PatternLocation>("DesignPattern.PatternInstancePatternLocation", "PatternLocation", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DesignPattern", Name="PatternLocation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PatternLocation : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PatternLocation object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="rootPath">Initial value of the RootPath property.</param>
        public static PatternLocation CreatePatternLocation(global::System.Int32 id, global::System.String rootPath)
        {
            PatternLocation patternLocation = new PatternLocation();
            patternLocation.ID = id;
            patternLocation.RootPath = rootPath;
            return patternLocation;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name = "Unknown";
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RootPath
        {
            get
            {
                return _RootPath;
            }
            set
            {
                OnRootPathChanging(value);
                ReportPropertyChanging("RootPath");
                _RootPath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RootPath");
                OnRootPathChanged();
            }
        }
        private global::System.String _RootPath;
        partial void OnRootPathChanging(global::System.String value);
        partial void OnRootPathChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DesignPattern", "PatternInstancePatternLocation", "PatternInstance")]
        public EntityCollection<PatternInstance> PatternInstances
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PatternInstance>("DesignPattern.PatternInstancePatternLocation", "PatternInstance");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PatternInstance>("DesignPattern.PatternInstancePatternLocation", "PatternInstance", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DesignPattern", Name="PatternModel")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PatternModel : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PatternModel object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="xFrameFilePath">Initial value of the XFrameFilePath property.</param>
        /// <param name="sPCTemplateFilePath">Initial value of the SPCTemplateFilePath property.</param>
        /// <param name="designerTemplateFilePath">Initial value of the DesignerTemplateFilePath property.</param>
        public static PatternModel CreatePatternModel(global::System.Int32 id, global::System.String name, global::System.String xFrameFilePath, global::System.String sPCTemplateFilePath, global::System.String designerTemplateFilePath)
        {
            PatternModel patternModel = new PatternModel();
            patternModel.ID = id;
            patternModel.Name = name;
            patternModel.XFrameFilePath = xFrameFilePath;
            patternModel.SPCTemplateFilePath = sPCTemplateFilePath;
            patternModel.DesignerTemplateFilePath = designerTemplateFilePath;
            return patternModel;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description = "";
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String XFrameFilePath
        {
            get
            {
                return _XFrameFilePath;
            }
            set
            {
                OnXFrameFilePathChanging(value);
                ReportPropertyChanging("XFrameFilePath");
                _XFrameFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("XFrameFilePath");
                OnXFrameFilePathChanged();
            }
        }
        private global::System.String _XFrameFilePath;
        partial void OnXFrameFilePathChanging(global::System.String value);
        partial void OnXFrameFilePathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SPCTemplateFilePath
        {
            get
            {
                return _SPCTemplateFilePath;
            }
            set
            {
                OnSPCTemplateFilePathChanging(value);
                ReportPropertyChanging("SPCTemplateFilePath");
                _SPCTemplateFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SPCTemplateFilePath");
                OnSPCTemplateFilePathChanged();
            }
        }
        private global::System.String _SPCTemplateFilePath;
        partial void OnSPCTemplateFilePathChanging(global::System.String value);
        partial void OnSPCTemplateFilePathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DesignerTemplateFilePath
        {
            get
            {
                return _DesignerTemplateFilePath;
            }
            set
            {
                OnDesignerTemplateFilePathChanging(value);
                ReportPropertyChanging("DesignerTemplateFilePath");
                _DesignerTemplateFilePath = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DesignerTemplateFilePath");
                OnDesignerTemplateFilePathChanged();
            }
        }
        private global::System.String _DesignerTemplateFilePath;
        partial void OnDesignerTemplateFilePathChanging(global::System.String value);
        partial void OnDesignerTemplateFilePathChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DesignPattern", "PatternModelPatternInstance", "PatternInstance")]
        public EntityCollection<PatternInstance> PatternInstances
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PatternInstance>("DesignPattern.PatternModelPatternInstance", "PatternInstance");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PatternInstance>("DesignPattern.PatternModelPatternInstance", "PatternInstance", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}