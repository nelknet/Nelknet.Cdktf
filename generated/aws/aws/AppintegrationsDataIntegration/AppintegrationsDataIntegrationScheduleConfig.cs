using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppintegrationsDataIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appintegrationsDataIntegration.AppintegrationsDataIntegrationScheduleConfig")]
    public class AppintegrationsDataIntegrationScheduleConfig : aws.AppintegrationsDataIntegration.IAppintegrationsDataIntegrationScheduleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#first_execution_from AppintegrationsDataIntegration#first_execution_from}.</summary>
        [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}")]
        public string FirstExecutionFrom
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#object AppintegrationsDataIntegration#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#schedule_expression AppintegrationsDataIntegration#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduleExpression
        {
            get;
            set;
        }
    }
}
