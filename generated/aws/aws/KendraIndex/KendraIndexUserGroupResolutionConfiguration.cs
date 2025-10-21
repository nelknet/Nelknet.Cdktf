using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexUserGroupResolutionConfiguration")]
    public class KendraIndexUserGroupResolutionConfiguration : aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_group_resolution_mode KendraIndex#user_group_resolution_mode}.</summary>
        [JsiiProperty(name: "userGroupResolutionMode", typeJson: "{\"primitive\":\"string\"}")]
        public string UserGroupResolutionMode
        {
            get;
            set;
        }
    }
}
