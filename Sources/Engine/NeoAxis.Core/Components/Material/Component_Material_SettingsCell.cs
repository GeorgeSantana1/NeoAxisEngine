﻿// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NeoAxis.Editor
{
	public class Component_Material_SettingsCell : SettingsCellProcedureUI
	{
		ProcedureUI.Button buttonUpdate;
		ProcedureUI.Check checkAutoUpdate;

		//

		protected override void OnInitUI()
		{
			buttonUpdate = ProcedureForm.CreateButton( EditorLocalization.Translate( "General", "Update" ) );
			buttonUpdate.Click += ButtonUpdate_Click;

			checkAutoUpdate = ProcedureForm.CreateCheck( EditorLocalization.Translate( "General", "Auto update" ) );
			checkAutoUpdate.Click += CheckAutoUpdate_Click;

			ProcedureForm.AddRow( new ProcedureUI.Control[] { buttonUpdate, checkAutoUpdate } );
		}

		private void ButtonUpdate_Click( ProcedureUI.Button sender )
		{
			foreach( var material in GetObjects<Component_Material>() )
				material.ResultCompile();
			//foreach( var material in GetMaterials() )
			//	material.ShouldRecompile = true;
		}

		private void CheckAutoUpdate_Click( ProcedureUI.Check obj )
		{
			if( checkAutoUpdate.Checked == ProcedureUI.Check.CheckValue.Indeterminate )
				return;

			var undoItems = new List<UndoActionPropertiesChange.Item>();
			foreach( var material in GetObjects<Component_Material>() )
			{
				var oldValue = material.EditorAutoUpdate;

				material.EditorAutoUpdate = checkAutoUpdate.Checked == ProcedureUI.Check.CheckValue.Checked;

				var property = (Metadata.Property)material.MetadataGetMemberBySignature( "property:EditorAutoUpdate" );
				undoItems.Add( new UndoActionPropertiesChange.Item( material, property, oldValue ) );
			}

			var undoAction = new UndoActionPropertiesChange( undoItems );
			Provider.DocumentWindow.Document.CommitUndoAction( undoAction );
		}

		protected override void OnUpdate()
		{
			var objects = GetObjects<Component_Material>();

			if( objects.All( m => m.EditorAutoUpdate ) )
				checkAutoUpdate.Checked = ProcedureUI.Check.CheckValue.Checked;
			else if( objects.All( m => !m.EditorAutoUpdate ) )
				checkAutoUpdate.Checked = ProcedureUI.Check.CheckValue.Unchecked;
			else
				checkAutoUpdate.Checked = ProcedureUI.Check.CheckValue.Indeterminate;

			//buttonUpdate.Enabled = checkAutoUpdate.Checked != ProcedureUI.Check.CheckValue.Checked;
		}
	}
}
