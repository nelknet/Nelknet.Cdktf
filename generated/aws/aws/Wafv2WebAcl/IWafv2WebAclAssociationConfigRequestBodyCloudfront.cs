using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBodyCloudfront), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront")]
    public interface IWafv2WebAclAssociationConfigRequestBodyCloudfront
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#default_size_inspection_limit Wafv2WebAcl#default_size_inspection_limit}.</summary>
        [JsiiProperty(name: "defaultSizeInspectionLimit", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultSizeInspectionLimit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBodyCloudfront), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront
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
