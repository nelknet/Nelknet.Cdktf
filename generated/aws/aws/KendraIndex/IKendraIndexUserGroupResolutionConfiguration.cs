using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexUserGroupResolutionConfiguration), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserGroupResolutionConfiguration")]
    public interface IKendraIndexUserGroupResolutionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_group_resolution_mode KendraIndex#user_group_resolution_mode}.</summary>
        [JsiiProperty(name: "userGroupResolutionMode", typeJson: "{\"primitive\":\"string\"}")]
        string UserGroupResolutionMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexUserGroupResolutionConfiguration), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserGroupResolutionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_group_resolution_mode KendraIndex#user_group_resolution_mode}.</summary>
            [JsiiProperty(name: "userGroupResolutionMode", typeJson: "{\"primitive\":\"string\"}")]
            public string UserGroupResolutionMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
