using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAclAssociation
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclAssociationTimeouts), fullyQualifiedName: "aws.wafregionalWebAclAssociation.WafregionalWebAclAssociationTimeouts")]
    public interface IWafregionalWebAclAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#create WafregionalWebAclAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclAssociationTimeouts), fullyQualifiedName: "aws.wafregionalWebAclAssociation.WafregionalWebAclAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalWebAclAssociation.IWafregionalWebAclAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#create WafregionalWebAclAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
