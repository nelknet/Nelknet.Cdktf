namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerEndpointState<'EndpointConfigName> = { assignments: ResizeArray<aws.SagemakerEndpoint.SagemakerEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint">aws_sagemaker_endpoint</a>.
    /// </summary>
    type SagemakerEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerEndpointState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerEndpointState<Missing>)

        member _.Zero(()) : SagemakerEndpointState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerEndpointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#endpoint_config_name-1">SagemakerEndpoint#endpoint_config_name</a>.
        /// </summary>
        [<CustomOperation "endpoint_config_name">]
        member _.EndpointConfigName(state: SagemakerEndpointState<Missing>, value: string) : SagemakerEndpointState<Present> =
            state.assignments.Add(fun config -> config.EndpointConfigName <- value)
            ({ assignments = state.assignments } : SagemakerEndpointState<Present>)

        /// <summary>
        /// deployment_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#deployment_config-1">SagemakerEndpoint#deployment_config</a>
        /// </summary>
        [<CustomOperation "deployment_config">]
        member _.DeploymentConfig(state: SagemakerEndpointState<'EndpointConfigName>, value: aws.SagemakerEndpoint.SagemakerEndpointDeploymentConfig) : SagemakerEndpointState<'EndpointConfigName> =
            state.assignments.Add(fun config -> config.DeploymentConfig <- value)
            state : SagemakerEndpointState<'EndpointConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#id-1">SagemakerEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerEndpointState<'EndpointConfigName>, value: string) : SagemakerEndpointState<'EndpointConfigName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerEndpointState<'EndpointConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#name-1">SagemakerEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerEndpointState<'EndpointConfigName>, value: string) : SagemakerEndpointState<'EndpointConfigName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerEndpointState<'EndpointConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#tags-1">SagemakerEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerEndpointState<'EndpointConfigName>, value: seq<string * string>) : SagemakerEndpointState<'EndpointConfigName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerEndpointState<'EndpointConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#tags_all-1">SagemakerEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerEndpointState<'EndpointConfigName>, value: seq<string * string>) : SagemakerEndpointState<'EndpointConfigName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerEndpointState<'EndpointConfigName>

        member _.Run(state: SagemakerEndpointState<Present>) : aws.SagemakerEndpoint.SagemakerEndpoint =
            let config = aws.SagemakerEndpoint.SagemakerEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerEndpoint.SagemakerEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerEndpoint: missing required arguments. Must call: endpoint_config_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerEndpointState<_>) : aws.SagemakerEndpoint.SagemakerEndpoint =
            Unchecked.defaultof<aws.SagemakerEndpoint.SagemakerEndpoint>
