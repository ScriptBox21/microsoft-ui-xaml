﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.0.0-build.101+g12769c43d3
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile BrightnessSun.json
//       
//       Input file:
//           BrightnessSun.json (3791 bytes created 15:52-08:00 Feb 25 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |   200 |
// |--------------------------+-------|
// | Expression animators     |    56 |
// | KeyFrame animators       |    28 |
// | Reference parameters     |    56 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |    29 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |    16 |
// |--------------------------+-------|
// | Brushes                  |     3 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace AnimatedVisuals
{
    // Name:        Sun Animation
    // Frame rate:  25 fps
    // Frame count: 40
    // Duration:    1600.0 mS
    sealed class BrightnessSun
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource, Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 1.600 seconds.
        internal const long c_durationTicks = 16000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (BrightnessSun_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new BrightnessSun_AnimatedVisual(
                        compositor
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 40d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 25d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 40d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class BrightnessSun_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 16000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorBrush _colorBrush_AlmostGoldenrod_FFE4950C;
            CompositionPath _path;
            ContainerVisual _root;
            ExpressionAnimation _rootProgress;
            ScalarKeyFrameAnimation _tEndScalarAnimation_1_to_0;
            ScalarKeyFrameAnimation _tStartScalarAnimation_1_to_0;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-9F, -134F));
                    builder.AddLine(new Vector2(-9F, -68F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Scale:0.70016,1.05751, Offset:<202, 162>
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(3F, -54F));
                    builder.AddCubicBezier(new Vector2(22.2800007F, -39.7159996F), new Vector2(51F, 26F), new Vector2(0F, 53F));
                    builder.AddCubicBezier(new Vector2(17.1389999F, 58.6279984F), new Vector2(43.5250015F, 26.9519997F), new Vector2(40.9780006F, -6.6079998F));
                    builder.AddCubicBezier(new Vector2(39.7750015F, -22.4619999F), new Vector2(30.8500004F, -43.4980011F), new Vector2(3F, -54F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Layer aggregator
            // Scale:0.8,0.8, Offset:<178.4, 151.2>
            CompositionColorBrush ColorBrush_AlmostDarkOrange_FFF18F13()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xF1, 0x8F, 0x13));
            }

            CompositionColorBrush ColorBrush_AlmostGoldenrod_FFE4950C()
            {
                return _colorBrush_AlmostGoldenrod_FFE4950C = _c.CreateColorBrush(Color.FromArgb(0xFF, 0xE4, 0x95, 0x0C));
            }

            // - Layer aggregator
            // Scale:0.70016,1.05751, Offset:<202, 162>
            CompositionColorBrush ColorBrush_SemiTransparentWhite()
            {
                return _c.CreateColorBrush(Color.FromArgb(0x38, 0xFF, 0xFF, 0xFF));
            }

            // - Layer aggregator
            // Scale:0.8,0.8, Offset:<178.4, 151.2>
            // Ellipse Path 1.EllipseGeometry
            CompositionEllipseGeometry Ellipse_74p5()
            {
                var result = _c.CreateEllipseGeometry();
                result.Radius = new Vector2(74.5F, 74.5F);
                return result;
            }

            CompositionPath Path()
            {
                var result = _path = new CompositionPath(Geometry_0());
                return result;
            }

            CompositionPathGeometry PathGeometry_00()
            {
                var result = _c.CreatePathGeometry(Path());
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", TStartScalarAnimation_1_to_0(), RootProgress());
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", TEndScalarAnimation_1_to_0(), _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_01()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_02()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_03()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_04()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_05()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_06()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_07()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_08()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_09()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_10()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_11()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_12()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            CompositionPathGeometry PathGeometry_13()
            {
                var result = _c.CreatePathGeometry(_path);
                var propertySet = result.Properties;
                propertySet.InsertScalar("TEnd", 1F);
                propertySet.InsertScalar("TStart", 1F);
                StartProgressBoundAnimation(result, "TStart", _tStartScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimStart", "Min(my.TStart,my.TEnd)", "my", result);
                StartProgressBoundAnimation(result, "TEnd", _tEndScalarAnimation_1_to_0, _rootProgress);
                BindProperty(result, "TrimEnd", "Max(my.TStart,my.TEnd)", "my", result);
                return result;
            }

            // - Layer aggregator
            // Scale:0.70016,1.05751, Offset:<202, 162>
            CompositionPathGeometry PathGeometry_14()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // Layer aggregator
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_00()
            {
                // Offset:<190, 162>, Rotation:-0.011598425070025746 degrees, Scale:<0.8, 0.8>
                var result = CreateSpriteShape(Ellipse_74p5(), new Matrix3x2(0.800000012F, 0F, 0F, 0.800000012F, 190F, 162F), ColorBrush_AlmostDarkOrange_FFF18F13());
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_01()
            {
                // Offset:<193.31511, 158.30362>, Rotation:25.999998864742253 degrees
                var result = CreateSpriteShape(PathGeometry_00(), new Matrix3x2(0.898794055F, 0.438371152F, -0.438371152F, 0.898794055F, 193.315109F, 158.303619F));
                result.StrokeBrush = ColorBrush_AlmostGoldenrod_FFE4950C();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_02()
            {
                // Offset:<195.67914, 156.45663>, Rotation:52.00000073708994 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_01(), new Matrix3x2(0.615661502F, 0.788010776F, -0.788010776F, 0.615661502F, 195.679138F, 156.456635F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_03()
            {
                // Offset:<198.61359, 155.8329>, Rotation:78.00000018744032 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_02(), new Matrix3x2(0.2079117F, 0.978147626F, -0.978147626F, 0.2079117F, 198.613586F, 155.832901F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_04()
            {
                // Offset:<201.52448, 156.55867>, Rotation:104.00000036039357 degrees
                var result = CreateSpriteShape(PathGeometry_03(), new Matrix3x2(-0.241921902F, 0.970295727F, -0.970295727F, -0.241921902F, 201.524475F, 156.55867F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_05()
            {
                // Offset:<203.8226, 158.48703>, Rotation:130.0000019177151 degrees
                var result = CreateSpriteShape(PathGeometry_04(), new Matrix3x2(-0.642787635F, 0.766044438F, -0.766044438F, -0.642787635F, 203.822601F, 158.48703F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_06()
            {
                // Offset:<205.04282, 161.22766>, Rotation:156.0000044610642 degrees
                var result = CreateSpriteShape(PathGeometry_05(), new Matrix3x2(-0.913545489F, 0.406736642F, -0.406736642F, -0.913545489F, 205.042816F, 161.227661F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_07()
            {
                // Offset:<204.93811, 164.22583>, Rotation:-178.0000222417307 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_06(), new Matrix3x2(-0.9993909F, -0.034899503F, 0.034899503F, -0.9993909F, 204.93811F, 164.22583F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_08()
            {
                // Offset:<203.5297, 166.87468>, Rotation:-151.99999734470822 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_07(), new Matrix3x2(-0.882947624F, -0.469471633F, 0.469471633F, -0.882947624F, 203.529694F, 166.87468F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_09()
            {
                // Offset:<201.10265, 168.63803>, Rotation:-125.99999693065644 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_08(), new Matrix3x2(-0.587785244F, -0.809017062F, 0.809017062F, -0.587785244F, 201.102646F, 168.638031F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_10()
            {
                // Offset:<198.14822, 169.15898>, Rotation:-99.99999771691004 degrees, Scale:<1, 1>
                var result = CreateSpriteShape(PathGeometry_09(), new Matrix3x2(-0.173648149F, -0.984807849F, 0.984807849F, -0.173648149F, 198.148224F, 169.158981F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_11()
            {
                // Offset:<195.26443, 168.33206>, Rotation:-73.999998250233 degrees,
                // Scale:<1.0000001, 1.0000001>
                var result = CreateSpriteShape(PathGeometry_10(), new Matrix3x2(0.275637418F, -0.961261809F, 0.961261809F, 0.275637418F, 195.264435F, 168.332062F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_12()
            {
                // Offset:<193.035, 166.32468>, Rotation:-47.9999987246911 degrees,
                // Scale:<1.0000001, 1.0000001>
                var result = CreateSpriteShape(PathGeometry_11(), new Matrix3x2(0.669130743F, -0.743144929F, 0.743144929F, 0.669130743F, 193.035004F, 166.324677F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_13()
            {
                // Offset:<191.91118, 163.54312>, Rotation:-22.000004635862652 degrees,
                // Scale:<1.0000002, 1.0000002>
                var result = CreateSpriteShape(PathGeometry_12(), new Matrix3x2(0.927184045F, -0.374606639F, 0.374606639F, 0.927184045F, 191.911179F, 163.543121F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_14()
            {
                // Offset:<192.12045, 160.55043>, Rotation:4.000026206779586 degrees,
                // Scale:<1.0000002, 1.0000002>
                var result = CreateSpriteShape(PathGeometry_13(), new Matrix3x2(0.997564256F, 0.0697565377F, -0.0697565377F, 0.997564256F, 192.120453F, 160.55043F));
                result.StrokeBrush = _colorBrush_AlmostGoldenrod_FFE4950C;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_15()
            {
                // Offset:<202, 162>, Rotation:-0.008999309291422224 degrees,
                // Scale:<1.1669357, 1.05751>
                var result = CreateSpriteShape(PathGeometry_14(), new Matrix3x2(1.16693568F, 0F, 0F, 1.05751002F, 202F, 162F), ColorBrush_SemiTransparentWhite());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // TEnd
            ScalarKeyFrameAnimation TEndScalarAnimation_1_to_0()
            {
                var result = _tEndScalarAnimation_1_to_0 = CreateScalarKeyFrameAnimation(0F, 1F, StepThenHoldEasingFunction());
                result.InsertKeyFrame(0.125F, 1F, _holdThenStepEasingFunction);
                result.InsertKeyFrame(0.75F, 0F, _c.CreateCubicBezierEasingFunction(new Vector2(0F, 0F), new Vector2(0F, 0.899999976F)));
                return result;
            }

            // TStart
            ScalarKeyFrameAnimation TStartScalarAnimation_1_to_0()
            {
                var result = _tStartScalarAnimation_1_to_0 = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                result.InsertKeyFrame(0.649999976F, 0F, _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0F), new Vector2(0F, 0.896000028F)));
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(380F, 324F);
                var shapes = result.Shapes;
                // Scale:0.8,0.8, Offset:<178.4, 151.2>
                shapes.Add(SpriteShape_00());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_01());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_02());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_03());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_04());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_05());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_06());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_07());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_08());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_09());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_10());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_11());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_12());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_13());
                // Offset:<192, 161>
                shapes.Add(SpriteShape_14());
                // Scale:0.70016,1.05751, Offset:<202, 162>
                shapes.Add(SpriteShape_15());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // TEnd
            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            internal BrightnessSun_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(380F, 324F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
