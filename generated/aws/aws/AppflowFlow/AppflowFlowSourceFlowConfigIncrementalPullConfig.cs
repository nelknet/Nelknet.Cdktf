using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig")]
    public class AppflowFlowSourceFlowConfigIncrementalPullConfig : aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#datetime_type_field_name AppflowFlow#datetime_type_field_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datetimeTypeFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatetimeTypeFieldName
        {
            get;
            set;
        }
    }
}
