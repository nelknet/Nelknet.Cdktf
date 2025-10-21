using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueDataCatalogEncryptionSettings
{
    [JsiiClass(nativeType: typeof(aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference), fullyQualifiedName: "aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPasswordEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}}]")]
        public virtual void PutConnectionPasswordEncryption(aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionAtRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}}]")]
        public virtual void PutEncryptionAtRest(aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest)}, new object[]{@value});
        }

        [JsiiProperty(name: "connectionPasswordEncryption", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference\"}")]
        public virtual aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference ConnectionPasswordEncryption
        {
            get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference\"}")]
        public virtual aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference EncryptionAtRest
        {
            get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPasswordEncryptionInput", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption\"}", isOptional: true)]
        public virtual aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption? ConnectionPasswordEncryptionInput
        {
            get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestInput", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest\"}", isOptional: true)]
        public virtual aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest? EncryptionAtRestInput
        {
            get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings\"}", isOptional: true)]
        public virtual aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings? InternalValue
        {
            get => GetInstanceProperty<aws.GlueDataCatalogEncryptionSettings.IGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
