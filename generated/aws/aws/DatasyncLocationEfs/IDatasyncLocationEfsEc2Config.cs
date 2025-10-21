using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationEfs
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationEfsEc2Config), fullyQualifiedName: "aws.datasyncLocationEfs.DatasyncLocationEfsEc2Config")]
    public interface IDatasyncLocationEfsEc2Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#security_group_arns DatasyncLocationEfs#security_group_arns}.</summary>
        [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupArns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#subnet_arn DatasyncLocationEfs#subnet_arn}.</summary>
        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationEfsEc2Config), fullyQualifiedName: "aws.datasyncLocationEfs.DatasyncLocationEfsEc2Config")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationEfs.IDatasyncLocationEfsEc2Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#security_group_arns DatasyncLocationEfs#security_group_arns}.</summary>
            [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#subnet_arn DatasyncLocationEfs#subnet_arn}.</summary>
            [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
