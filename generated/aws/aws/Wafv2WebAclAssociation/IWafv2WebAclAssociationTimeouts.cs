using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclAssociationTimeouts), fullyQualifiedName: "aws.wafv2WebAclAssociation.Wafv2WebAclAssociationTimeouts")]
    public interface IWafv2WebAclAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#create Wafv2WebAclAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclAssociationTimeouts), fullyQualifiedName: "aws.wafv2WebAclAssociation.Wafv2WebAclAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclAssociation.IWafv2WebAclAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#create Wafv2WebAclAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
