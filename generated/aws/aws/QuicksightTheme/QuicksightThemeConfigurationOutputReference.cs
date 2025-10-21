using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightThemeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataColorPalette", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette\"}}]")]
        public virtual void PutDataColorPalette(aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSheet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}}]")]
        public virtual void PutSheet(aws.QuicksightTheme.IQuicksightThemeConfigurationSheet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTypography", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}}]")]
        public virtual void PutTypography(aws.QuicksightTheme.IQuicksightThemeConfigurationTypography @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationTypography)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUiColorPalette", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}}]")]
        public virtual void PutUiColorPalette(aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataColorPalette")]
        public virtual void ResetDataColorPalette()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSheet")]
        public virtual void ResetSheet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTypography")]
        public virtual void ResetTypography()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUiColorPalette")]
        public virtual void ResetUiColorPalette()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPaletteOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationDataColorPaletteOutputReference DataColorPalette
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationDataColorPaletteOutputReference>()!;
        }

        [JsiiProperty(name: "sheet", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetOutputReference Sheet
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetOutputReference>()!;
        }

        [JsiiProperty(name: "typography", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationTypographyOutputReference Typography
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationTypographyOutputReference>()!;
        }

        [JsiiProperty(name: "uiColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPaletteOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationUiColorPaletteOutputReference UiColorPalette
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationUiColorPaletteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataColorPaletteInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette? DataColorPaletteInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sheetInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheet? SheetInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typographyInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationTypography? TypographyInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationTypography?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uiColorPaletteInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette? UiColorPaletteInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfiguration\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
