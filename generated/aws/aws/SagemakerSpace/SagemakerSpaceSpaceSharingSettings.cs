using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettings")]
    public class SagemakerSpaceSpaceSharingSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#sharing_type SagemakerSpace#sharing_type}.</summary>
        [JsiiProperty(name: "sharingType", typeJson: "{\"primitive\":\"string\"}")]
        public string SharingType
        {
            get;
            set;
        }
    }
}
