//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace VrPlayer.Models.Effects{
	
	/// <summary>An effect that makes pixels of a particular color transparent.</summary>
	public class ColorKeyAlphaEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(ColorKeyAlphaEffect), 0);
		public static readonly DependencyProperty ColorKeyProperty = DependencyProperty.Register("ColorKey", typeof(Color), typeof(ColorKeyAlphaEffect), new UIPropertyMetadata(Color.FromArgb(255, 0, 128, 0), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty ToleranceProperty = DependencyProperty.Register("Tolerance", typeof(double), typeof(ColorKeyAlphaEffect), new UIPropertyMetadata(((double)(0.3D)), PixelShaderConstantCallback(1)));
		public ColorKeyAlphaEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("pack://application:,,,/Models/Effects/ColorKeyAlphaEffect.ps");
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(ColorKeyProperty);
			this.UpdateShaderValue(ToleranceProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The color that becomes transparent.</summary>
		public Color ColorKey {
			get {
				return ((Color)(this.GetValue(ColorKeyProperty)));
			}
			set {
				this.SetValue(ColorKeyProperty, value);
			}
		}
		/// <summary>The tolerance in color differences.</summary>
		public double Tolerance {
			get {
				return ((double)(this.GetValue(ToleranceProperty)));
			}
			set {
				this.SetValue(ToleranceProperty, value);
			}
		}
	}
}