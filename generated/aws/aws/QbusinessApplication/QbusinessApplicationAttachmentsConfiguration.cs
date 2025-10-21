using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QbusinessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.qbusinessApplication.QbusinessApplicationAttachmentsConfiguration")]
    public class QbusinessApplicationAttachmentsConfiguration : aws.QbusinessApplication.IQbusinessApplicationAttachmentsConfiguration
    {
        /// <summary>Status information about whether file upload functionality is activated or deactivated for your end user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#attachments_control_mode QbusinessApplication#attachments_control_mode}
        /// </remarks>
        [JsiiProperty(name: "attachmentsControlMode", typeJson: "{\"primitive\":\"string\"}")]
        public string AttachmentsControlMode
        {
            get;
            set;
        }
    }
}
