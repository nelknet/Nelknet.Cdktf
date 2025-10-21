using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationUiColorPaletteOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationUiColorPaletteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationUiColorPaletteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationUiColorPaletteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationUiColorPaletteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationUiColorPaletteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccent")]
        public virtual void ResetAccent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccentForeground")]
        public virtual void ResetAccentForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDanger")]
        public virtual void ResetDanger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDangerForeground")]
        public virtual void ResetDangerForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimension")]
        public virtual void ResetDimension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimensionForeground")]
        public virtual void ResetDimensionForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeasure")]
        public virtual void ResetMeasure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeasureForeground")]
        public virtual void ResetMeasureForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryBackground")]
        public virtual void ResetPrimaryBackground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryForeground")]
        public virtual void ResetPrimaryForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryBackground")]
        public virtual void ResetSecondaryBackground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryForeground")]
        public virtual void ResetSecondaryForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccess")]
        public virtual void ResetSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessForeground")]
        public virtual void ResetSuccessForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarning")]
        public virtual void ResetWarning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarningForeground")]
        public virtual void ResetWarningForeground()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accentForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccentForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dangerForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DangerForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dangerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DangerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DimensionForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DimensionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "measureForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeasureForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "measureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeasureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryBackgroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryBackgroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryBackgroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecondaryBackgroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecondaryForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccessForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warningForegroundInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarningForegroundInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warningInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarningInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Accent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accentForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccentForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "danger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Danger
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dangerForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DangerForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dimension
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dimensionForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DimensionForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "measure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Measure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "measureForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeasureForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryBackground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBackground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryBackground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBackground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "success", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Success
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Warning
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warningForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarningForeground
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette?>();
            set => SetInstanceProperty(value);
        }
    }
}
