using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppintegrationsDataIntegration
{
    [JsiiInterface(nativeType: typeof(IAppintegrationsDataIntegrationScheduleConfig), fullyQualifiedName: "aws.appintegrationsDataIntegration.AppintegrationsDataIntegrationScheduleConfig")]
    public interface IAppintegrationsDataIntegrationScheduleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#first_execution_from AppintegrationsDataIntegration#first_execution_from}.</summary>
        [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}")]
        string FirstExecutionFrom
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#object AppintegrationsDataIntegration#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#schedule_expression AppintegrationsDataIntegration#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleExpression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppintegrationsDataIntegrationScheduleConfig), fullyQualifiedName: "aws.appintegrationsDataIntegration.AppintegrationsDataIntegrationScheduleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppintegrationsDataIntegration.IAppintegrationsDataIntegrationScheduleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#first_execution_from AppintegrationsDataIntegration#first_execution_from}.</summary>
            [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string FirstExecutionFrom
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#object AppintegrationsDataIntegration#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
            public string Object
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#schedule_expression AppintegrationsDataIntegration#schedule_expression}.</summary>
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
