using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfig")]
    public class SagemakerFeatureGroupOfflineStoreConfig : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfig
    {
        /// <summary>s3_storage_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#s3_storage_config SagemakerFeatureGroup#s3_storage_config}
        /// </remarks>
        [JsiiProperty(name: "s3StorageConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigS3StorageConfig\"}")]
        public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigS3StorageConfig S3StorageConfig
        {
            get;
            set;
        }

        /// <summary>data_catalog_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#data_catalog_config SagemakerFeatureGroup#data_catalog_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCatalogConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig\"}", isOptional: true)]
        public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOfflineStoreConfigDataCatalogConfig? DataCatalogConfig
        {
            get;
            set;
        }

        private object? _disableGlueTableCreation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#disable_glue_table_creation SagemakerFeatureGroup#disable_glue_table_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableGlueTableCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableGlueTableCreation
        {
            get => _disableGlueTableCreation;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disableGlueTableCreation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#table_format SagemakerFeatureGroup#table_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TableFormat
        {
            get;
            set;
        }
    }
}
