﻿// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;

namespace NeoAxis.Editor
{
	public partial class Component_Image_DocumentWindow : DocumentWindowWithViewport
	{
		public Component_Image_DocumentWindow()
		{
			InitializeComponent();
		}

		public Component_Image Texture
		{
			get { return (Component_Image)ObjectOfWindow; }
		}

		protected override void OnLoad( EventArgs e )
		{
			base.OnLoad( e );

			var scene = CreateScene( false );

			if( Texture?.Result?.TextureType == Component_Image.TypeEnum.Cube )
			{
				var type = MetadataManager.GetType( "NeoAxis.Component_Skybox" );
				if( type != null )
				{
					var skybox = scene.CreateComponent( type );
					skybox.PropertySet( "Cubemap", Texture );
					skybox.PropertySet( "AllowProcessEnvironmentCubemap", false );
				}
			}

			scene.Enabled = true;

			if( ObjectOfWindow != null )
				SelectObjects( new object[] { ObjectOfWindow } );
		}

		protected override void Viewport_UpdateBeforeOutput( Viewport viewport )
		{
			base.Viewport_UpdateBeforeOutput( viewport );

			if( Texture?.Result?.TextureType == Component_Image.TypeEnum._2D )
			{
				var result = Texture.Result;

				var size = result.ResultSize.ToVector2();
				var screenSize = viewport.SizeInPixels.ToVector2();

				//if( TextureResourceType.shrinkToFit )
				{
					if( size.X > screenSize.X * .95f )
					{
						var coef = screenSize.X * .95f / size.X;
						size *= coef;
					}
					if( size.Y > screenSize.Y * .95f )
					{
						var coef = screenSize.Y * .95f / size.Y;
						size *= coef;
					}
				}

				var screenTextureSize = size / screenSize;

				var screenPosition = ( new Vector2( 1, 1 ) - screenTextureSize ) / 2;

				var screenRect = new Rectangle( screenPosition, screenPosition + screenTextureSize );
				viewport.CanvasRenderer.AddQuad( screenRect, new Rectangle( 0, 0, 1, 1 ), Texture, new ColorValue( 1, 1, 1 ), true );
			}
		}

		protected override void GetTextInfoLeftTopCorner( List<string> lines )
		{
			base.GetTextInfoLeftTopCorner( lines );

		}
	}
}
