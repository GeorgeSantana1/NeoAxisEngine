// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NeoAxis
{
	/// <summary>
	/// An object to manage a hierarchy of components. For example, using this object, you can load an additional scene inside another scene.
	/// </summary>
	public class Component_ComponentHost : Component
	{
		Component createdComponent;

		/////////////////////////////////////////

		/// <summary>
		/// File to load.
		/// </summary>
		[DefaultValue( null )]
		public Reference<ReferenceValueType_Resource> LoadFile
		{
			get { if( _loadFile.BeginGet() ) LoadFile = _loadFile.Get( this ); return _loadFile.value; }
			set { if( _loadFile.BeginSet( ref value ) ) { try { LoadFileChanged?.Invoke( this ); ComponentCreate(); } finally { _loadFile.EndSet(); } } }
		}
		public event Action<Component_ComponentHost> LoadFileChanged;
		ReferenceField<ReferenceValueType_Resource> _loadFile;

		/// <summary>
		/// The type to create.
		/// </summary>
		[DefaultValue( null )]
		public Reference<Metadata.TypeInfo> CreateType
		{
			get { if( _createType.BeginGet() ) CreateType = _createType.Get( this ); return _createType.value; }
			set { if( _createType.BeginSet( ref value ) ) { try { CreateTypeChanged?.Invoke( this ); ComponentCreate(); } finally { _createType.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="CreateType"/> property value changes.</summary>
		public event Action<Component_ComponentHost> CreateTypeChanged;
		ReferenceField<Metadata.TypeInfo> _createType = null;

		/////////////////////////////////////////

		protected override void OnEnabledInHierarchyChanged()
		{
			base.OnEnabledInHierarchyChanged();

			ComponentCreate();
		}

		[Browsable( false )]
		public Component CreatedComponent
		{
			get { return createdComponent; }
		}

		[Browsable( false )]
		public Component_Scene CreatedScene
		{
			get { return CreatedComponent as Component_Scene; }
		}

		public delegate void ComponentCreatedDelegate( Component_ComponentHost sender );
		public event ComponentCreatedDelegate ComponentCreated;

		public delegate void ComponentDestroyedDelegate( Component_ComponentHost sender, Component destroyedComponent );
		public event ComponentDestroyedDelegate ComponentDestroyed;

		public void ComponentCreate()
		{
			ComponentDestroy();

			if( EnabledInHierarchyAndIsNotResource )
			{
				var fileName = LoadFile.GetByReference;
				if( !string.IsNullOrEmpty( fileName ) && VirtualFile.Exists( fileName ) )
					createdComponent = ResourceManager.LoadSeparateInstance<Component>( fileName, true, null );
				else
				{
					var type = CreateType.Value;
					if( type != null )
						createdComponent = ComponentUtility.CreateComponent( type, null, true, true );
				}

				if( createdComponent != null )
					ComponentCreated?.Invoke( this );
			}
		}

		public void ComponentDestroy()
		{
			if( createdComponent != null )
			{
				var destroyedComponent = createdComponent;

				createdComponent.Dispose();
				createdComponent = null;

				ComponentDestroyed?.Invoke( this, destroyedComponent );
			}
		}

		protected override void OnUpdate( float delta )
		{
			base.OnUpdate( delta );

			if( createdComponent != null )
				ComponentsHidePublic.PerformUpdate( createdComponent, delta );
		}

		protected override void OnSimulationStep()
		{
			base.OnSimulationStep();

			if( createdComponent != null )
				ComponentsHidePublic.PerformSimulationStep( createdComponent );
		}
	}
}
