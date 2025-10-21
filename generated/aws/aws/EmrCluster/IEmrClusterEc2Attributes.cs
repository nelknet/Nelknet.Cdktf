using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterEc2Attributes), fullyQualifiedName: "aws.emrCluster.EmrClusterEc2Attributes")]
    public interface IEmrClusterEc2Attributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_profile EmrCluster#instance_profile}.</summary>
        [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_master_security_groups EmrCluster#additional_master_security_groups}.</summary>
        [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalMasterSecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_slave_security_groups EmrCluster#additional_slave_security_groups}.</summary>
        [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalSlaveSecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_master_security_group EmrCluster#emr_managed_master_security_group}.</summary>
        [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmrManagedMasterSecurityGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_slave_security_group EmrCluster#emr_managed_slave_security_group}.</summary>
        [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmrManagedSlaveSecurityGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#key_name EmrCluster#key_name}.</summary>
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#service_access_security_group EmrCluster#service_access_security_group}.</summary>
        [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessSecurityGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_id EmrCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_ids EmrCluster#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterEc2Attributes), fullyQualifiedName: "aws.emrCluster.EmrClusterEc2Attributes")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterEc2Attributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_profile EmrCluster#instance_profile}.</summary>
            [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceProfile
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_master_security_groups EmrCluster#additional_master_security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalMasterSecurityGroups
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_slave_security_groups EmrCluster#additional_slave_security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalSlaveSecurityGroups
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_master_security_group EmrCluster#emr_managed_master_security_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmrManagedMasterSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_slave_security_group EmrCluster#emr_managed_slave_security_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmrManagedSlaveSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#key_name EmrCluster#key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#service_access_security_group EmrCluster#service_access_security_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_id EmrCluster#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_ids EmrCluster#subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
