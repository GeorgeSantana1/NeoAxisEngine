﻿// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace NeoAxis
{
	/// <summary>
	/// Clickable button.
	/// </summary>
	public class UIButton : UIControl
	{
		bool cursorInsideArea;
		bool pushed;

		//!!!!было. это стиль?
		//string clickMask = "";
		//Rect clickMaskTextureCoord = new Rect( 0, 0, 1, 1 );
		//TextureMaskManager.Mask clickTextureMask;
		//bool needUpdateClickTextureMask;

		/////////////////////////////////////////

		public delegate void ClickDelegate( UIButton sender );
		public event ClickDelegate Click;

		/////////////////////////////////////////

		/// <summary>
		/// Specifies highlighted state of the button.
		/// </summary>
		[DefaultValue( false )]
		public Reference<bool> Highlighted
		{
			get { if( _highlighted.BeginGet() ) Highlighted = _highlighted.Get( this ); return _highlighted.value; }
			set { if( _highlighted.BeginSet( ref value ) ) { try { HighlightedChanged?.Invoke( this ); } finally { _highlighted.EndSet(); } } }
		}
		public event Action<UIButton> HighlightedChanged;
		ReferenceField<bool> _highlighted = false;

		/////////////////////////////////////////

		public UIButton()
		{
			Size = new UIMeasureValueVector2( UIMeasure.Units, 200, 40 );
		}

		protected override bool OnMouseDown( EMouseButtons button )
		{
			//bool ret = base.OnMouseDown( button );

			if( button == EMouseButtons.Left && VisibleInHierarchy && cursorInsideArea && EnabledInHierarchy && !ReadOnlyInHierarchy )
			{
				pushed = true;
				Capture = true;
				return true;
			}

			return false;//return base.OnMouseDown( button );
		}

		protected override bool OnMouseUp( EMouseButtons button )
		{
			//bool ret = base.OnMouseUp( button );

			if( pushed && VisibleInHierarchy && EnabledInHierarchy && !ReadOnlyInHierarchy )
			{
				pushed = false;
				Capture = false;
				if( cursorInsideArea )
					PerformClick();
				return true;
			}

			return false;//base.OnMouseUp( button );
		}

		//!!!!
		bool IsTheRoot( UIControl control )
		{
			UIControl c = ParentControl;
			while( c != null )
			{
				if( c == control )
					return true;
				c = c.ParentControl;
			}
			return false;
		}

		protected virtual bool OnCursorIsInArea()
		{
			//control rectangle
			if( !( new Rectangle( Vector2.Zero, new Vector2( 1, 1 ) ) ).Contains( MousePosition ) )
				return false;

			UIControl cover = ParentContainer?.GetTopMouseCoversControl( false );
			if( cover != null )
			{
				//!!!!!strange
				if( !IsTheRoot( cover ) )
					return false;
			}

			//!!!!было
			////click mask
			//if( !string.IsNullOrEmpty( clickMask ) )
			//{
			//if( needUpdateClickTextureMask )
			//{
			//	clickTextureMask = TextureMaskManager.GetMask( clickMask );
			//	needUpdateClickTextureMask = false;
			//}

			//if( clickTextureMask != null )
			//{
			//	Vec2 pos = clickMaskTextureCoord.LeftTop + clickMaskTextureCoord.GetSize() * MousePosition;
			//	if( !clickTextureMask.GetValue( pos ) )
			//		return false;
			//}
			//}

			return true;
		}

		protected override void OnMouseMove( Vector2 mouse )
		{
			base.OnMouseMove( mouse );

			if( EnabledInHierarchy && VisibleInHierarchy && !ReadOnlyInHierarchy )
			{
				bool intoArea = OnCursorIsInArea();
				if( cursorInsideArea != intoArea )
				{
					cursorInsideArea = intoArea;

					if( cursorInsideArea )
						GetStyle().PerformButtonMouseEnter( this );
					else
						GetStyle().PerformButtonMouseLeave( this );
					//ParentContainer?.PlaySound( cursorInsideArea ? SoundMouseEnter : SoundMouseLeave );
				}
			}
		}

		protected override void OnUpdate( float delta )
		{
			base.OnUpdate( delta );

			if( ( pushed || cursorInsideArea ) && ( !VisibleInHierarchy || !EnabledInHierarchy || ReadOnlyInHierarchy ) )
			{
				if( pushed )
				{
					pushed = false;
					Capture = false;
				}
				cursorInsideArea = false;
			}

			if( EnabledInHierarchy && VisibleInHierarchy && !ReadOnlyInHierarchy )
			{
				bool intoArea = OnCursorIsInArea();
				if( cursorInsideArea != intoArea )
				{
					cursorInsideArea = intoArea;

					if( cursorInsideArea )
						GetStyle().PerformButtonMouseEnter( this );
					else
						GetStyle().PerformButtonMouseLeave( this );
					//ParentContainer?.PlaySound( cursorInsideArea ? SoundMouseEnter : SoundMouseLeave );
				}
			}

			if( pushed && ( !VisibleInHierarchy || !EnabledInHierarchy || ReadOnlyInHierarchy ) )
			{
				pushed = false;
				Capture = false;
			}
		}

		//!!!!было. хотя в TIckUI делается
		//protected override void OnVisibleInHierarchyChanged()
		//{
		//	base.OnVisibleInHierarchyChanged();

		//	if( pushed && !VisibleInHierarchy )
		//	{
		//		pushed = false;
		//		Capture = false;
		//	}
		//}

		protected override void OnEnabledInHierarchyChanged()
		{
			base.OnEnabledInHierarchyChanged();

			if( pushed && !EnabledInHierarchy )
			{
				pushed = false;
				Capture = false;
			}
		}

		public enum StateEnum
		{
			Normal,
			//Focused, может это не стейт, а дополнение. UIControl.Focused
			Hover,
			Pushed,
			Highlighted,
			Disabled,
		}

		/// <summary>
		/// The current state of the button.
		/// </summary>
		[Browsable( false )]
		public StateEnum State
		{
			get
			{
				if( EnabledInHierarchy && !ReadOnlyInHierarchy )
				{
					if( Pushed )
						return CursorInsideArea ? StateEnum.Pushed : StateEnum.Hover;
					else
					{
						if( CursorInsideArea )
							return StateEnum.Hover;
						else
							return Highlighted ? StateEnum.Highlighted : StateEnum.Normal;
					}
				}
				else
					return StateEnum.Disabled;
			}
		}

		//!!!!было

		//[Category( "Button" )]
		////!!!!!![Editor( typeof( EditorTextureUITypeEditor ), typeof( UITypeEditor ) )]
		//[DefaultValue( "" )]
		//public string ClickMask
		//{
		//	get { return clickMask; }
		//	set
		//	{
		//		if( clickMask == value )
		//			return;
		//		clickMask = value;
		//		needUpdateClickTextureMask = true;
		//	}
		//}

		//[DefaultValue( typeof( Rect ), "0 0 1 1" )]
		//[Category( "Button" )]
		//public Rect ClickMaskTextureCoord
		//{
		//	get { return clickMaskTextureCoord; }
		//	set { clickMaskTextureCoord = value; }
		//}

		protected virtual void OnClick() { }

		public void PerformClick()
		{
			GetStyle().PerformButtonClick( this );
			OnClick();
			Click?.Invoke( this );
		}

		[Browsable( false )]
		public bool CursorInsideArea
		{
			get { return cursorInsideArea; }
		}

		[Browsable( false )]
		public bool Pushed
		{
			get { return pushed; }
		}
	}
}
