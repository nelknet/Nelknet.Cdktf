using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationSheetTileLayoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationSheetTileLayoutOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightThemeConfigurationSheetTileLayoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationSheetTileLayoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGutter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutter\"}}]")]
        public virtual void PutGutter(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMargin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMargin\"}}]")]
        public virtual void PutMargin(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGutter")]
        public virtual void ResetGutter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMargin")]
        public virtual void ResetMargin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "gutter", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutterOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutterOutputReference Gutter
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutterOutputReference>()!;
        }

        [JsiiProperty(name: "margin", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMarginOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMarginOutputReference Margin
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMarginOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gutterInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutter\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter? GutterInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marginInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMargin\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin? MarginInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout?>();
            set => SetInstanceProperty(value);
        }
    }
}
