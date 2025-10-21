using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2DedicatedIpAssignment
{
    [JsiiByValue(fqn: "aws.sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentTimeouts")]
    public class Sesv2DedicatedIpAssignmentTimeouts : aws.Sesv2DedicatedIpAssignment.ISesv2DedicatedIpAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#create Sesv2DedicatedIpAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#delete Sesv2DedicatedIpAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
