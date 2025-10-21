using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiInterface(nativeType: typeof(ISsmincidentsResponsePlanIntegrationPagerduty), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegrationPagerduty")]
    public interface ISsmincidentsResponsePlanIntegrationPagerduty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#name SsmincidentsResponsePlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#secret_id SsmincidentsResponsePlan#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#service_id SsmincidentsResponsePlan#service_id}.</summary>
        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmincidentsResponsePlanIntegrationPagerduty), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegrationPagerduty")]
        internal sealed class _Proxy : DeputyBase, aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIntegrationPagerduty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#name SsmincidentsResponsePlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#secret_id SsmincidentsResponsePlan#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#service_id SsmincidentsResponsePlan#service_id}.</summary>
            [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
