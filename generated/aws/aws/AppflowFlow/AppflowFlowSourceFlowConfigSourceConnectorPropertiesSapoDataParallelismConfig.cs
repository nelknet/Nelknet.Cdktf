using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig : aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#max_page_size AppflowFlow#max_page_size}.</summary>
        [JsiiProperty(name: "maxPageSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxPageSize
        {
            get;
            set;
        }
    }
}
