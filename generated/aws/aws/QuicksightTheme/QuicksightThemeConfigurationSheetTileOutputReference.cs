using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationSheetTileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationSheetTileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightThemeConfigurationSheetTileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationSheetTileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBorder", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder\"}}]")]
        public virtual void PutBorder(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBorder")]
        public virtual void ResetBorder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "border", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorderOutputReference\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileBorderOutputReference Border
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationSheetTileBorderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "borderInput", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder? BorderInput
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile?>();
            set => SetInstanceProperty(value);
        }
    }
}
