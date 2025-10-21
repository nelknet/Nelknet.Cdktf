using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInputSecurityGroup
{
    [JsiiInterface(nativeType: typeof(IMedialiveInputSecurityGroupWhitelistRules), fullyQualifiedName: "aws.medialiveInputSecurityGroup.MedialiveInputSecurityGroupWhitelistRules")]
    public interface IMedialiveInputSecurityGroupWhitelistRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#cidr MedialiveInputSecurityGroup#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        string Cidr
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveInputSecurityGroupWhitelistRules), fullyQualifiedName: "aws.medialiveInputSecurityGroup.MedialiveInputSecurityGroupWhitelistRules")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveInputSecurityGroup.IMedialiveInputSecurityGroupWhitelistRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#cidr MedialiveInputSecurityGroup#cidr}.</summary>
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
            public string Cidr
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
