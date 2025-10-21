using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLaunchTemplate
{
    [JsiiInterface(nativeType: typeof(IDataAwsLaunchTemplateTimeouts), fullyQualifiedName: "aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts")]
    public interface IDataAwsLaunchTemplateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#read DataAwsLaunchTemplate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLaunchTemplateTimeouts), fullyQualifiedName: "aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#read DataAwsLaunchTemplate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
