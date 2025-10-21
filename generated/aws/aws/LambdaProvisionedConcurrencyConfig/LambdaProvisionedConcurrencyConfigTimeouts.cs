using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaProvisionedConcurrencyConfig
{
    [JsiiByValue(fqn: "aws.lambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfigTimeouts")]
    public class LambdaProvisionedConcurrencyConfigTimeouts : aws.LambdaProvisionedConcurrencyConfig.ILambdaProvisionedConcurrencyConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#create LambdaProvisionedConcurrencyConfig#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#update LambdaProvisionedConcurrencyConfig#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
