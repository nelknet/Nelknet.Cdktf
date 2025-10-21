using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafWebAcl
{
    [JsiiInterface(nativeType: typeof(IWafWebAclRulesOverrideAction), fullyQualifiedName: "aws.wafWebAcl.WafWebAclRulesOverrideAction")]
    public interface IWafWebAclRulesOverrideAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#type WafWebAcl#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclRulesOverrideAction), fullyQualifiedName: "aws.wafWebAcl.WafWebAclRulesOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.WafWebAcl.IWafWebAclRulesOverrideAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#type WafWebAcl#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
