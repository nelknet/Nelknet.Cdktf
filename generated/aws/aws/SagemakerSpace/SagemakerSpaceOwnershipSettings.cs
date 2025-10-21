using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceOwnershipSettings")]
    public class SagemakerSpaceOwnershipSettings : aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#owner_user_profile_name SagemakerSpace#owner_user_profile_name}.</summary>
        [JsiiProperty(name: "ownerUserProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public string OwnerUserProfileName
        {
            get;
            set;
        }
    }
}
