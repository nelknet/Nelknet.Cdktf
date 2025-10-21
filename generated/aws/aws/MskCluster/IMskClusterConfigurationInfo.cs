using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.mskCluster.MskClusterConfigurationInfo")]
    public interface IMskClusterConfigurationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#arn MskCluster#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#revision MskCluster#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        double Revision
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.mskCluster.MskClusterConfigurationInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterConfigurationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#arn MskCluster#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#revision MskCluster#revision}.</summary>
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
            public double Revision
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
