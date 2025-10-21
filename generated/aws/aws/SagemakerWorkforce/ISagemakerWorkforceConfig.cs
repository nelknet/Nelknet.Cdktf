using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceConfig")]
    public interface ISagemakerWorkforceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_name SagemakerWorkforce#workforce_name}.</summary>
        [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
        string WorkforceName
        {
            get;
        }

        /// <summary>cognito_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cognito_config SagemakerWorkforce#cognito_config}
        /// </remarks>
        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig? CognitoConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#id SagemakerWorkforce#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>oidc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#oidc_config SagemakerWorkforce#oidc_config}
        /// </remarks>
        [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig? OidcConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#source_ip_config SagemakerWorkforce#source_ip_config}
        /// </remarks>
        [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig? SourceIpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>workforce_vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_vpc_config SagemakerWorkforce#workforce_vpc_config}
        /// </remarks>
        [JsiiProperty(name: "workforceVpcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig? WorkforceVpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceConfig), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkforce.ISagemakerWorkforceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_name SagemakerWorkforce#workforce_name}.</summary>
            [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkforceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cognito_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cognito_config SagemakerWorkforce#cognito_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
            public aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig? CognitoConfig
            {
                get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#id SagemakerWorkforce#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>oidc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#oidc_config SagemakerWorkforce#oidc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
            public aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig? OidcConfig
            {
                get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig?>();
            }

            /// <summary>source_ip_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#source_ip_config SagemakerWorkforce#source_ip_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
            public aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig? SourceIpConfig
            {
                get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig?>();
            }

            /// <summary>workforce_vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_vpc_config SagemakerWorkforce#workforce_vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workforceVpcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfig\"}", isOptional: true)]
            public aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig? WorkforceVpcConfig
            {
                get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
