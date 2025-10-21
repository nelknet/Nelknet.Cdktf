using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeDataLake
{
    [JsiiByValue(fqn: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationTransition")]
    public class SecuritylakeDataLakeConfigurationLifecycleConfigurationTransition : aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationTransition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#days SecuritylakeDataLake#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#storage_class SecuritylakeDataLake#storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
