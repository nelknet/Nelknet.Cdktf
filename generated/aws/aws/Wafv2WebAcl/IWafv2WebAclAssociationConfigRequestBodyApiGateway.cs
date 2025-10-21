using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBodyApiGateway), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway")]
    public interface IWafv2WebAclAssociationConfigRequestBodyApiGateway
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#default_size_inspection_limit Wafv2WebAcl#default_size_inspection_limit}.</summary>
        [JsiiProperty(name: "defaultSizeInspectionLimit", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultSizeInspectionLimit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBodyApiGateway), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#default_size_inspection_limit Wafv2WebAcl#default_size_inspection_limit}.</summary>
            [JsiiProperty(name: "defaultSizeInspectionLimit", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultSizeInspectionLimit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
