using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationSheetOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationSheetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationSheetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightThemeConfigurationSheetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationSheetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}}]")]
        public virtual void PutTile(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTileLayout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}}]")]
        public virtual void PutTileLayout(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTile")]
        public virtual void ResetTile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTileLayout")]
        public virtual void ResetTileLayout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "tile", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileOutputReference Tile
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileOutputReference>()!;
        }

        [JsiiProperty(name: "tileLayout", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutOutputReference TileLayout
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileLayoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tileInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile? TileInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tileLayoutInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout? TileLayoutInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheet? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheet?>();
            set => SetInstanceProperty(value);
        }
    }
}
