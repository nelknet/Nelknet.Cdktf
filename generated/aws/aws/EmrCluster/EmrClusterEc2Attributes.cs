using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterEc2Attributes")]
    public class EmrClusterEc2Attributes : aws.EmrCluster.IEmrClusterEc2Attributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_profile EmrCluster#instance_profile}.</summary>
        [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_master_security_groups EmrCluster#additional_master_security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalMasterSecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_slave_security_groups EmrCluster#additional_slave_security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalSlaveSecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_master_security_group EmrCluster#emr_managed_master_security_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmrManagedMasterSecurityGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#emr_managed_slave_security_group EmrCluster#emr_managed_slave_security_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmrManagedSlaveSecurityGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#key_name EmrCluster#key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#service_access_security_group EmrCluster#service_access_security_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccessSecurityGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_id EmrCluster#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#subnet_ids EmrCluster#subnet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubnetIds
        {
            get;
            set;
        }
    }
}
