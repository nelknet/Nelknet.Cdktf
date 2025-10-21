using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleExistingObjectReplication), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleExistingObjectReplication")]
    public interface IS3BucketReplicationConfigurationRuleExistingObjectReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleExistingObjectReplication), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleExistingObjectReplication")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleExistingObjectReplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
