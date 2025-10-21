using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IEfsReplicationConfigurationDestination), fullyQualifiedName: "aws.efsReplicationConfiguration.EfsReplicationConfigurationDestination")]
    public interface IEfsReplicationConfigurationDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#availability_zone_name EfsReplicationConfiguration#availability_zone_name}.</summary>
        [JsiiProperty(name: "availabilityZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZoneName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#file_system_id EfsReplicationConfiguration#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileSystemId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#kms_key_id EfsReplicationConfiguration#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#region EfsReplicationConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsReplicationConfigurationDestination), fullyQualifiedName: "aws.efsReplicationConfiguration.EfsReplicationConfigurationDestination")]
        internal sealed class _Proxy : DeputyBase, aws.EfsReplicationConfiguration.IEfsReplicationConfigurationDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#availability_zone_name EfsReplicationConfiguration#availability_zone_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZoneName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#file_system_id EfsReplicationConfiguration#file_system_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileSystemId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#kms_key_id EfsReplicationConfiguration#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#region EfsReplicationConfiguration#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
