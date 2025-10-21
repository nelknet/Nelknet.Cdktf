using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeDataLake
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration), fullyQualifiedName: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration")]
    public interface ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#days SecuritylakeDataLake#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration), fullyQualifiedName: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#days SecuritylakeDataLake#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
