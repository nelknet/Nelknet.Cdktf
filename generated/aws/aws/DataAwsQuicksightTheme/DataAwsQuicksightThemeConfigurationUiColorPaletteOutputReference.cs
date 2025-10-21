using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsQuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.DataAwsQuicksightTheme.DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference), fullyQualifiedName: "aws.dataAwsQuicksightTheme.DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightThemeConfigurationUiColorPaletteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Accent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accentForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccentForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "danger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Danger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dangerForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DangerForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dimension
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimensionForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DimensionForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "measure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Measure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "measureForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeasureForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBackground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBackground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBackground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBackground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "success", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Success
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Warning
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warningForeground", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarningForeground
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightTheme.DataAwsQuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
        public virtual aws.DataAwsQuicksightTheme.IDataAwsQuicksightThemeConfigurationUiColorPalette? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightTheme.IDataAwsQuicksightThemeConfigurationUiColorPalette?>();
            set => SetInstanceProperty(value);
        }
    }
}
