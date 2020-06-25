﻿// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.ComponentModel;
using System.Reflection;
using System.IO;

namespace NeoAxis
{
	/// <summary>
	/// Ambient occlusion screen effect (ASSAO).
	/// </summary>
	[DefaultOrderOfEffect( 1 )]
	public class Component_RenderingEffect_AmbientOcclusion : Component_RenderingEffect
	{
		//!!!!TO DO: use mipmaps for render target
		//!!!!TO DO: Gather?

		/// <summary>
		/// The intensity of the effect.
		/// </summary>
		[Serialize]
		[DefaultValue( 1.0 )]
		[Range( 0, 1 )]
		[Category( "Effect" )]
		public Reference<double> Intensity
		{
			get { if( _intensity.BeginGet() ) Intensity = _intensity.Get( this ); return _intensity.value; }
			set { if( _intensity.BeginSet( ref value ) ) { try { IntensityChanged?.Invoke( this ); } finally { _intensity.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="Intensity"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> IntensityChanged;
		ReferenceField<double> _intensity = 1;

		public enum QualityEnum
		{
			//Lowest,
			Low,
			Medium,
			High,
			HighestAdaptive,
		}

		/// <summary>
		/// The quality of the effect.
		/// </summary>
		[Serialize]
		[DefaultValue( QualityEnum.Medium )]
		public Reference<QualityEnum> Quality
		{
			get { if( _quality.BeginGet() ) Quality = _quality.Get( this ); return _quality.value; }
			set { if( _quality.BeginSet( ref value ) ) { try { QualityChanged?.Invoke( this ); } finally { _quality.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="Quality"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> QualityChanged;
		ReferenceField<QualityEnum> _quality = QualityEnum.Medium;

		/// <summary>
		/// Adaptive quality limitation. Only for highest adaptive mode.
		/// </summary>
		[Serialize]
		[DefaultValue( 0.45 )]
		[Range( 0, 1 )]
		public Reference<double> AdaptiveQualityLimit
		{
			get { if( _adaptiveQualityLimit.BeginGet() ) AdaptiveQualityLimit = _adaptiveQualityLimit.Get( this ); return _adaptiveQualityLimit.value; }
			set
			{
				value = new Reference<double>( MathEx.Saturate( value.Value ), value.GetByReference );
				if( _adaptiveQualityLimit.BeginSet( ref value ) )
				{
					try { AdaptiveQualityLimitChanged?.Invoke( this ); }
					finally { _adaptiveQualityLimit.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="AdaptiveQualityLimit"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> AdaptiveQualityLimitChanged;
		ReferenceField<double> _adaptiveQualityLimit = 0.45;

		/// <summary>
		/// World (view) space size of the occlusion sphere.
		/// </summary>
		[Serialize]
		[DefaultValue( 1.2 )]
		[Range( 0, 10, RangeAttribute.ConvenientDistributionEnum.Exponential )]
		public Reference<double> Radius
		{
			get { if( _radius.BeginGet() ) Radius = _radius.Get( this ); return _radius.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _radius.BeginSet( ref value ) )
				{
					try { RadiusChanged?.Invoke( this ); }
					finally { _radius.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="Radius"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> RadiusChanged;
		ReferenceField<double> _radius = 1.2;

		/// <summary>
		/// Linear multiplier of effect strength.
		/// </summary>
		[Serialize]
		[DefaultValue( 1.5 )]
		[Range( 0, 5 )]
		public Reference<double> Multiplier
		{
			get { if( _multiplier.BeginGet() ) Multiplier = _multiplier.Get( this ); return _multiplier.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _multiplier.BeginSet( ref value ) )
				{
					try { MultiplierChanged?.Invoke( this ); }
					finally { _multiplier.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="Multiplier"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> MultiplierChanged;
		ReferenceField<double> _multiplier = 1.5;

		/// <summary>
		/// Pow modifier of effect strength.
		/// </summary>
		[Serialize]
		[DefaultValue( 1.5 )]
		[Range( 0.5, 10 )]
		public Reference<double> Power
		{
			get { if( _power.BeginGet() ) Power = _power.Get( this ); return _power.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _power.BeginSet( ref value ) )
				{
					try { PowerChanged?.Invoke( this ); }
					finally { _power.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="Power"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> PowerChanged;
		ReferenceField<double> _power = 1.5;

		/// <summary>
		/// Distance from which the effect to start fading out.
		/// </summary>
		[Serialize]
		[DefaultValue( 50.0 )]
		[Range( 0, 1000, RangeAttribute.ConvenientDistributionEnum.Exponential )]
		public Reference<double> FadeOutFrom
		{
			get { if( _fadeOutFrom.BeginGet() ) FadeOutFrom = _fadeOutFrom.Get( this ); return _fadeOutFrom.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _fadeOutFrom.BeginSet( ref value ) )
				{
					try { FadeOutFromChanged?.Invoke( this ); }
					finally { _fadeOutFrom.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="FadeOutFrom"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> FadeOutFromChanged;
		ReferenceField<double> _fadeOutFrom = 50;

		/// <summary>
		/// Distance from which the effect is faded out.
		/// </summary>
		[Serialize]
		[DefaultValue( 300.0 )]
		[Range( 0, 1000, RangeAttribute.ConvenientDistributionEnum.Exponential )]
		public Reference<double> FadeOutTo
		{
			get { if( _fadeOutTo.BeginGet() ) FadeOutTo = _fadeOutTo.Get( this ); return _fadeOutTo.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _fadeOutTo.BeginSet( ref value ) )
				{
					try { FadeOutToChanged?.Invoke( this ); }
					finally { _fadeOutTo.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="FadeOutTo"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> FadeOutToChanged;
		ReferenceField<double> _fadeOutTo = 300;

		/// <summary>
		/// Used for high-res detail AO using neighboring depth pixels: adds a lot of detail but also reduces temporal stability (adds aliasing).
		/// </summary>
		[Serialize]
		[DefaultValue( 0.5 )]
		[Range( 0, 5 )]
		public Reference<double> DetailStrength
		{
			get { if( _detailStrength.BeginGet() ) DetailStrength = _detailStrength.Get( this ); return _detailStrength.value; }
			set
			{
				if( value < 0 )
					value = new Reference<double>( 0, value.GetByReference );
				if( _detailStrength.BeginSet( ref value ) )
				{
					try { DetailStrengthChanged?.Invoke( this ); }
					finally { _detailStrength.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="DetailStrength"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> DetailStrengthChanged;
		ReferenceField<double> _detailStrength = 0.5;

		/// <summary>
		/// Number of edge-sensitive smart blur passes to apply. Quality 0 is an exception with only one 'dumb' blur pass is used.
		/// </summary>
		[Serialize]
		[DefaultValue( 2 )]
		[Range( 0, 6 )]
		public Reference<int> BlurAmount
		{
			get { if( _blurAmount.BeginGet() ) BlurAmount = _blurAmount.Get( this ); return _blurAmount.value; }
			set
			{
				if( value < 0 )
					value = new Reference<int>( 0, value.GetByReference );
				if( _blurAmount.BeginSet( ref value ) )
				{
					try { BlurAmountChanged?.Invoke( this ); }
					finally { _blurAmount.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="BlurAmount"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> BlurAmountChanged;
		ReferenceField<int> _blurAmount = 2;

		/// <summary>
		/// How much to bleed over edges; 1: not at all, 0.5: half-half; 0.0: completely ignore edges.
		/// </summary>
		[Serialize]
		[DefaultValue( 0.98 )]
		[Range( 0.5, 1 )]//[ApplicableRange( 0, 1 )]
		public Reference<double> Sharpness
		{
			get { if( _sharpness.BeginGet() ) Sharpness = _sharpness.Get( this ); return _sharpness.value; }
			set
			{
				value = new Reference<double>( MathEx.Saturate( value.Value ), value.GetByReference );
				if( _sharpness.BeginSet( ref value ) )
				{
					try { SharpnessChanged?.Invoke( this ); }
					finally { _sharpness.EndSet(); }
				}
			}
		}
		/// <summary>Occurs when the <see cref="Sharpness"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> SharpnessChanged;
		ReferenceField<double> _sharpness = 0.98;

		//[DefaultValue( false )]
		//[Serialize]
		//public Reference<bool> ExpandResolution
		//{
		//	get { if( _expandResolution.BeginGet() ) ExpandResolution = _expandResolution.Get( this ); return _expandResolution.value; }
		//	set { if( _expandResolution.BeginSet( ref value ) ) { try { ExpandResolutionChanged?.Invoke( this ); } finally { _expandResolution.EndSet(); } } }
		//}
		//public event Action<Component_RenderingEffect_AmbientOcclusion> ExpandResolutionChanged;
		//ReferenceField<bool> _expandResolution = false;

		/// <summary>
		/// Enables the debug visualization of the effect.
		/// </summary>
		[Serialize]
		[DefaultValue( false )]
		public Reference<bool> ShowAO
		{
			get { if( _showAO.BeginGet() ) ShowAO = _showAO.Get( this ); return _showAO.value; }
			set { if( _showAO.BeginSet( ref value ) ) { try { ShowAOChanged?.Invoke( this ); } finally { _showAO.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="ShowAO"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_AmbientOcclusion> ShowAOChanged;
		ReferenceField<bool> _showAO;

		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		protected override void OnMetadataGetMembersFilter( Metadata.GetMembersContext context, Metadata.Member member, ref bool skip )
		{
			base.OnMetadataGetMembersFilter( context, member, ref skip );

			var p = member as Metadata.Property;
			if( p != null )
			{
				switch( p.Name )
				{
				case nameof( AdaptiveQualityLimit ):
					if( Quality.Value != QualityEnum.HighestAdaptive )
						skip = true;
					break;
				}
			}
		}

		private void GeneratePatternRotScaleMatrices( int pass, out Vector4F[] patternRotScaleMatrices )
		{
			const int subPassCount = 5;

			const float additionalAngleOffset = 0.5f;
			const float additionalRadiusScale = 1.5f;

			patternRotScaleMatrices = new Vector4F[ subPassCount ];

			for( int subPass = 0; subPass < subPassCount; subPass++ )
			{
				int a = pass;
				int b = subPass;

				int[] spmap = new int[ 5 ] { 0, 1, 4, 3, 2 };

				b = spmap[ subPass ];

				float ca, sa;
				float angle0 = ( (float)a + (float)b / (float)subPassCount ) * ( 3.1415926535897932384626433832795f ) * 0.5f;
				angle0 += additionalAngleOffset;

				ca = (float)Math.Cos( (double)angle0 );
				sa = (float)Math.Sin( (double)angle0 );

				float scale = 1.0f + ( (float)a - 1.5f + ( (float)b - ( (float)subPassCount - 1.0f ) * 0.5f ) / (float)subPassCount ) * 0.07f;
				scale *= additionalRadiusScale;

				patternRotScaleMatrices[ subPass ] = new Vector4F( scale * ca, scale * -sa, -scale * sa, -scale * ca );
			}
		}

		unsafe protected override void OnRender( ViewportRenderingContext context, Component_RenderingPipeline.IFrameData frameData, ref Component_Image actualTexture )
		{
			base.OnRender( context, frameData, ref actualTexture );

			//is not supported
			if( !context.RenderingPipeline.GetUseMultiRenderTargets() )
				return;

			//downscale for SSAA
			var actualTextureSource = actualTexture;
			if( actualTexture.Result.ResultSize != context.Owner.SizeInPixels )
			{
				actualTexture = context.RenderTarget2D_Alloc( context.Owner.SizeInPixels, actualTextureSource.Result.ResultFormat );

				//copy to scene texture with downscale
				context.SetViewport( actualTexture.Result.GetRenderTarget().Viewports[ 0 ] );

				CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
				shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
				shader.FragmentProgramFileName = @"Base\Shaders\Effects\Downscale2_fs.sc";

				shader.Parameters.Set( "sourceSizeInv", new Vector2F( 1, 1 ) / actualTextureSource.Result.ResultSize.ToVector2F() );

				shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0/*"sourceTexture"*/,
					actualTextureSource, TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );

				context.RenderQuadToCurrentViewport( shader );
			}

			// Setup Constants:

			Vector2F viewportPixelSize = new Vector2F( 1.0f / (float)actualTexture.Result.ResultSize.X, 1.0f / (float)actualTexture.Result.ResultSize.Y );
			Vector2F halfViewportPixelSize = new Vector2F( 1.0f / ( (float)actualTexture.Result.ResultSize.X * 0.5f ), 1.0f / ( (float)actualTexture.Result.ResultSize.Y * 0.5f ) );
			Vector4F quarterViewportPixelSize = new Vector4F( 1.0f / ( (float)actualTexture.Result.ResultSize.X * 0.25f ), 1.0f / ( (float)actualTexture.Result.ResultSize.Y * 0.25f ), (float)( ( actualTexture.Result.ResultSize.X / 4 ) * ( actualTexture.Result.ResultSize.Y / 4 ) ), 0.0f );
			Vector2F viewport2xPixelSize = new Vector2F( viewportPixelSize.X * 2.0f, viewportPixelSize.Y * 2.0f );

			Matrix4F projectionMatrix = context.Owner.CameraSettings.ProjectionMatrix.ToMatrix4F();

			float depthLinearizeMul = -projectionMatrix[ 3 ][ 2 ];
			float depthLinearizeAdd = projectionMatrix[ 2 ][ 2 ];
			if( depthLinearizeMul * depthLinearizeAdd < 0.0f ) depthLinearizeAdd = -depthLinearizeAdd;

			Vector2F depthUnpackConsts = new Vector2F( depthLinearizeMul, depthLinearizeAdd );

			float tanHalfFOVY = 1.0f / projectionMatrix[ 1 ][ 1 ];
			float tanHalfFOVX = 1.0F / projectionMatrix[ 0 ][ 0 ];

			Vector2F cameraTanHalfFOV = new Vector2F( tanHalfFOVX, tanHalfFOVY );

			Vector2F NDCToViewMul = new Vector2F( cameraTanHalfFOV.X * 2.0f, cameraTanHalfFOV.Y * -2.0f );
			Vector2F NDCToViewAdd = new Vector2F( cameraTanHalfFOV.X * -1.0f, cameraTanHalfFOV.Y * 1.0f );

			Matrix4F itViewMatrix = ( context.Owner.CameraSettings.ViewMatrix.GetInverse().ToMatrix4F() ).GetTranspose();

			// Effect Params:

			float effectSamplingRadiusNearLimit = (float)Radius * 1.2f;

			if( Quality.Value == QualityEnum.Low )
				effectSamplingRadiusNearLimit *= 1.50f;

			effectSamplingRadiusNearLimit /= tanHalfFOVY;

			float effectSamplingRadiusNearLimitRec = 1.0f / effectSamplingRadiusNearLimit;

			Vector4F effectRadiusParams = new Vector4F( (float)Radius, -1.0f / (float)Radius, effectSamplingRadiusNearLimitRec, 0.0f );

			float effectFadeOutMul = -1.0f / ( (float)FadeOutTo - (float)FadeOutFrom );
			float effectFadeOutAdd = (float)FadeOutFrom / ( (float)FadeOutTo - (float)FadeOutFrom ) + 1.0f;

			float detailAOStrength = (float)DetailStrength;
			float effectShadowStrength = (float)Multiplier;
			float effectShadowClamp = 1.0f;
			float effectShadowPow = (float)Power;

			float invSharpness = 1.0f - (float)Sharpness;
			if( invSharpness < 0.0f ) invSharpness = 0.0f;
			if( invSharpness > 1.0f ) invSharpness = 1.0f;

			// First Pass: Prepare 4 Depth half-Buffers:

			Component_Image[] halfDepths = new Component_Image[ 4 ];
			for( int i = 0; i < 4; i++ )
				halfDepths[ i ] = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 2, PixelFormat.Float16R );

			var fourDepthsMRT = context.MultiRenderTarget_Create( new[] {
				new MultiRenderTarget.Item(halfDepths[0]),
				new MultiRenderTarget.Item(halfDepths[1]),
				new MultiRenderTarget.Item(halfDepths[2]),
				new MultiRenderTarget.Item(halfDepths[3])
			} );

			{
				context.SetViewport( fourDepthsMRT.Viewports[ 0 ], Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

				CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
				shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
				shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\PrepareDepths_fs.sc";

				context.objectsDuringUpdate.namedTextures.TryGetValue( "depthTexture", out Component_Image depthTexture );

				shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, depthTexture,
					TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

				shader.Parameters.Set( "depthUnpackConsts", depthUnpackConsts );
				//!!!!use actualTextureSource size?
				shader.Parameters.Set( "viewportPixelSize", viewportPixelSize );

				context.RenderQuadToCurrentViewport( shader );
			}

			// Second Pass: prepare 4 Mip-Maps for each Half-Depth-Map:

			Component_Image[,] depthMipMaps = null;

			if( Quality.Value > QualityEnum.Medium )
			{
				Vector2I[] mipMapSizes = new Vector2I[ 4 ]; // Setup Mip-Map sizes:

				mipMapSizes[ 0 ] = new Vector2I( actualTexture.Result.ResultSize / 2 );
				for( int m = 1; m < 4; m++ ) mipMapSizes[ m ] = new Vector2I( mipMapSizes[ m - 1 ] / 2 );

				// Prepare MipMaps textures:

				depthMipMaps = new Component_Image[ 4, 4 ];

				for( int d = 0; d < 4; d++ )
				{
					depthMipMaps[ d, 0 ] = halfDepths[ d ]; // MipMaps 0 is original halfDepthMaps
					for( int m = 1; m < 4; m++ ) depthMipMaps[ d, m ] = context.RenderTarget2D_Alloc( mipMapSizes[ m ], PixelFormat.Float16R );
				}

				for( int m = 1; m < 4; m++ ) // Mip-Maps loop
				{
					var fourDepthsMipsMRT = context.MultiRenderTarget_Create( new[] {
						new MultiRenderTarget.Item(depthMipMaps[0, m]),
						new MultiRenderTarget.Item(depthMipMaps[1, m]),
						new MultiRenderTarget.Item(depthMipMaps[2, m]),
						new MultiRenderTarget.Item(depthMipMaps[3, m])
					} );

					context.SetViewport( fourDepthsMipsMRT.Viewports[ 0 ], Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\PrepareDepthMips_fs.sc";

					// For current Mip-Map generation using previous Mip-Map:

					float prevMipLevel = (float)( m - 1 );
					var prevMipSize = mipMapSizes[ m - 1 ];
					Vector4F prevMipParams = new Vector4F( 1.0f / (float)prevMipSize.X, 1.0f / (float)prevMipSize.Y, prevMipLevel, 0.0f );

					for( int i = 0; i < 4; i++ )
					{
						// previous MipMap as input:
						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( i, depthMipMaps[ i, m - 1 ],
							TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
					}
					shader.Parameters.Set( "prevMipParams", prevMipParams );
					shader.Parameters.Set( "effectRadiusParams", effectRadiusParams );

					context.RenderQuadToCurrentViewport( shader );
				}
			}

			Component_Image SSAOTextureArray = new Component_Image();

			Component_Image SSAOBaseTextureArray = null;
			if( Quality.Value == QualityEnum.HighestAdaptive )
			{
				SSAOBaseTextureArray = new Component_Image();
				SSAOBaseTextureArray = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 2, PixelFormat.R8G8_UInt, 0, false, /*0,*/ 4 );
			}

			Component_Image importanceMap = null;
			Component_Image averageImportance = null;

			// Generate Importance Map for Highest/Adaptive Quality mode:
			if( Quality.Value == QualityEnum.HighestAdaptive )
			{
				// 4 SSAO passes:

				for( int pass = 0; pass < 4; pass++ )
				{
					Vector4F[] patternRotScaleMatrices;
					GeneratePatternRotScaleMatrices( pass, out patternRotScaleMatrices );

					Vector2F perPassFullResCoordOffset = new Vector2F( (float)( pass % 2 ), (float)( pass / 2 ) );

					{
						context.SetViewport( SSAOBaseTextureArray.Result.GetRenderTarget( 0, pass ).Viewports[ 0 ],
							Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

						CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
						shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
						shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateSSAO_AdaptiveBase_fs.sc";

						context.objectsDuringUpdate.namedTextures.TryGetValue( "normalTexture", out Component_Image normalTexture );

						for( int m = 0; m < 4; m++ )
						{
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( m, depthMipMaps[ pass, m ],
								TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
						}

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 4, halfDepths[ pass ],
							TextureAddressingMode.Mirror, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 5, normalTexture,
							TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						shader.Parameters.Set( "NDCToViewMul", NDCToViewMul );
						shader.Parameters.Set( "NDCToViewAdd", NDCToViewAdd );
						shader.Parameters.Set( "effectRadiusParams", effectRadiusParams );
						shader.Parameters.Set( "viewportPixelSize", viewportPixelSize );
						shader.Parameters.Set( "viewport2xPixelSize", viewport2xPixelSize );
						shader.Parameters.Set( "halfViewportPixelSize", halfViewportPixelSize );
						shader.Parameters.Set( "perPassFullResCoordOffset", perPassFullResCoordOffset );
						shader.Parameters.Set( "patternRotScaleMatrices", patternRotScaleMatrices );
						shader.Parameters.Set( "effectFadeOutMul", effectFadeOutMul );
						shader.Parameters.Set( "effectFadeOutAdd", effectFadeOutAdd );
						shader.Parameters.Set( "effectShadowStrength", effectShadowStrength );
						shader.Parameters.Set( "effectShadowClamp", effectShadowClamp );
						shader.Parameters.Set( "effectShadowPow", effectShadowPow );
						shader.Parameters.Set( "detailAOStrength", detailAOStrength );
						shader.Parameters.Set( "itViewMatrix", itViewMatrix );

						context.RenderQuadToCurrentViewport( shader );

					}

				}

				// Importance Map Generation:
				importanceMap = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 4, PixelFormat.L8 );
				{
					context.SetViewport( importanceMap.Result.GetRenderTarget().Viewports[ 0 ],
						Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateImportanceMap_fs.sc";

					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, SSAOBaseTextureArray,
						TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

					shader.Parameters.Set( "halfViewportPixelSize", halfViewportPixelSize );
					shader.Parameters.Set( "effectShadowStrength", effectShadowStrength );
					shader.Parameters.Set( "effectShadowPow", effectShadowPow );

					context.RenderQuadToCurrentViewport( shader );
				}

				// Importance Map Post-Process A:
				var importanceMapPong = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 4, PixelFormat.L8 );
				{
					context.SetViewport( importanceMapPong.Result.GetRenderTarget().Viewports[ 0 ],
						Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\PostProcessImportanceMapA_fs.sc";

					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, importanceMap,
						TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );

					shader.Parameters.Set( "quarterViewportPixelSize", quarterViewportPixelSize );

					context.RenderQuadToCurrentViewport( shader );
				}

				// Importance Map Post-Process B:
				{
					context.SetViewport( importanceMap.Result.GetRenderTarget().Viewports[ 0 ],
						Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\PostProcessImportanceMapB_fs.sc";

					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, importanceMapPong,
						TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );

					shader.Parameters.Set( "quarterViewportPixelSize", quarterViewportPixelSize );

					context.RenderQuadToCurrentViewport( shader );
				}

				context.DynamicTexture_Free( importanceMapPong );

				// Get Average Importance Pass:
				averageImportance = context.RenderTarget2D_Alloc( new Vector2I( 1, 1 ), PixelFormat.L8 );
				{
					context.SetViewport( averageImportance.Result.GetRenderTarget().Viewports[ 0 ],
						Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GetAverageImportance_fs.sc";

					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, importanceMap,
						TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

					shader.Parameters.Set( "quarterViewportPixelSize", quarterViewportPixelSize );

					context.RenderQuadToCurrentViewport( shader );
				}

			}

			// Third Pass: Generate 4 SSAO buffers:

			Component_Image blurPingTexture = null, blurPongTexture = null;

			if( BlurAmount.Value > 0 )
			{
				blurPingTexture = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 2, PixelFormat.R8G8_UInt );
				blurPongTexture = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 2, PixelFormat.R8G8_UInt );
			}

			SSAOTextureArray = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize / 2, PixelFormat.R8G8_UInt, 0, false, /*0,*/ 4 );

			for( int pass = 0; pass < 4; pass++ )
			{

				Vector4F[] patternRotScaleMatrices;
				GeneratePatternRotScaleMatrices( pass, out patternRotScaleMatrices );

				Vector2F perPassFullResCoordOffset = new Vector2F( (float)( pass % 2 ), (float)( pass / 2 ) );

				{
					if( BlurAmount.Value == 0 )
					{
						context.SetViewport( SSAOTextureArray.Result.GetRenderTarget( 0, pass ).Viewports[ 0 ],
							Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );
					}
					else
					{
						context.SetViewport( blurPingTexture.Result.GetRenderTarget().Viewports[ 0 ],
							Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );
					}

					CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
					shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";

					if( Quality.Value == QualityEnum.Low )
						shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateSSAO_LQ_fs.sc";
					else if( Quality.Value == QualityEnum.Medium )
						shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateSSAO_MQ_fs.sc";
					else if( Quality.Value == QualityEnum.High )
						shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateSSAO_HQ_fs.sc";
					else if( Quality.Value == QualityEnum.HighestAdaptive )
						shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\GenerateSSAO_HAQ_fs.sc";

					context.objectsDuringUpdate.namedTextures.TryGetValue( "normalTexture", out Component_Image normalTexture );

					if( Quality.Value > QualityEnum.Medium )
					{
						for( int m = 0; m < 4; m++ )
						{
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( m, depthMipMaps[ pass, m ],
								TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
						}

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 4, halfDepths[ pass ],
							TextureAddressingMode.Mirror, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 5, normalTexture,
							TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						if( Quality.Value == QualityEnum.HighestAdaptive )
						{
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 6, importanceMap,
								TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 7, averageImportance,
								TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 8, SSAOBaseTextureArray,
								TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
						}
					}
					else
					{
						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, halfDepths[ pass ],
							TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 1, halfDepths[ pass ],
							TextureAddressingMode.Mirror, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

						shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 2, normalTexture,
							TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
					}

					shader.Parameters.Set( "NDCToViewMul", NDCToViewMul );
					shader.Parameters.Set( "NDCToViewAdd", NDCToViewAdd );
					shader.Parameters.Set( "effectRadiusParams", effectRadiusParams );
					shader.Parameters.Set( "viewportPixelSize", viewportPixelSize );
					shader.Parameters.Set( "viewport2xPixelSize", viewport2xPixelSize );
					shader.Parameters.Set( "halfViewportPixelSize", halfViewportPixelSize );
					shader.Parameters.Set( "perPassFullResCoordOffset", perPassFullResCoordOffset );
					shader.Parameters.Set( "patternRotScaleMatrices", patternRotScaleMatrices );
					shader.Parameters.Set( "effectFadeOutMul", effectFadeOutMul );
					shader.Parameters.Set( "effectFadeOutAdd", effectFadeOutAdd );
					shader.Parameters.Set( "effectShadowStrength", effectShadowStrength );
					shader.Parameters.Set( "effectShadowClamp", effectShadowClamp );
					shader.Parameters.Set( "effectShadowPow", effectShadowPow );
					shader.Parameters.Set( "detailAOStrength", detailAOStrength );
					shader.Parameters.Set( "itViewMatrix", itViewMatrix );

					if( Quality.Value == QualityEnum.HighestAdaptive )
					{
						shader.Parameters.Set( "adaptiveSampleCountLimit", (float)AdaptiveQualityLimit );
						shader.Parameters.Set( "passNumber", (float)pass );
					}

					context.RenderQuadToCurrentViewport( shader );

				}

				if( Quality.Value > QualityEnum.Medium )
				{
					// Free Mip-Maps Targets for this Pass:
					for( int m = 0; m < 4; m++ )
						context.DynamicTexture_Free( depthMipMaps[ pass, m ] );
				}
				else
				{
					context.DynamicTexture_Free( halfDepths[ pass ] );
				}

				// Blur SSAO Texture:

				if( BlurAmount.Value > 0 )
				{
					int wideBlursRemaining = Math.Max( 0, BlurAmount.Value - 2 );

					for( int i = 0; i < BlurAmount.Value; i++ )
					{
						if( i == ( BlurAmount.Value - 1 ) )
						{
							context.SetViewport( SSAOTextureArray.Result.GetRenderTarget( 0, pass ).Viewports[ 0 ],
								Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );
						}
						else
						{
							context.SetViewport( blurPongTexture.Result.GetRenderTarget().Viewports[ 0 ],
								Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );
						}

						CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
						shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";

						if( Quality.Value > QualityEnum.Low )
						{
							if( wideBlursRemaining > 0 )
							{
								shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\SmartBlurWide_fs.sc";
								wideBlursRemaining--;
							}
							else
							{
								shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\SmartBlur_fs.sc";
							}
						}
						else
						{
							shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\NonSmartBlur_fs.sc";
						}

						if( Quality.Value > QualityEnum.Low )
						{
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, blurPingTexture,
								TextureAddressingMode.Mirror, FilterOption.Point, FilterOption.Point, FilterOption.None ) );
							shader.Parameters.Set( "invSharpness", invSharpness );
						}
						else
						{
							shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, blurPingTexture,
								TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );
						}

						shader.Parameters.Set( "halfViewportPixelSize", halfViewportPixelSize );

						context.RenderQuadToCurrentViewport( shader );

						// Swap Ping-Pong Blur textures:
						var tmp_tex = blurPingTexture;
						blurPingTexture = blurPongTexture;
						blurPongTexture = tmp_tex;
					}

				}
			}

			if( Quality.Value == QualityEnum.HighestAdaptive )
				context.DynamicTexture_Free( SSAOBaseTextureArray );

			if( Quality.Value == QualityEnum.HighestAdaptive )
			{
				context.DynamicTexture_Free( importanceMap );
				context.DynamicTexture_Free( averageImportance );
			}

			if( BlurAmount.Value > 0 )
			{
				// Free Blur ping/pong Targets:
				context.DynamicTexture_Free( blurPingTexture );
				context.DynamicTexture_Free( blurPongTexture );
			}

			// 4th Pass: Apply 4 SSAO Textures to Final SSAO Result:

			var FullSSAOTexture = context.RenderTarget2D_Alloc( actualTexture.Result.ResultSize, PixelFormat.R8G8_UInt );
			{
				context.SetViewport( FullSSAOTexture.Result.GetRenderTarget().Viewports[ 0 ],
					Matrix4F.Identity, Matrix4F.Identity, FrameBufferTypes.All, ColorValue.Zero );

				CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
				shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";

				if( Quality.Value > QualityEnum.Low )
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\Apply_fs.sc";
				else
					shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\Apply_noSmart_fs.sc";

				if( Quality.Value > QualityEnum.Low )
				{
					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, SSAOTextureArray,
						TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 1, SSAOTextureArray,
					TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );
				}
				else
				{
					shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, SSAOTextureArray,
						TextureAddressingMode.Clamp, FilterOption.Linear, FilterOption.Linear, FilterOption.None ) );
				}

				if( Quality.Value > QualityEnum.Low )
				{
					shader.Parameters.Set( "invSharpness", invSharpness );
					shader.Parameters.Set( "halfViewportPixelSize", halfViewportPixelSize );
				}

				context.RenderQuadToCurrentViewport( shader );
			}

			// Free SSAO Texture Array Target:
			context.DynamicTexture_Free( SSAOTextureArray );

			// 5th Final Pass:
			var finalTexture = context.RenderTarget2D_Alloc( actualTextureSource.Result.ResultSize, actualTextureSource.Result.ResultFormat );
			{
				context.SetViewport( finalTexture.Result.GetRenderTarget().Viewports[ 0 ] );

				CanvasRenderer.ShaderItem shader = new CanvasRenderer.ShaderItem();
				shader.VertexProgramFileName = @"Base\Shaders\EffectsCommon_vs.sc";
				shader.FragmentProgramFileName = @"Base\Shaders\Effects\ASSAO\Final_fs.sc";

				shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 0, actualTextureSource,
					TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

				shader.Parameters.Set( new ViewportRenderingContext.BindTextureData( 1, FullSSAOTexture,
					TextureAddressingMode.Clamp, FilterOption.Point, FilterOption.Point, FilterOption.None ) );

				shader.Parameters.Set( "intensity", (float)Intensity );
				shader.Parameters.Set( "showAO", ShowAO ? 1.0f : -1.0f );

				context.RenderQuadToCurrentViewport( shader );
			}

			// Free Targets:
			context.DynamicTexture_Free( actualTexture );
			if( actualTextureSource != actualTexture )
				context.DynamicTexture_Free( actualTextureSource );
			context.DynamicTexture_Free( FullSSAOTexture );

			// Update actual Texture:
			actualTexture = finalTexture;
		}
	}
}
