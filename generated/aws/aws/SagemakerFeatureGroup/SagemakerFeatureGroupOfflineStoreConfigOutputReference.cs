using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiClass(nativeType: typeof(aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigOutputReference), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerFeatureGroupOfflineStoreConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerFeatureGroupOfflineStoreConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerFeatureGroupOfflineStoreConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOfflineStoreConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataCatalogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}}]")]
        public virtual void PutDataCatalogConfig(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3StorageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}}]")]
        public virtual void PutS3StorageConfig(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataCatalogConfig")]
        public virtual void ResetDataCatalogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableGlueTableCreation")]
        public virtual void ResetDisableGlueTableCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableFormat")]
        public virtual void ResetTableFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference\"}")]
        public virtual aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference DataCatalogConfig
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfigOutputReference>()!;
        }

        [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference\"}")]
        public virtual aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference S3StorageConfig
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCatalogConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableGlueTableCreationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableGlueTableCreationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3StorageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig? S3StorageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableGlueTableCreation
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "tableFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
