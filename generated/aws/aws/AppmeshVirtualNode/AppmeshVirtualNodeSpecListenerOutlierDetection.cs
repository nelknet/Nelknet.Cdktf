using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetection")]
    public class AppmeshVirtualNodeSpecListenerOutlierDetection : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetection
    {
        /// <summary>base_ejection_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#base_ejection_duration AppmeshVirtualNode#base_ejection_duration}
        /// </remarks>
        [JsiiProperty(name: "baseEjectionDuration", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}")]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration BaseEjectionDuration
        {
            get;
            set;
        }

        /// <summary>interval block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#interval AppmeshVirtualNode#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}")]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_ejection_percent AppmeshVirtualNode#max_ejection_percent}.</summary>
        [JsiiProperty(name: "maxEjectionPercent", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxEjectionPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_server_errors AppmeshVirtualNode#max_server_errors}.</summary>
        [JsiiProperty(name: "maxServerErrors", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxServerErrors
        {
            get;
            set;
        }
    }
}
