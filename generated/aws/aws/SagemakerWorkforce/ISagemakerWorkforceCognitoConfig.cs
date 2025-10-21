using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceCognitoConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig")]
    public interface ISagemakerWorkforceCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
        string UserPool
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceCognitoConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
            [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPool
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
